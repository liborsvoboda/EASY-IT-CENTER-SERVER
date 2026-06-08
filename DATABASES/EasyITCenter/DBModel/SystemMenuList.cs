using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("SystemMenuList")]
    [Index("FormPageName", Name = "IX_GlobalMenuList", IsUnique = true)]
    public partial class SystemMenuList
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string InheritedSystemMenuType { get; set; } = null!;
        public int SystemGroupMenuListId { get; set; }
        [StringLength(250)]
        [Unicode(false)]
        public string FormPageName { get; set; } = null!;
        [StringLength(1024)]
        [Unicode(false)]
        public string AccessRole { get; set; } = null!;
        [StringLength(2048)]
        [Unicode(false)]
        public string? AccessUser { get; set; }
        [StringLength(150)]
        [Unicode(false)]
        public string? OrderBy { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string InheritedQueryLimitType { get; set; } = null!;
        [Unicode(false)]
        public string? Description { get; set; }
        public int SolutionUserListId { get; set; }
        public bool NotShowInMenu { get; set; }
        [Required]
        public bool Active { get; set; }
        public DateTime TimeStamp { get; set; }

        public virtual SolutionMixedEnumList InheritedQueryLimitTypeNavigation { get; set; } = null!;
        public virtual SolutionMixedEnumList InheritedSystemMenuTypeNavigation { get; set; } = null!;
        [ForeignKey("SolutionUserListId")]
        [InverseProperty("SystemMenuLists")]
        public virtual SolutionUserList SolutionUserList { get; set; } = null!;
        [ForeignKey("SystemGroupMenuListId")]
        [InverseProperty("SystemMenuLists")]
        public virtual SystemGroupMenuList SystemGroupMenuList { get; set; } = null!;
    }
}
