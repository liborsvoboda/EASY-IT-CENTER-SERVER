using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("PortalGeneratorTypeList")]
    [Index("UserDbPreffix", "Name", Name = "IX_PortalGeneratorTypeList", IsUnique = true)]
    [Index("Name", Name = "IX_PortalGeneratorTypeList_1")]
    public partial class PortalGeneratorTypeList
    {
        public PortalGeneratorTypeList()
        {
            PortalGeneratedDataLists = new HashSet<PortalGeneratedDataList>();
            PortalGeneratorActionLists = new HashSet<PortalGeneratorActionList>();
            PortalGeneratorLists = new HashSet<PortalGeneratorList>();
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
        [Unicode(false)]
        public string? Command { get; set; }
        public bool Public { get; set; }
        public bool Active { get; set; }
        public int UserId { get; set; }
        public DateTime TimeStamp { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("PortalGeneratorTypeLists")]
        public virtual SolutionUserList User { get; set; } = null!;
        public virtual ICollection<PortalGeneratedDataList> PortalGeneratedDataLists { get; set; }
        public virtual ICollection<PortalGeneratorActionList> PortalGeneratorActionLists { get; set; }
        public virtual ICollection<PortalGeneratorList> PortalGeneratorLists { get; set; }
    }
}
