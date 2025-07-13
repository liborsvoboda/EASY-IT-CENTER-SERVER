using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("PortalGeneratedDataList")]
    [Index("UserPrefix", "GeneratorId", "Sequence", Name = "IX_PortalGeneratedDataList")]
    [Index("InheritedGeneratorType", "GeneratorId", Name = "IX_PortalGeneratedDataList_1")]
    [Index("InheritedGeneratorType", Name = "IX_PortalGeneratedDataList_2")]
    public partial class PortalGeneratedDataList
    {
        [Key]
        public int Id { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? UserPrefix { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string InheritedGeneratorType { get; set; } = null!;
        public int GeneratorId { get; set; }
        public int Sequence { get; set; }
        [Unicode(false)]
        public string Content { get; set; } = null!;
        [Unicode(false)]
        public string? Description { get; set; }
        [StringLength(900)]
        [Unicode(false)]
        public string? TargetUrl { get; set; }
        [Unicode(false)]
        public string? ScriptContent { get; set; }
        [Unicode(false)]
        public string? CodeContent { get; set; }
        [StringLength(4000)]
        [Unicode(false)]
        public string? Command { get; set; }
        public bool Public { get; set; }
        public int UserId { get; set; }
        public bool Active { get; set; }
        public DateTime TimeStamp { get; set; }

        [ForeignKey("GeneratorId")]
        [InverseProperty("PortalGeneratedDataLists")]
        public virtual PortalGeneratorList Generator { get; set; } = null!;
        public virtual SolutionMixedEnumList InheritedGeneratorTypeNavigation { get; set; } = null!;
        [ForeignKey("UserId")]
        [InverseProperty("PortalGeneratedDataListUsers")]
        public virtual SolutionUserList User { get; set; } = null!;
        public virtual SolutionUserList? UserPrefixNavigation { get; set; }
    }
}
