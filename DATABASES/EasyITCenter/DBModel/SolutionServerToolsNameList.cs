using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("SolutionServerToolsNameList")]
    [Index("Name", "Version", Name = "IX_SolutionServerToolsNameList", IsUnique = true)]
    [Index("SystemGroupMenuListName", Name = "IX_SolutionServerToolsNameList_1")]
    public partial class SolutionServerToolsNameList
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string SystemGroupMenuListName { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Name { get; set; } = null!;
        [Unicode(false)]
        public string? Description { get; set; }
        [Unicode(false)]
        public string? HeaderStylePart { get; set; }
        [Unicode(false)]
        public string? HeaderScriptPart { get; set; }
        [Unicode(false)]
        public string? InstallScript { get; set; }
        [Unicode(false)]
        public string? HtmlContent { get; set; }
        [Unicode(false)]
        public string? JsContent { get; set; }
        [Unicode(false)]
        public string? CssContent { get; set; }
        [Unicode(false)]
        public string? MdContent { get; set; }
        [Unicode(false)]
        public string DownloadPackage { get; set; } = null!;
        [Column(TypeName = "decimal(10, 0)")]
        public decimal? Price { get; set; }
        public int Version { get; set; }
        public int UserId { get; set; }
        public DateTime TimeStamp { get; set; }

        [ForeignKey("SystemGroupMenuListName")]
        [InverseProperty("SolutionServerToolsNameLists")]
        public virtual SolutionServerToolsGroupList SystemGroupMenuListNameNavigation { get; set; } = null!;
        [ForeignKey("UserId")]
        [InverseProperty("SolutionServerToolsNameLists")]
        public virtual SolutionUserList User { get; set; } = null!;
    }
}
