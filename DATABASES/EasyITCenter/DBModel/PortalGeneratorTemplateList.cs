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
        public string? UserPrefix { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string InheritedTemplateType { get; set; } = null!;
        public int GeneratorId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Name { get; set; } = null!;
        [Unicode(false)]
        public string? Description { get; set; }
        [Unicode(false)]
        public string? CodeContent { get; set; }
        [Column("ReadmeMDContent")]
        [Unicode(false)]
        public string? ReadmeMdcontent { get; set; }
        [StringLength(1024)]
        [Unicode(false)]
        public string? SourceUrl { get; set; }
        [StringLength(1024)]
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
        public virtual SolutionMixedEnumList InheritedCommandTypeNavigation { get; set; } = null!;
        public virtual SolutionMixedEnumList InheritedTemplateTypeNavigation { get; set; } = null!;
        [ForeignKey("UserId")]
        [InverseProperty("PortalGeneratorTemplateListUsers")]
        public virtual SolutionUserList User { get; set; } = null!;
        public virtual SolutionUserList? UserPrefixNavigation { get; set; }
    }
}
