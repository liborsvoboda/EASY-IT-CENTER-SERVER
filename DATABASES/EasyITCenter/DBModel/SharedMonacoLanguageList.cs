using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("SharedMonacoLanguageList")]
    [Index("Language", Name = "IX_SharedMonacoLanguageList", IsUnique = true)]
    public partial class SharedMonacoLanguageList
    {
        public SharedMonacoLanguageList()
        {
            SharedMonacoSuggestionLists = new HashSet<SharedMonacoSuggestionList>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Language { get; set; } = null!;
        [Unicode(false)]
        public string? Description { get; set; }
        public bool Custom { get; set; }
        [Required]
        public bool Active { get; set; }
        public int SolutionUserListId { get; set; }
        public DateTime TimeStamp { get; set; }

        [ForeignKey("SolutionUserListId")]
        [InverseProperty("SharedMonacoLanguageLists")]
        public virtual SolutionUserList SolutionUserList { get; set; } = null!;
        public virtual ICollection<SharedMonacoSuggestionList> SharedMonacoSuggestionLists { get; set; }
    }
}
