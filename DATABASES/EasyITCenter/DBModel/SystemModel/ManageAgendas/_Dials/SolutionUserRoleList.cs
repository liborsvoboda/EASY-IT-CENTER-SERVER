using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("SolutionUserRoleList")]
    [Index("MinimalAccessValue", Name = "IX_SolutionUserRoleList", IsUnique = true)]
    [Index("SystemName", Name = "IX_UserRoleList", IsUnique = true)]
    public partial class SolutionUserRoleList
    {
        public SolutionUserRoleList()
        {
            SolutionUserListRoleAccessValueNavigations = new HashSet<SolutionUserList>();
            SolutionUserListRoles = new HashSet<SolutionUserList>();
            TemplateLists = new HashSet<TemplateList>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string SystemName { get; set; } = null!;
        public int MinimalAccessValue { get; set; }
        [Unicode(false)]
        public string? Description { get; set; }
        public int? UserId { get; set; }
        public DateTime TimeStamp { get; set; }

        public virtual ICollection<SolutionUserList> SolutionUserListRoleAccessValueNavigations { get; set; }
        [InverseProperty("Role")]
        public virtual ICollection<SolutionUserList> SolutionUserListRoles { get; set; }
        [InverseProperty("Group")]
        public virtual ICollection<TemplateList> TemplateLists { get; set; }
    }
}
