using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("SystemApplicationList")]
    [Index("Name", Name = "IX_SystemApplicationList", IsUnique = true)]
    public partial class SystemApplicationList
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string InheritedAppCategoryType { get; set; } = null!;
        [MaxLength(50)]
        public byte[] Name { get; set; } = null!;
        [Unicode(false)]
        public string? Description { get; set; }
        [Unicode(false)]
        public string MdContent { get; set; } = null!;
        [MaxLength(50)]
        public byte[] AppPathName { get; set; } = null!;
        [MaxLength(1024)]
        public byte[] StartUpCommand { get; set; } = null!;
        [Column(TypeName = "decimal(18, 0)")]
        public decimal AppDownloadPrice { get; set; }
        public int UserId { get; set; }
        public DateTime TimeStamp { get; set; }

        public virtual SolutionMixedEnumList InheritedAppCategoryTypeNavigation { get; set; } = null!;
        [ForeignKey("UserId")]
        [InverseProperty("SystemApplicationLists")]
        public virtual SolutionUserList User { get; set; } = null!;
    }
}
