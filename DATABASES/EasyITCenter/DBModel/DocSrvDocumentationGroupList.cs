using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("DocSrvDocumentationGroupList")]
    [Index("Name", Name = "IX_DocumentationGroupList", IsUnique = true)]
    public partial class DocSrvDocumentationGroupList
    {
        public DocSrvDocumentationGroupList()
        {
            DocSrvDocTemplateLists = new HashSet<DocSrvDocTemplateList>();
        }

        [Key]
        [StringLength(50)]
        [Unicode(false)]
        public string Id { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Name { get; set; } = null!;
        public int Sequence { get; set; }
        [Unicode(false)]
        public string? Description { get; set; }
        public int UserId { get; set; }
        [Required]
        public bool Active { get; set; }
        public DateTime TimeStamp { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("DocSrvDocumentationGroupLists")]
        public virtual SolutionUserList User { get; set; } = null!;
        [InverseProperty("Group")]
        public virtual ICollection<DocSrvDocTemplateList> DocSrvDocTemplateLists { get; set; }
    }
}
