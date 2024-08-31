using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("SolutionToolGroupList")]
    [Index("Name", Name = "IX_SolutionToolGroupList", IsUnique = true)]
    public partial class SolutionToolGroupList
    {
        public SolutionToolGroupList()
        {
            InverseSolutionToolGroup = new HashSet<SolutionToolGroupList>();
        }

        [Key]
        public int Id { get; set; }
        public int? SolutionToolGroupId { get; set; }
        public int? Sequence { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Name { get; set; } = null!;
        [Unicode(false)]
        public string? Description { get; set; }
        public int UserId { get; set; }
        public bool Default { get; set; }
        public bool Active { get; set; }
        public DateTime TimeStamp { get; set; }

        [ForeignKey("SolutionToolGroupId")]
        [InverseProperty("InverseSolutionToolGroup")]
        public virtual SolutionToolGroupList? SolutionToolGroup { get; set; }
        [ForeignKey("UserId")]
        [InverseProperty("SolutionToolGroupLists")]
        public virtual SolutionUserList User { get; set; } = null!;
        [InverseProperty("SolutionToolGroup")]
        public virtual ICollection<SolutionToolGroupList> InverseSolutionToolGroup { get; set; }
    }
}
