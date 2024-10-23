using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("PortalGeneratorTemplateList")]
    public partial class PortalGeneratorTemplateList
    {
        [Key]
        public int Id { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string UserPrefix { get; set; } = null!;
        public int TemplateTypeId { get; set; }
        public int GeneratorId { get; set; }
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
        [StringLength(50)]
        [Unicode(false)]
        public string InheritedCommandType { get; set; } = null!;
        [Unicode(false)]
        public string PostCommand { get; set; } = null!;
        public bool Public { get; set; }
        public int UserId { get; set; }
        public bool Active { get; set; }
        public DateTime TimeStamp { get; set; }

        [ForeignKey("GeneratorId")]
        [InverseProperty("PortalGeneratorTemplateLists")]
        public virtual PortalGeneratorList Generator { get; set; } = null!;
        [ForeignKey("TemplateTypeId")]
        [InverseProperty("PortalGeneratorTemplateLists")]
        public virtual PortalTemplateTypeList TemplateType { get; set; } = null!;
    }
}
