using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("WebCodeLibraryList")]
    [Index("Name", Name = "IX_WebCodeLibraryList", IsUnique = true)]
    public partial class WebCodeLibraryList
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string InheritedCodeType { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Name { get; set; } = null!;
        [StringLength(2096)]
        [Unicode(false)]
        public string? Description { get; set; }
        [Unicode(false)]
        public string Content { get; set; } = null!;
        public bool IsCompletion { get; set; }
        public int UserId { get; set; }
        public DateTime TimeStamp { get; set; }

        public virtual SolutionMixedEnumList InheritedCodeTypeNavigation { get; set; } = null!;
        [ForeignKey("UserId")]
        [InverseProperty("WebCodeLibraryLists")]
        public virtual SolutionUserList User { get; set; } = null!;
    }
}
