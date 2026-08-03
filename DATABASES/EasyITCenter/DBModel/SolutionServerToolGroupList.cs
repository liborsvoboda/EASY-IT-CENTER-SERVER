using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("SolutionServerToolGroupList")]
    public partial class SolutionServerToolGroupList
    {
        public SolutionServerToolGroupList()
        {
            SolutionServerToolNameLists = new HashSet<SolutionServerToolNameList>();
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

        [InverseProperty("SystemGroupMenuListNameNavigation")]
        public virtual ICollection<SolutionServerToolNameList> SolutionServerToolNameLists { get; set; }
    }
}
