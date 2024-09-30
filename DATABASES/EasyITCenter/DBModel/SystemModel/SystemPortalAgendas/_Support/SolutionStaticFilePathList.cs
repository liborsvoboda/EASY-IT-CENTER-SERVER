using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("SolutionStaticFilePathList")]
    [Index("Path", "UserId", Name = "IX_SolutionStaticFilePathList", IsUnique = true)]
    public partial class SolutionStaticFilePathList
    {
        public SolutionStaticFilePathList()
        {
            SolutionStaticFileLists = new HashSet<SolutionStaticFileList>();
        }

        [Key]
        public int Id { get; set; }
        public int WebsiteId { get; set; }
        [StringLength(512)]
        [Unicode(false)]
        public string Path { get; set; } = null!;
        public int Size { get; set; }
        public bool Active { get; set; }
        public int? UserId { get; set; }
        public DateTime TimeStamp { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("SolutionStaticFilePathLists")]
        public virtual SolutionUserList? User { get; set; }
        [ForeignKey("WebsiteId")]
        [InverseProperty("SolutionStaticFilePathLists")]
        public virtual SolutionWebsiteList Website { get; set; } = null!;
        [InverseProperty("StaticPath")]
        public virtual ICollection<SolutionStaticFileList> SolutionStaticFileLists { get; set; }
    }
}
