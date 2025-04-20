using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("PortalInjectGroupList")]
    public partial class PortalInjectGroupList
    {
        public PortalInjectGroupList()
        {
            PortalInjectPageCodeLists = new HashSet<PortalInjectPageCodeList>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string UserDbPreffix { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Name { get; set; } = null!;
        [Unicode(false)]
        public string? Description { get; set; }
        [Unicode(false)]
        public string? CodeTemplate { get; set; }
        public bool Public { get; set; }
        public bool Active { get; set; }
        public int UserId { get; set; }
        public DateTime TimeStamp { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("PortalInjectGroupLists")]
        public virtual SolutionUserList User { get; set; } = null!;
        [InverseProperty("InjectGroup")]
        public virtual ICollection<PortalInjectPageCodeList> PortalInjectPageCodeLists { get; set; }
    }
}
