using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("PortalGeneratorActionList")]
    [Index("UserPrefix", "GeneratorType", "GeneratorId", "Name", Name = "IX_PortalGeneratorActionList", IsUnique = true)]
    [Index("UserPrefix", "GeneratorId", "Sequence", Name = "IX_PortalGeneratorActionList_1")]
    public partial class PortalGeneratorActionList
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
        public int? TemplateTypeId { get; set; }
        public int Sequence { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Name { get; set; } = null!;
        [Unicode(false)]
        public string? Description { get; set; }
        [Unicode(false)]
        public string? CodeTemplate { get; set; }
        [Unicode(false)]
        public string? Readme { get; set; }
        [StringLength(900)]
        [Unicode(false)]
        public string? SourceUrl { get; set; }
        [StringLength(900)]
        [Unicode(false)]
        public string? TargetUrl { get; set; }
        public bool Public { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? InheritedCommandType { get; set; }
        [Unicode(false)]
        public string? PostCommand { get; set; }
        public int UserId { get; set; }
        public bool Active { get; set; }
        public DateTime TimeStamp { get; set; }

        [ForeignKey("GeneratorId")]
        [InverseProperty("PortalGeneratorActionLists")]
        public virtual PortalGeneratorList Generator { get; set; } = null!;
        public virtual SolutionMixedEnumList? InheritedCommandTypeNavigation { get; set; }
        public virtual PortalGeneratorTypeList PortalGeneratorTypeList { get; set; } = null!;
        [ForeignKey("TemplateTypeId")]
        [InverseProperty("PortalGeneratorActionLists")]
        public virtual PortalTemplateTypeList? TemplateType { get; set; }
    }
}
