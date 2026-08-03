using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("PortalSettingList")]
    [Index("Key", Name = "IX_PortalSettingList", IsUnique = true)]
    public partial class PortalSettingList
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string InheritedDataType { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Key { get; set; } = null!;
        [Unicode(false)]
        public string Value { get; set; } = null!;
        public int SolutionUserListId { get; set; }
        public DateTime TimeStamp { get; set; }

        public virtual SolutionMixedEnumList InheritedDataTypeNavigation { get; set; } = null!;
        [ForeignKey("SolutionUserListId")]
        [InverseProperty("PortalSettingLists")]
        public virtual SolutionUserList SolutionUserList { get; set; } = null!;
    }
}
