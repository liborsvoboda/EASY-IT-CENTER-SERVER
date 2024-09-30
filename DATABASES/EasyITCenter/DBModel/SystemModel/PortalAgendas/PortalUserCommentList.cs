using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("PortalUserCommentList")]
    [Index("TableName", "RecId", "UserId", Name = "IX_PortalUserCommentList")]
    [Index("TableName", Name = "IX_PortalUserCommentList_1")]
    [Index("TableName", "RecId", Name = "IX_PortalUserCommentList_2")]
    public partial class PortalUserCommentList
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string TableName { get; set; } = null!;
        public int RecId { get; set; }
        [Unicode(false)]
        public string Content { get; set; } = null!;
        public bool Public { get; set; }
        public int UserId { get; set; }
        public bool Active { get; set; }
        public DateTime TimeStamp { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("PortalUserCommentLists")]
        public virtual SolutionUserList User { get; set; } = null!;
    }
}
