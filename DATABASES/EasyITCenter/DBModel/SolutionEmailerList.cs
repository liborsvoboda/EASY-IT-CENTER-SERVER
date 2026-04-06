using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("SolutionEmailerList")]
    [Index("EmailFolder", "UserId", Name = "IX_SolutionEmailerList")]
    [Index("EmailFolder", "Folder", "UserId", Name = "IX_SolutionEmailerList_1")]
    public partial class SolutionEmailerList
    {
        [Key]
        public int Id { get; set; }
        [StringLength(150)]
        [Unicode(false)]
        public string EmailFolder { get; set; } = null!;
        [StringLength(150)]
        [Unicode(false)]
        public string Folder { get; set; } = null!;
        [StringLength(2048)]
        [Unicode(false)]
        public string From { get; set; } = null!;
        [StringLength(2048)]
        [Unicode(false)]
        public string To { get; set; } = null!;
        [StringLength(2048)]
        [Unicode(false)]
        public string? ToCopy { get; set; }
        [StringLength(2048)]
        [Unicode(false)]
        public string? ToHidden { get; set; }
        [StringLength(2048)]
        [Unicode(false)]
        public string Subject { get; set; } = null!;
        [Unicode(false)]
        public string HtmlMessage { get; set; } = null!;
        public bool Shown { get; set; }
        public int UserId { get; set; }
        public DateTime TimeStamp { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("SolutionEmailerLists")]
        public virtual SolutionUserList User { get; set; } = null!;
    }
}
