using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("SharedMonacoSuggestionList")]
    [Index("Label", Name = "IX_SolutionMonacoSuggestionList", IsUnique = true)]
    public partial class SharedMonacoSuggestionList
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string MonacoLanguageListLanguage { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Label { get; set; } = null!;
        public int Kind { get; set; }
        [Unicode(false)]
        public string? Documentation { get; set; }
        [Unicode(false)]
        public string InsertText { get; set; } = null!;
        [Unicode(false)]
        public string? MdContent { get; set; }
        public int UserId { get; set; }
        public DateTime TimeStamp { get; set; }

        public virtual SharedMonacoLanguageList MonacoLanguageListLanguageNavigation { get; set; } = null!;
        [ForeignKey("UserId")]
        [InverseProperty("SharedMonacoSuggestionLists")]
        public virtual SolutionUserList User { get; set; } = null!;
    }
}
