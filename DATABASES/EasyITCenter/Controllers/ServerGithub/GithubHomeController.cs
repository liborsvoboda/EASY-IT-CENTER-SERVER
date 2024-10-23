using EasyITCenter.GitServer.Services;
using EasyITCenter.GitServer.Settings;
using Microsoft.Extensions.Options;
using EasyITCenter.GitServer.Interfaces;
using EasyITCenter.GitServer.Repositorys;

namespace EasyITCenter.GitServer.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public class GithubHomeController : GitControllerBase
    {
        private EasyITCenterContext _repository;

        public GithubHomeController(
            IOptions<GitSettings> gitOptions,
            GitRepositoryService repoService,
			EasyITCenterContext repository
        )
            : base(gitOptions, repoService) {
            _repository = repository;
        }

        [Authorize]
        public IActionResult Home()
        {
            var username = HttpContext.User.Identity.Name;
            var reps = new EasyITCenterContext().GithubSrvRepositoryLists.Where(r => r.UserName == username).ToList();
            return View(reps);
        }

        [Authorize]
        public IActionResult Shared() {
            var reps = new EasyITCenterContext().GithubSrvRepositoryLists.Where(r => r.IsPrivate == false).ToList();
            return View(reps);
        }

        public IActionResult Public() {
            var reps = new EasyITCenterContext().GithubSrvRepositoryLists.Where(r => r.IsMirror == true).ToList();
            return View(reps);
        }

        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult Create(string name, string isPrivate, string isMirror, string remoteurl, string description)
        {
            LibGit2Sharp.Repository result = null;
            name = name.Trim();
            var username = HttpContext.User.Identity.Name;
            var reps = new EasyITCenterContext().GithubSrvRepositoryLists.Where(r => r.UserName == username).ToList();
            //if (reps.Count > 9)
            //    return View(new { error = "You have Max Limit Repositories 9 " });
            if (reps.Exists(r => r.Name == name))
                return View(new { error = "GenericApiService with same Name Exist" });
            if (!string.IsNullOrEmpty(name) && string.IsNullOrEmpty(remoteurl))
            {
                result = RepositoryService.CreateRepository(Path.Combine(username, name));
            }
            else if (!string.IsNullOrEmpty(remoteurl))
            {
                remoteurl = remoteurl.Trim();
                result = RepositoryService.CreateRepository(Path.Combine(username, name), remoteurl);
            }
            if (result != null)
            {
                var test = new EasyITCenterContext();
                var rep = new GithubSrvRepositoryList() {
                    Name = name,
                    Description = description,
                    CreationDate = DateTime.Now,
                    DefaultBranch = "master",
                    UserId = int.Parse(HttpContext.User.Claims.First(a => a.Type == ClaimTypes.PrimarySid).Value),
                    UserName = username,
                    IsPrivate = isPrivate == "on" ? true : false,
                    IsMirror = isMirror == "on" ? true : false,  //used for Public 
                    UpdateTime = DateTime.Now
                };
				new EasyITCenterContext().GithubSrvRepositoryLists.Add(rep);
                return Redirect("/");
            }
            return View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> DeleteRepository(int id) {
            LibGit2Sharp.Repository result = null;
            var username = HttpContext.User.Identity.Name;
            var reps = new EasyITCenterContext().GithubSrvRepositoryLists.Where(r => r.UserName == username).ToList();
            if (reps.Exists(r => r.Id == id)) {
                RepositoryService.DeleteRepository(Path.Combine(username, reps.First(a => a.Id == id).Name));
				var test = new EasyITCenterContext().GithubSrvRepositoryLists.Remove(reps.First(a => a.Id == id));
                await test.Context.SaveChangesAsync();
            }
            return Redirect("/");
        }
    }
}