using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("DeveloperToolGroupList")]
    [Index("Name", Name = "IX_DeveloperToolGroupList", IsUnique = true)]
    public partial class DeveloperToolGroupList
    {
        public DeveloperToolGroupList()
        {
            InverseDeveloperToolGroup = new HashSet<DeveloperToolGroupList>();
        }

        [Key]
        public int Id { get; set; }
        public int? DeveloperToolGroupId { get; set; }
        public int? Sequence { get; set; }
        [StringLength(10)]
        public string? ReadmeUrl { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Name { get; set; } = null!;
        [Unicode(false)]
        public string? Description { get; set; }
        public int UserId { get; set; }
        public bool Default { get; set; }
        public bool Active { get; set; }
        public DateTime TimeStamp { get; set; }
        [StringLength(1024)]
        [Unicode(false)]
        public string? ActionLink { get; set; }
        [StringLength(1024)]
        [Unicode(false)]
        public string? ActionServer { get; set; }

        [ForeignKey("DeveloperToolGroupId")]
        [InverseProperty("InverseDeveloperToolGroup")]
        public virtual DeveloperToolGroupList? DeveloperToolGroup { get; set; }
        [ForeignKey("UserId")]
        [InverseProperty("DeveloperToolGroupLists")]
        public virtual SolutionUserList User { get; set; } = null!;
        [InverseProperty("DeveloperToolGroup")]
        public virtual ICollection<DeveloperToolGroupList> InverseDeveloperToolGroup { get; set; }
    }
}
