using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("PortalGeneratorList")]
    [Index("UserPrefix", "GeneratorType", "Name", Name = "IX_PortalGeneratorList", IsUnique = true)]
    [Index("GeneratorType", "Name", Name = "IX_PortalGeneratorList_1")]
    public partial class PortalGeneratorList
    {
        public PortalGeneratorList()
        {
            PortalGeneratorActionLists = new HashSet<PortalGeneratorActionList>();
            PortalGeneratorTemplateLists = new HashSet<PortalGeneratorTemplateList>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string UserPrefix { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string GeneratorType { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Name { get; set; } = null!;
        [Unicode(false)]
        public string? Description { get; set; }
        [Unicode(false)]
        public string? CodeTemplate { get; set; }
        [Unicode(false)]
        public string? Readme { get; set; }
        public bool Public { get; set; }
        [Unicode(false)]
        public string? Script { get; set; }
        [Unicode(false)]
        public string? Command { get; set; }
        public int UserId { get; set; }
        public bool Active { get; set; }
        public DateTime TimeStamp { get; set; }

        public virtual PortalGeneratorTypeList PortalGeneratorTypeList { get; set; } = null!;
        [ForeignKey("UserId")]
        [InverseProperty("PortalGeneratorLists")]
        public virtual SolutionUserList User { get; set; } = null!;
        [InverseProperty("Generator")]
        public virtual ICollection<PortalGeneratorActionList> PortalGeneratorActionLists { get; set; }
        [InverseProperty("Generator")]
        public virtual ICollection<PortalGeneratorTemplateList> PortalGeneratorTemplateLists { get; set; }
    }
}
