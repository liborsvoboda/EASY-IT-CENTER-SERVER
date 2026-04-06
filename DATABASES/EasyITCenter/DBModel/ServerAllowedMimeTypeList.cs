using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("ServerAllowedMimeTypeList")]
    [Index("FileExtension", Name = "IX_ServerAllowedMimeTypeList")]
    public partial class ServerAllowedMimeTypeList
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string FileExtension { get; set; } = null!;
        [StringLength(150)]
        [Unicode(false)]
        public string MimeType { get; set; } = null!;
        [Unicode(false)]
        public string? Description { get; set; }
        public bool Active { get; set; }
        public int UserId { get; set; }
        public DateTime TimeStamp { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("ServerAllowedMimeTypeLists")]
        public virtual SolutionUserList User { get; set; } = null!;
    }
}
