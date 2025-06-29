using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("PortalApiTableColumnList")]
    [Index("UserPrefix", "ApiTable", "Name", Name = "IX_PortalApiTableColumnList", IsUnique = true)]
    [Index("Name", Name = "IX_PortalApiTableColumnList_1", IsUnique = true)]
    public partial class PortalApiTableColumnList
    {
        public PortalApiTableColumnList()
        {
            PortalApiTableColumnDataListApiTableColumnNavigations = new HashSet<PortalApiTableColumnDataList>();
            PortalApiTableColumnDataListPortalApiTableColumnLists = new HashSet<PortalApiTableColumnDataList>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string UserPrefix { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string ApiTable { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string? InheritedDataType { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Name { get; set; } = null!;
        [Unicode(false)]
        public string? Description { get; set; }
        public bool Public { get; set; }
        public bool Active { get; set; }
        public int UserId { get; set; }
        public DateTime TimeStamp { get; set; }

        public virtual SolutionMixedEnumList? InheritedDataTypeNavigation { get; set; }
        public virtual PortalApiTableList PortalApiTableList { get; set; } = null!;
        [ForeignKey("UserId")]
        [InverseProperty("PortalApiTableColumnListUsers")]
        public virtual SolutionUserList User { get; set; } = null!;
        public virtual SolutionUserList UserPrefixNavigation { get; set; } = null!;
        public virtual ICollection<PortalApiTableColumnDataList> PortalApiTableColumnDataListApiTableColumnNavigations { get; set; }
        public virtual ICollection<PortalApiTableColumnDataList> PortalApiTableColumnDataListPortalApiTableColumnLists { get; set; }
    }
}
