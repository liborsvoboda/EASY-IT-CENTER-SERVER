using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("PortalApiTableTypeList")]
    [Index("Name", Name = "IX_PortalApiTableTypeList", IsUnique = true)]
    public partial class PortalApiTableTypeList
    {
        public PortalApiTableTypeList()
        {
            PortalApiTableLists = new HashSet<PortalApiTableList>();
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
        [InverseProperty("PortalApiTableTypeLists")]
        public virtual SolutionUserList User { get; set; } = null!;
        public virtual ICollection<PortalApiTableList> PortalApiTableLists { get; set; }
    }
}
