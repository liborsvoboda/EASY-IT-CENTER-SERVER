using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("PortalActionTypeList")]
    [Index("Name", Name = "IX_PortalActionTypeList", IsUnique = true)]
    public partial class PortalActionTypeList
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Name { get; set; } = null!;
        [Unicode(false)]
        public string? Description { get; set; }
        [Unicode(false)]
        public string? CodeTemplate { get; set; }
        [Unicode(false)]
        public string Command { get; set; } = null!;
        public bool Public { get; set; }
        public bool Active { get; set; }
        public int UserId { get; set; }
        public DateTime TimeStamp { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("PortalActionTypeLists")]
        public virtual SolutionUserList User { get; set; } = null!;
    }
}
