using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("SolutionMonacoSuggestionList")]
    [Index("Label", Name = "IX_SolutionMonacoSuggestionList", IsUnique = true)]
    public partial class SolutionMonacoSuggestionList
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string InheritedMonacoLanguageType { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Label { get; set; } = null!;
        public int Kind { get; set; }
        [Unicode(false)]
        public string? Documentation { get; set; }
        [Unicode(false)]
        public string InsertText { get; set; } = null!;
        public int UserId { get; set; }
        public DateTime TimeStamp { get; set; }

        public virtual SolutionMixedEnumList InheritedMonacoLanguageTypeNavigation { get; set; } = null!;
        [ForeignKey("UserId")]
        [InverseProperty("SolutionMonacoSuggestionLists")]
        public virtual SolutionUserList User { get; set; } = null!;
    }
}
