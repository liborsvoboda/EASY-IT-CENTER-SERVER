using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("SolutionStaticWebList")]
    [Index("WebsiteName", Name = "IX_SolutionStaticWebList", IsUnique = true)]
    public partial class SolutionStaticWebList
    {
        public SolutionStaticWebList()
        {
            SolutionStaticFileLists = new HashSet<SolutionStaticFileList>();
            SolutionStaticFilePathLists = new HashSet<SolutionStaticFilePathList>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string WebsiteName { get; set; } = null!;
        [Unicode(false)]
        public string? Description { get; set; }
        public int MinimalReadAccessValue { get; set; }
        public int MinimalWriteAccessValue { get; set; }
        public int UserId { get; set; }
        [Required]
        public bool Active { get; set; }
        public DateTime TimeStamp { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("SolutionStaticWebLists")]
        public virtual SolutionUserList User { get; set; } = null!;
        [InverseProperty("StaticWeb")]
        public virtual ICollection<SolutionStaticFileList> SolutionStaticFileLists { get; set; }
        [InverseProperty("StaticWeb")]
        public virtual ICollection<SolutionStaticFilePathList> SolutionStaticFilePathLists { get; set; }
    }
}
