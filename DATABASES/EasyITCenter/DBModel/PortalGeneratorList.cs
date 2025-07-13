using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("PortalGeneratorList")]
    [Index("UserPrefix", "InheritedGeneratorType", "Name", Name = "IX_PortalGeneratorList", IsUnique = true)]
    [Index("InheritedGeneratorType", "Name", Name = "IX_PortalGeneratorList_1")]
    public partial class PortalGeneratorList
    {
        public PortalGeneratorList()
        {
            PortalGeneratedDataLists = new HashSet<PortalGeneratedDataList>();
            PortalGeneratorActionLists = new HashSet<PortalGeneratorActionList>();
            PortalGeneratorTemplateLists = new HashSet<PortalGeneratorTemplateList>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? UserPrefix { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string InheritedGeneratorType { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Name { get; set; } = null!;
        [Unicode(false)]
        public string? Description { get; set; }
        [Unicode(false)]
        public string? CodeContent { get; set; }
        [Unicode(false)]
        public string? ReadmeMdContent { get; set; }
        [Unicode(false)]
        public string? ScriptContent { get; set; }
        [Unicode(false)]
        public string? Command { get; set; }
        public bool Public { get; set; }
        public int UserId { get; set; }
        public bool Active { get; set; }
        public DateTime TimeStamp { get; set; }

        public virtual SolutionMixedEnumList InheritedGeneratorTypeNavigation { get; set; } = null!;
        [ForeignKey("UserId")]
        [InverseProperty("PortalGeneratorListUsers")]
        public virtual SolutionUserList User { get; set; } = null!;
        public virtual SolutionUserList? UserPrefixNavigation { get; set; }
        [InverseProperty("Generator")]
        public virtual ICollection<PortalGeneratedDataList> PortalGeneratedDataLists { get; set; }
        [InverseProperty("Generator")]
        public virtual ICollection<PortalGeneratorActionList> PortalGeneratorActionLists { get; set; }
        [InverseProperty("Generator")]
        public virtual ICollection<PortalGeneratorTemplateList> PortalGeneratorTemplateLists { get; set; }
    }
}
