using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("ServerGeneratorList")]
    [Index("Name", Name = "IX_ServerGeneratorList", IsUnique = true)]
    public partial class ServerGeneratorList
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string InheritedCategoryType { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Name { get; set; } = null!;
        [Unicode(false)]
        public string? Description { get; set; }
        [Unicode(false)]
        public string MdContent { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string GeneratorPathName { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string InheritedUploadType { get; set; } = null!;
        [StringLength(1024)]
        [Unicode(false)]
        public string UploadPath { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string InheritedProcessType { get; set; } = null!;
        [StringLength(1024)]
        [Unicode(false)]
        public string StartupCommand { get; set; } = null!;
        [StringLength(1024)]
        [Unicode(false)]
        public string? FinishCommand { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string InheritedDownloadType { get; set; } = null!;
        [StringLength(1024)]
        [Unicode(false)]
        public string DownloadPath { get; set; } = null!;
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? GeneratorRunPrice { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal GeneratorDownloadPrice { get; set; }
        public int UserId { get; set; }
        public DateTime TimeStamp { get; set; }

        public virtual SolutionMixedEnumList InheritedCategoryTypeNavigation { get; set; } = null!;
        public virtual SolutionMixedEnumList InheritedDownloadTypeNavigation { get; set; } = null!;
        public virtual SolutionMixedEnumList InheritedProcessTypeNavigation { get; set; } = null!;
        public virtual SolutionMixedEnumList InheritedUploadTypeNavigation { get; set; } = null!;
        [ForeignKey("UserId")]
        [InverseProperty("ServerGeneratorLists")]
        public virtual SolutionUserList User { get; set; } = null!;
    }
}
