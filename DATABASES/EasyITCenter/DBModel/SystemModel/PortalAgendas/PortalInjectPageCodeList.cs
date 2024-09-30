using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("PortalInjectPageCodeList")]
    [Index("UserPreffix", "Name", Name = "IX_PortalInjectMarkList")]
    public partial class PortalInjectPageCodeList
    {
        [Key]
        public int Id { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string UserPreffix { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Name { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string InheritedCodeType { get; set; } = null!;
        public int InjectGroupId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string PageName { get; set; } = null!;
        [Unicode(false)]
        public string? Description { get; set; }
        [Unicode(false)]
        public string? TemplateHtml { get; set; }
        [StringLength(50)]
        public string ElementAppender { get; set; } = null!;
        [Unicode(false)]
        public string CodeContent { get; set; } = null!;
        public bool Public { get; set; }
        public bool Active { get; set; }
        public int UserId { get; set; }
        public DateTime TimeStamp { get; set; }

        [ForeignKey("InjectGroupId")]
        [InverseProperty("PortalInjectPageCodeLists")]
        public virtual PortalInjectGroupList InjectGroup { get; set; } = null!;
        [ForeignKey("UserId")]
        [InverseProperty("PortalInjectPageCodeLists")]
        public virtual SolutionUserList User { get; set; } = null!;
    }
}
