using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("ServerProcessList")]
    public partial class ServerProcessList
    {
        [Key]
        public int Id { get; set; }
        [StringLength(20)]
        public string? UserPreffix { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string InheritedProcessType { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string InheritedCommandType { get; set; } = null!;
        [StringLength(250)]
        [Unicode(false)]
        public string Name { get; set; } = null!;
        [Unicode(false)]
        public string? CodeTemplate { get; set; }
        [Unicode(false)]
        public string Command { get; set; } = null!;
        [Unicode(false)]
        public string? Description { get; set; }
        [Column("RunOnAStartUp")]
        public bool RunOnAstartUp { get; set; }
        public bool Public { get; set; }
        public bool Active { get; set; }
        public int UserId { get; set; }
        public DateTime TimeStamp { get; set; }

        public virtual SolutionMixedEnumList InheritedCommandTypeNavigation { get; set; } = null!;
        public virtual SolutionMixedEnumList InheritedProcessTypeNavigation { get; set; } = null!;
        [ForeignKey("UserId")]
        [InverseProperty("ServerProcessLists")]
        public virtual SolutionUserList User { get; set; } = null!;
    }
}
