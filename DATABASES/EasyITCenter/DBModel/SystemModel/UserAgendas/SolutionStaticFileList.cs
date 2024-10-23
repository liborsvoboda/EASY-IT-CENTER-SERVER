using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("SolutionStaticFileList")]
    [Index("FileNamePath", "UserId", Name = "IX_SolutionStaticFileList", IsUnique = true)]
    public partial class SolutionStaticFileList
    {
        [Key]
        public int Id { get; set; }
        public int WebsiteId { get; set; }
        public int StaticPathId { get; set; }
        [StringLength(512)]
        [Unicode(false)]
        public string FileNamePath { get; set; } = null!;
        [StringLength(150)]
        [Unicode(false)]
        public string MimeType { get; set; } = null!;
        public byte[]? Content { get; set; }
        public bool Active { get; set; }
        public int? UserId { get; set; }
        public DateTime TimeStamp { get; set; }

        [ForeignKey("StaticPathId")]
        [InverseProperty("SolutionStaticFileLists")]
        public virtual SolutionStaticFilePathList StaticPath { get; set; } = null!;
        [ForeignKey("UserId")]
        [InverseProperty("SolutionStaticFileLists")]
        public virtual SolutionUserList? User { get; set; }
        [ForeignKey("WebsiteId")]
        [InverseProperty("SolutionStaticFileLists")]
        public virtual SolutionWebsiteList Website { get; set; } = null!;
    }
}
