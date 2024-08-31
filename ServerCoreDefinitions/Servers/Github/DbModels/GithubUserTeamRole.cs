namespace EasyITCenter.GitServer.Models
{
    public class UserTeamRole
    {
        public long UserId { get; set; }
        public long TeamId { get; set; }
        public bool IsAdministrator { get; set; }
        public virtual GithubSrvTeamList Team { get; set; }
        public virtual SolutionUserList User { get; set; }
    }
}
