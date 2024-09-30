using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("PortalApiTableList")]
    [Index("UserPrefix", "Name", Name = "IX_PortalApiTableList", IsUnique = true)]
    [Index("UserPrefix", Name = "IX_PortalApiTableList_1")]
    [Index("Name", Name = "IX_PortalApiTableList_2")]
    public partial class PortalApiTableList
    {
        public PortalApiTableList()
        {
            PortalApiTableColumnLists = new HashSet<PortalApiTableColumnList>();
            PortalDataHistoryLists = new HashSet<PortalDataHistoryList>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string UserPrefix { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string TableType { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Name { get; set; } = null!;
        [Unicode(false)]
        public string? Description { get; set; }
        public bool Public { get; set; }
        public bool Active { get; set; }
        public int UserId { get; set; }
        public DateTime TimeStamp { get; set; }

        public virtual SolutionTableTypeList TableTypeNavigation { get; set; } = null!;
        [ForeignKey("UserId")]
        [InverseProperty("PortalApiTableLists")]
        public virtual SolutionUserList User { get; set; } = null!;
        public virtual ICollection<PortalApiTableColumnList> PortalApiTableColumnLists { get; set; }
        public virtual ICollection<PortalDataHistoryList> PortalDataHistoryLists { get; set; }
    }
}
