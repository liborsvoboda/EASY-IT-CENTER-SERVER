using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("SolutionServerToolVariableList")]
    [Index("ToolName", "VariableName", Name = "IX_SolutionServerToolVariableList", IsUnique = true)]
    public partial class SolutionServerToolVariableList
    {
        [Key]
        public int Id { get; set; }
        [StringLength(150)]
        [Unicode(false)]
        public string ToolName { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string VariableName { get; set; } = null!;
        [Unicode(false)]
        public string JsonContent { get; set; } = null!;
        public int SolutionUserListId { get; set; }
        public DateTime TimeStamp { get; set; }

        [ForeignKey("SolutionUserListId")]
        [InverseProperty("SolutionServerToolVariableLists")]
        public virtual SolutionUserList SolutionUserList { get; set; } = null!;
    }
}
