using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("ServerSettingList")]
    [Index("Key", Name = "IX_ServerSettingList", IsUnique = true)]
    public partial class ServerSettingList
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string InheritedSrvConfigType { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Type { get; set; } = null!;
        [StringLength(150)]
        [Unicode(false)]
        public string Key { get; set; } = null!;
        [StringLength(150)]
        [Unicode(false)]
        public string Value { get; set; } = null!;
        [Unicode(false)]
        public string? Description { get; set; }
        [StringLength(1024)]
        [Unicode(false)]
        public string? Link { get; set; }
        public int UserId { get; set; }
        public bool Active { get; set; }
        public DateTime TimeStamp { get; set; }

        public virtual SolutionMixedEnumList InheritedSrvConfigTypeNavigation { get; set; } = null!;
        [ForeignKey("UserId")]
        [InverseProperty("ServerSettingLists")]
        public virtual SolutionUserList User { get; set; } = null!;
    }
}
