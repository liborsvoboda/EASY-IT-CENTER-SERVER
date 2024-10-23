using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("GithubSrvTeamRepositoryRoleList")]
    [Index("TeamId", "RepositoryId", Name = "IX_GithubSrvTeamRepositoryRoleList", IsUnique = true)]
    [Index("RepositoryId", Name = "IX_GithubSrvTeamRepositoryRoleList_RepositoryId")]
    public partial class GithubSrvTeamRepositoryRoleList
    {
        [Key]
        public int Id { get; set; }
        public int TeamId { get; set; }
        public int RepositoryId { get; set; }
        public bool AllowRead { get; set; }
        public bool AllowWrite { get; set; }
        public DateTime TimeStamp { get; set; }

        [ForeignKey("RepositoryId")]
        [InverseProperty("GithubSrvTeamRepositoryRoleLists")]
        public virtual GithubSrvRepositoryList Repository { get; set; } = null!;
        [ForeignKey("TeamId")]
        [InverseProperty("GithubSrvTeamRepositoryRoleLists")]
        public virtual GithubSrvTeamList Team { get; set; } = null!;
    }
}
