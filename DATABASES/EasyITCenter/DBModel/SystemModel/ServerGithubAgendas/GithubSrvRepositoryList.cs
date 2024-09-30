using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("GithubSrvRepositoryList")]
    public partial class GithubSrvRepositoryList
    {
        public GithubSrvRepositoryList()
        {
            GithubSrvTeamRepositoryRoleLists = new HashSet<GithubSrvTeamRepositoryRoleList>();
        }

        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        [StringLength(150)]
        [Unicode(false)]
        public string? UserName { get; set; }
        [StringLength(150)]
        [Unicode(false)]
        public string? Name { get; set; }
        [Unicode(false)]
        public string? Description { get; set; }
        [StringLength(1024)]
        [Unicode(false)]
        public string? DefaultBranch { get; set; }
        public int NumIssues { get; set; }
        public int NumOpenIssues { get; set; }
        public int NumPulls { get; set; }
        public int NumOpenPulls { get; set; }
        public DateTime CreationDate { get; set; }
        public bool IsPrivate { get; set; }
        public bool IsMirror { get; set; }
        public long Size { get; set; }
        public DateTime UpdateTime { get; set; }
        public DateTime TimeStamp { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("GithubSrvRepositoryLists")]
        public virtual SolutionUserList User { get; set; } = null!;
        [InverseProperty("Repository")]
        public virtual ICollection<GithubSrvTeamRepositoryRoleList> GithubSrvTeamRepositoryRoleLists { get; set; }
    }
}
