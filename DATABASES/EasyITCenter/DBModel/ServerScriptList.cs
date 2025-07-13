using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("ServerScriptList")]
    [Index("Name", Name = "IX_ServerScriptList", IsUnique = true)]
    public partial class ServerScriptList
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string InheritedScriptType { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Name { get; set; } = null!;
        [Unicode(false)]
        public string? Description { get; set; }
        [Unicode(false)]
        public string ScriptContent { get; set; } = null!;
        [StringLength(1024)]
        [Unicode(false)]
        public string? SolutionUrl { get; set; }
        public bool Installed { get; set; }
        public int UserId { get; set; }
        public DateTime Timestamp { get; set; }

        public virtual SolutionMixedEnumList InheritedScriptTypeNavigation { get; set; } = null!;
        [ForeignKey("UserId")]
        [InverseProperty("ServerScriptLists")]
        public virtual SolutionUserList User { get; set; } = null!;
    }
}
