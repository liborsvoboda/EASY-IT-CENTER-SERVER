using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("PortalHelpGroupList")]
    [Index("UserPreffix", "DataType", "Name", Name = "IX_PortalHelpGroupList", IsUnique = true)]
    [Index("DataType", Name = "IX_PortalHelpGroupList_1")]
    public partial class PortalHelpGroupList
    {
        public PortalHelpGroupList()
        {
            PortalHelpDataLists = new HashSet<PortalHelpDataList>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string UserPreffix { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string DataType { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Name { get; set; } = null!;
        [Unicode(false)]
        public string? Description { get; set; }
        [Unicode(false)]
        public string? Readme { get; set; }
        public bool Public { get; set; }
        public bool Active { get; set; }
        public int UserId { get; set; }
        public DateTime TimeStamp { get; set; }

        public virtual PortalDataTypeList DataTypeNavigation { get; set; } = null!;
        [ForeignKey("UserId")]
        [InverseProperty("PortalHelpGroupLists")]
        public virtual SolutionUserList User { get; set; } = null!;
        public virtual ICollection<PortalHelpDataList> PortalHelpDataLists { get; set; }
    }
}
