using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("PortalGeneratedDataList")]
    [Index("UserPrefix", "GeneratorId", "Sequence", Name = "IX_PortalGeneratedDataList")]
    [Index("GeneratorType", "GeneratorId", Name = "IX_PortalGeneratedDataList_1")]
    [Index("GeneratorType", Name = "IX_PortalGeneratedDataList_2")]
    public partial class PortalGeneratedDataList
    {
        [Key]
        public int Id { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string UserPrefix { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string GeneratorType { get; set; } = null!;
        public int GeneratorId { get; set; }
        public int Sequence { get; set; }
        [Unicode(false)]
        public string Content { get; set; } = null!;
        [Unicode(false)]
        public string? Description { get; set; }
        [StringLength(900)]
        [Unicode(false)]
        public string? TargetUrl { get; set; }
        public bool Public { get; set; }
        [Unicode(false)]
        public string? Script { get; set; }
        [Unicode(false)]
        public string? CodeTemplate { get; set; }
        [StringLength(4000)]
        [Unicode(false)]
        public string? Command { get; set; }
        public int UserId { get; set; }
        public bool Active { get; set; }
        public DateTime TimeStamp { get; set; }

        public virtual PortalGeneratorTypeList PortalGeneratorTypeList { get; set; } = null!;
        [ForeignKey("UserId")]
        [InverseProperty("PortalGeneratedDataLists")]
        public virtual SolutionUserList User { get; set; } = null!;
    }
}
