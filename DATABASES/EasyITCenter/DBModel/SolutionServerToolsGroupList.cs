using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("SolutionServerToolsGroupList")]
    public partial class SolutionServerToolsGroupList
    {
        public SolutionServerToolsGroupList()
        {
            SolutionServerToolsNameLists = new HashSet<SolutionServerToolsNameList>();
        }

        public int Id { get; set; }
        [Key]
        [StringLength(50)]
        [Unicode(false)]
        public string GroupName { get; set; } = null!;
        [Unicode(false)]
        public string? Description { get; set; }
        public int UserId { get; set; }
        public DateTime TimeStamp { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("SolutionServerToolsGroupLists")]
        public virtual SolutionUserList User { get; set; } = null!;
        [InverseProperty("SystemGroupMenuListNameNavigation")]
        public virtual ICollection<SolutionServerToolsNameList> SolutionServerToolsNameLists { get; set; }
    }
}
