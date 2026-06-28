using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("BasicAttachmentList")]
    [Index("ParentId", "TableName", Name = "IX_AttachmentList")]
    [Index("TableName", Name = "IX_BasicAttachmentList")]
    [Index("ParentId", "FileName", "Version", Name = "UX_AttachmentList", IsUnique = true)]
    public partial class BasicAttachmentList
    {
        [Key]
        public int Id { get; set; }
        public int ParentId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string TableName { get; set; } = null!;
        [StringLength(512)]
        [Unicode(false)]
        public string FileName { get; set; } = null!;
        public byte[] Attachment { get; set; } = null!;
        public int UserId { get; set; }
        public int Version { get; set; }
        public DateTime TimeStamp { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("BasicAttachmentLists")]
        public virtual SolutionUserList User { get; set; } = null!;
    }
}
