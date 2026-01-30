using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("SystemApplicationList")]
    public partial class SystemApplicationList
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string InheritedAppCategoryType { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string InheritedAppType { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Name { get; set; } = null!;
        [Unicode(false)]
        public string? Description { get; set; }
        [Unicode(false)]
        public string MdContent { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string AppPathName { get; set; } = null!;
        [StringLength(1024)]
        [Unicode(false)]
        public string StartUpCommand { get; set; } = null!;
        [Column(TypeName = "decimal(18, 0)")]
        public decimal ApplicationCredit { get; set; }
        public int UserId { get; set; }
        public DateTime TimeStamp { get; set; }

        public virtual SolutionMixedEnumList InheritedAppCategoryTypeNavigation { get; set; } = null!;
        public virtual SolutionMixedEnumList InheritedAppTypeNavigation { get; set; } = null!;
        [ForeignKey("UserId")]
        [InverseProperty("SystemApplicationLists")]
        public virtual SolutionUserList User { get; set; } = null!;
    }
}
