using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("PortalDataTypeList")]
    [Index("Name", Name = "IX_PortalDataTypeList", IsUnique = true)]
    public partial class PortalDataTypeList
    {
        public PortalDataTypeList()
        {
            PortalActionHistoryLists = new HashSet<PortalActionHistoryList>();
            PortalHelpGroupLists = new HashSet<PortalHelpGroupList>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Name { get; set; } = null!;
        [Unicode(false)]
        public string? Description { get; set; }
        public bool Public { get; set; }
        public bool Active { get; set; }
        public int UserId { get; set; }
        public DateTime TimeStamp { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("PortalDataTypeLists")]
        public virtual SolutionUserList User { get; set; } = null!;
        public virtual ICollection<PortalActionHistoryList> PortalActionHistoryLists { get; set; }
        public virtual ICollection<PortalHelpGroupList> PortalHelpGroupLists { get; set; }
    }
}
