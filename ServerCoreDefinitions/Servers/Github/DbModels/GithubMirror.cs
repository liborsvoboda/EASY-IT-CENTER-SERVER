namespace EasyITCenter.GitServer.Models
{
    public class GithubMirror:GithubBaseEntity
    {
        public long RepositoryId { get; set; }
        public int Interval { get; set; }
        public DateTime Update { get; set; }
        public DateTime NextUpdate { get; set; }
        public string Address { get; set; }
    }
}
