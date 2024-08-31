using LibGit2Sharp;

namespace EasyITCenter.GitServer.Models
{
	public class GithubFileViewModel {
		private Repository _repository;
		private GitObject _object;
		private string _path;
		private string _name;

		public Repository Repository => _repository;
        public GitObject Object => _object;

		public string SHA1 => _object.Sha;
		public ObjectType Type => Repository.ObjectDatabase.RetrieveObjectMetadata(_object.Id).Type;
		public string Path => _path;
		public string Name => _name;

		protected internal GithubFileViewModel(Repository repo, string path, string name, GitObject obj)
		{
			_repository = repo;
			_path = path;
			_name = name;
			_object = obj;
		}

		public static GithubFileViewModel FromGitObject(Repository repo, string path, string name, GitObject obj)
		{
			switch(repo.ObjectDatabase.RetrieveObjectMetadata(obj.Id).Type)
			{
				case ObjectType.Blob:
					return new GithubBlobModel(repo, path, name, (Blob)obj);

				case ObjectType.Tree:
					return new GithubTreeModel(repo, path, name, (Tree)obj);

				default:
					return null;
			}
		}
	}

	public class GithubFileViewModel<TObject> : GithubFileViewModel where TObject : GitObject
    {
		protected new TObject Object => (TObject)base.Object;

		protected internal GithubFileViewModel(Repository repo, string path, string name, TObject obj) : base(repo, path, name, obj) { }
	}
}
