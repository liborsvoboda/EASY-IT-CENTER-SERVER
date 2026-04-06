using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("SolutionShareSourceList")]
    [Index("InheritedShareSourceType", Name = "IX_SolutionShareSourceList")]
    [Index("UserId", Name = "IX_SolutionShareSourceList_1")]
    public partial class SolutionShareSourceList
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string InheritedShareSourceType { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string? RecGuid { get; set; }
        [StringLength(2048)]
        [Unicode(false)]
        public string? Url { get; set; }
        [StringLength(2048)]
        [Unicode(false)]
        public string AccessUser { get; set; } = null!;
        public bool Public { get; set; }
        public int UserId { get; set; }
        public DateTime TimeStamp { get; set; }

        public virtual SolutionMixedEnumList InheritedShareSourceTypeNavigation { get; set; } = null!;
        [ForeignKey("UserId")]
        [InverseProperty("SolutionShareSourceLists")]
        public virtual SolutionUserList User { get; set; } = null!;
    }
}
