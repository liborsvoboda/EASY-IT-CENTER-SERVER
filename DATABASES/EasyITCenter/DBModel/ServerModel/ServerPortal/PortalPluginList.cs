using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("PortalPluginList")]
    [Index("SystemName", Name = "IX_PortalPluginList", IsUnique = true)]
    public partial class PortalPluginList
    {
        [Key]
        public int Id { get; set; }
        public int ProjectId { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string UserPrefix { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string InheritedPluginType { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string InheritedCodeType { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string SystemName { get; set; } = null!;
        [Unicode(false)]
        public string? Description { get; set; }
        [Unicode(false)]
        public string? InitConfig { get; set; }
        [StringLength(1024)]
        [Unicode(false)]
        public string? CmdFilePath { get; set; }
        [Unicode(false)]
        public string? CodeTemplate { get; set; }
        [Unicode(false)]
        public string? Readme { get; set; }
        public bool IsMultiple { get; set; }
        public bool Public { get; set; }
        public bool Active { get; set; }
        public int UserId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Version { get; set; } = null!;
        public DateTime TimeStamp { get; set; }

        public virtual SolutionMixedEnumList InheritedCodeTypeNavigation { get; set; } = null!;
        public virtual SolutionMixedEnumList InheritedPluginTypeNavigation { get; set; } = null!;
        [ForeignKey("UserId")]
        [InverseProperty("PortalPluginListUsers")]
        public virtual SolutionUserList User { get; set; } = null!;
        public virtual SolutionUserList UserPrefixNavigation { get; set; } = null!;
    }
}
