using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("PortalHelpDataList")]
    [Index("UserPrefix", "HelpGroupType", "Name", Name = "IX_PortalHelpDataList")]
    [Index("DataType", Name = "IX_PortalHelpDataList_1")]
    [Index("HelpGroupType", Name = "IX_PortalHelpDataList_2")]
    public partial class PortalHelpDataList
    {
        [Key]
        public int Id { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string UserPrefix { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string DataType { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string HelpGroupType { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Name { get; set; } = null!;
        [Unicode(false)]
        public string? Readme { get; set; }
        public string? Description { get; set; }
        [StringLength(4000)]
        public string? GithubUrl { get; set; }
        [StringLength(4000)]
        public string? WebPageUrl { get; set; }
        public bool Public { get; set; }
        public int UserId { get; set; }
        public bool Active { get; set; }
        public DateTime TimeStamp { get; set; }

        public virtual PortalHelpGroupList PortalHelpGroupList { get; set; } = null!;
        [ForeignKey("UserId")]
        [InverseProperty("PortalHelpDataLists")]
        public virtual SolutionUserList User { get; set; } = null!;
    }
}
