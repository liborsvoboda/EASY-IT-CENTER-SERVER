using LibGit2Sharp;

namespace EasyITCenter.GitServer.Models
{
	public class GithubBlobModel : GithubFileViewModel<Blob>
	{
		public bool IsBinary => Object.IsBinary;

		public string Content => Object.GetContentText();
		public long Size => Repository.ObjectDatabase.RetrieveObjectMetadata(Object.Id).Size;

		public GithubBlobModel(Repository repo, string path, string name, Blob obj) : base(repo, path, name, obj) { }
	}
}
