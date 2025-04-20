using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("PortalTemplateTypeList")]
    [Index("Name", Name = "IX_PortalTemplateTypeList", IsUnique = true)]
    public partial class PortalTemplateTypeList
    {
        public PortalTemplateTypeList()
        {
            PortalGeneratorActionLists = new HashSet<PortalGeneratorActionList>();
            PortalGeneratorTemplateLists = new HashSet<PortalGeneratorTemplateList>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Name { get; set; } = null!;
        [Unicode(false)]
        public string? Description { get; set; }
        [Unicode(false)]
        public string? CodeTemplate { get; set; }
        public bool Public { get; set; }
        public bool Active { get; set; }
        public int UserId { get; set; }
        public DateTime TimeStamp { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("PortalTemplateTypeLists")]
        public virtual SolutionUserList User { get; set; } = null!;
        [InverseProperty("TemplateType")]
        public virtual ICollection<PortalGeneratorActionList> PortalGeneratorActionLists { get; set; }
        [InverseProperty("TemplateType")]
        public virtual ICollection<PortalGeneratorTemplateList> PortalGeneratorTemplateLists { get; set; }
    }
}
