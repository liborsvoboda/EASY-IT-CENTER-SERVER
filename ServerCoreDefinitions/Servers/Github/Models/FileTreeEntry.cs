using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using LibGit2Sharp;

namespace EasyITCenter.GitServer.Models
{
	public class GithubFileTreeEntry : IEnumerable<GithubFileTreeEntry>
	{
		private string _repoName, _path;
		private GitObject _object;
		private GithubFileTreeEntry _parent = null;

		public string Path => _path.Replace(System.IO.Path.DirectorySeparatorChar, '/');
		public string Name => System.IO.Path.GetFileName(_path);

		public string Extension {
			get
			{
				if (!IsFile)
					throw new InvalidOperationException();

				return System.IO.Path.GetExtension(_path);
			}
		}

		public string RepoName => _repoName;

		public bool IsFile => _object is LibGit2Sharp.Blob;
		public bool IsDirectory => _object is LibGit2Sharp.Tree;

		public bool IsBinary => IsFile && ((LibGit2Sharp.Blob)_object).IsBinary;

		public string ContentString
		{
			get
			{
				if (!IsFile)
					throw new InvalidOperationException();

				return ((LibGit2Sharp.Blob)_object).GetContentText();
			}
		}

		public Stream ContentStream
		{
			get
			{
				if (!IsFile)
					throw new InvalidOperationException();

				return ((LibGit2Sharp.Blob)_object).GetContentStream();
			}
		}

		public GithubFileTreeEntry(string repoName, string path, GitObject obj)
		{
			_repoName = repoName;
			_path = path;
			_object = obj;
		}

		public IEnumerator<GithubFileTreeEntry> GetEnumerator()
		{
			if (!IsDirectory)
				yield break;

			if (_parent != null)
				yield return _parent;

			foreach (TreeEntry entry in (LibGit2Sharp.Tree)_object)
			{
                GithubFileTreeEntry res = new GithubFileTreeEntry(_repoName, entry.Path, entry.Target);
				res._parent = this;
				yield return res;
			}
		}

		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
	}
}