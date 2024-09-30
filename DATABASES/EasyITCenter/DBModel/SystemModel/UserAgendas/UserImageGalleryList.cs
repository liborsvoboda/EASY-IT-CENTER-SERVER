using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("UserImageGalleryList")]
    [Index("FileName", Name = "UX_UserImageGalleryList", IsUnique = true)]
    public partial class UserImageGalleryList
    {
        [Key]
        public int Id { get; set; }
        public bool IsPrimary { get; set; }
        [StringLength(150)]
        [Unicode(false)]
        public string FileName { get; set; } = null!;
        public byte[] Attachment { get; set; } = null!;
        public int UserId { get; set; }
        public DateTime TimeStamp { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("UserImageGalleryLists")]
        public virtual SolutionUserList User { get; set; } = null!;
    }
}
