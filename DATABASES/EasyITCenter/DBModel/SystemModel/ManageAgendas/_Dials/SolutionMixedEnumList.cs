using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("SolutionMixedEnumList")]
    [Index("ItemsGroup", "Name", Name = "IX_GlobalMixedEnumList", IsUnique = true)]
    [Index("ItemsGroup", Name = "IX_SolutionMixedEnumList")]
    [Index("Name", Name = "IX_SolutionMixedEnumList_1", IsUnique = true)]
    public partial class SolutionMixedEnumList
    {
        public SolutionMixedEnumList()
        {
            PortalGeneratorActionLists = new HashSet<PortalGeneratorActionList>();
            ServerProcessListInheritedCommandTypeNavigations = new HashSet<ServerProcessList>();
            ServerProcessListInheritedProcessTypeNavigations = new HashSet<ServerProcessList>();
            ServerSettingLists = new HashSet<ServerSettingList>();
            ServerToolPanelDefinitionLists = new HashSet<ServerToolPanelDefinitionList>();
            SolutionFailLists = new HashSet<SolutionFailList>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string ItemsGroup { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Name { get; set; } = null!;
        [Unicode(false)]
        public string? Description { get; set; }
        public int UserId { get; set; }
        public bool Active { get; set; }
        public DateTime TimeStamp { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("SolutionMixedEnumLists")]
        public virtual SolutionUserList User { get; set; } = null!;
        public virtual ICollection<PortalGeneratorActionList> PortalGeneratorActionLists { get; set; }
        public virtual ICollection<ServerProcessList> ServerProcessListInheritedCommandTypeNavigations { get; set; }
        public virtual ICollection<ServerProcessList> ServerProcessListInheritedProcessTypeNavigations { get; set; }
        public virtual ICollection<ServerSettingList> ServerSettingLists { get; set; }
        public virtual ICollection<ServerToolPanelDefinitionList> ServerToolPanelDefinitionLists { get; set; }
        public virtual ICollection<SolutionFailList> SolutionFailLists { get; set; }
    }
}
