using EasyITCenter.GitServer.Models;
using EasyITCenter.GitServer.Services;
using EasyITCenter.GitServer.Settings;
using LibGit2Sharp;
using Microsoft.Extensions.Options;

namespace EasyITCenter.GitServer.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public class GitControllerBase : Controller
    {
		private IOptions<GitSettings> _gitOptions;
		private GitRepositoryService _repoService;

		protected GitSettings GitSettings => _gitOptions.Value;
		protected GitRepositoryService RepositoryService => _repoService;

		protected GitControllerBase(
			IOptions<GitSettings> gitOptions,
			GitRepositoryService repoService
		)
		{
			_gitOptions = gitOptions;
			_repoService = repoService;
		}


		protected GitRepositoryApi GitCommand(string repoName, string service, bool advertiseRefs, bool endStreamWithNull = true)
		{
			return new GitRepositoryApi(_gitOptions.Value.GitPath, new GitCommandOptions(
				RepositoryService.GetRepository(repoName),
				service,
				advertiseRefs,
				endStreamWithNull
			));
		}

		protected GitRepositoryApi GitUploadPack(string repoName) => GitCommand(repoName, "git-upload-pack", false, false);
		protected GitRepositoryApi GitReceivePack(string repoName) => GitCommand(repoName, "git-receive-pack", false);

		protected IActionResult TryGetResult(string repoName, Func<IActionResult> resFunc)
		{
			try
			{
				return resFunc();
			}
			catch(RepositoryNotFoundException)
			{
				return MakeError("GenericApiService not found", repoName, 404);
			}
			catch(NotFoundException)
			{
				return MakeError("The requested file could not be found", repoName, 404);
			}
			catch(Exception e)
			{
				return MakeError(e, repoName);
			}
		}

		private IActionResult MakeError(string message, string repoName, int statusCode = 500)
		{
            GithubErrorModel model = new GithubErrorModel
			{
				StatusCode = statusCode,
				Message = message,
				Description = $"An error occured while accessing repository \"{repoName}\": {message}"
			};

			ViewResult viewResult = View("_Error", model);
			viewResult.StatusCode = statusCode;
			return viewResult;
		}

		private IActionResult MakeError(Exception error, string repoName, int statusCode = 500)
		{
			return MakeError(error.Message, repoName, statusCode);
		}
	}
}
