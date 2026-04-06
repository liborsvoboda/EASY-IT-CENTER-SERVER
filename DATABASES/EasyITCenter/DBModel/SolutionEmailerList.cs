using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("SolutionEmailerList")]
    public partial class SolutionEmailerList
    {
        [Key]
        public int Id { get; set; }
        [StringLength(150)]
        [Unicode(false)]
        public string EmailFolder { get; set; } = null!;
        [StringLength(150)]
        [Unicode(false)]
        public string Folder { get; set; }
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
        public DateTime TimeStamp { get; set; }
    }
}
