using LibGit2Sharp;

namespace EasyITCenter.GitServer.Models
{
	public class GithubTreeModel : GithubFileViewModel<Tree>
	{
		private string _parent;

		public string Parent => _parent;
		public IEnumerable<GithubFileViewModel> Children => Object.Select(d => FromGitObject(Repository, d.Path, d.Name, d.Target));

		public GithubTreeModel(Repository repo, string path, string name, Tree obj, string parent = null) : base(repo, path, name, obj)
		{
			_parent = parent;
		}
	}
}
