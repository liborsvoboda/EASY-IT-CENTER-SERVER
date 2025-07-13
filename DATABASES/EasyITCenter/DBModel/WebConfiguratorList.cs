using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("WebConfiguratorList")]
    [Index("Name", Name = "IX_WebConfiguratorList", IsUnique = true)]
    [Index("ServerUrl", Name = "IX_WebConfiguratorList_1", IsUnique = true)]
    public partial class WebConfiguratorList
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Name { get; set; } = null!;
        public bool IsStartupPage { get; set; }
        [Unicode(false)]
        public string? Description { get; set; }
        [Unicode(false)]
        public string? HtmlContent { get; set; }
        [StringLength(500)]
        [Unicode(false)]
        public string? ServerUrl { get; set; }
        [StringLength(200)]
        [Unicode(false)]
        public string? AuthRole { get; set; }
        public bool AuthIgnore { get; set; }
        public bool AuthRedirect { get; set; }
        [StringLength(500)]
        [Unicode(false)]
        public string? AuthRedirectUrl { get; set; }
        [StringLength(500)]
        [Unicode(false)]
        public string? IncludedIdList { get; set; }
        public bool Active { get; set; }
        public int UserId { get; set; }
        public DateTime TimeStamp { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("WebConfiguratorLists")]
        public virtual SolutionUserList User { get; set; } = null!;
    }
}
