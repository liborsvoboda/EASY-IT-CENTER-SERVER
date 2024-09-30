using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("GithubSrvTeamList")]
    public partial class GithubSrvTeamList
    {
        public GithubSrvTeamList()
        {
            GithubSrvTeamRepositoryRoleLists = new HashSet<GithubSrvTeamRepositoryRoleList>();
            GithubSrvUserTeamRoleLists = new HashSet<GithubSrvUserTeamRoleList>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(150)]
        [Unicode(false)]
        public string? Name { get; set; }
        [Unicode(false)]
        public string? Description { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime TimeStamp { get; set; }

        [InverseProperty("Team")]
        public virtual ICollection<GithubSrvTeamRepositoryRoleList> GithubSrvTeamRepositoryRoleLists { get; set; }
        [InverseProperty("Team")]
        public virtual ICollection<GithubSrvUserTeamRoleList> GithubSrvUserTeamRoleLists { get; set; }
    }
}
