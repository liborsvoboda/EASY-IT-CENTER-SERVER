namespace EasyITCenter.GitServer.Models
{
    public class githubIssue:GithubBaseEntity
    {
        public long UserId { get; set; }
        public long RepositoryId { get; set; }
        public int Index { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsPull { get; set; }
        public bool IsClosed { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
