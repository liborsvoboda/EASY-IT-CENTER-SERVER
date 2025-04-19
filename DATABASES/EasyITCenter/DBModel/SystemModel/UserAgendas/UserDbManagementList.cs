using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("UserDbManagementList")]
    [Index("SystemName", Name = "IX_UserDbManagementList", IsUnique = true)]
    public partial class UserDbManagementList
    {
        [Key]
        public int Id { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string UserPrefix { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string InheritedDbType { get; set; } = null!;
        public int SystemName { get; set; }
        [Unicode(false)]
        public string? Description { get; set; }
        [StringLength(1024)]
        [Unicode(false)]
        public string? FilePath { get; set; }
        [Unicode(false)]
        public string? CodeTemplate { get; set; }
        [Unicode(false)]
        public string? Readme { get; set; }
        public bool Public { get; set; }
        public int UserId { get; set; }
        public bool Active { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Version { get; set; } = null!;
        public DateTime TimeStamp { get; set; }

        public virtual SolutionMixedEnumList InheritedDbTypeNavigation { get; set; } = null!;
        [ForeignKey("UserId")]
        [InverseProperty("UserDbManagementListUsers")]
        public virtual SolutionUserList User { get; set; } = null!;
        public virtual SolutionUserList UserPrefixNavigation { get; set; } = null!;
    }
}
