using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("GithubSrvUserTeamRoleList")]
    [Index("TeamId", "UserId", Name = "IX_GithubSrvUserTeamRoleList", IsUnique = true)]
    [Index("TeamId", Name = "IX_GithubSrvUserTeamRoleList_TeamId")]
    public partial class GithubSrvUserTeamRoleList
    {
        [Key]
        public int Id { get; set; }
        public int TeamId { get; set; }
        public bool IsAdmin { get; set; }
        public int UserId { get; set; }
        public DateTime TimeStamp { get; set; }

        [ForeignKey("TeamId")]
        [InverseProperty("GithubSrvUserTeamRoleLists")]
        public virtual GithubSrvTeamList Team { get; set; } = null!;
        [ForeignKey("UserId")]
        [InverseProperty("GithubSrvUserTeamRoleLists")]
        public virtual SolutionUserList User { get; set; } = null!;
    }
}
