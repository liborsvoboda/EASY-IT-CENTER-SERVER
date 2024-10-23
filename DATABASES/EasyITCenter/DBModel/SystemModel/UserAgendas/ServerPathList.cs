using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("ServerPathList")]
    public partial class ServerPathList
    {
        [Key]
        public int Id { get; set; }
        [StringLength(256)]
        public string RoleDownload { get; set; } = null!;
        [StringLength(256)]
        public string RoleReadAccess { get; set; } = null!;
        [StringLength(100)]
        [Unicode(false)]
        public string PathType { get; set; } = null!;
        [StringLength(100)]
        public string Name { get; set; } = null!;
        [StringLength(1024)]
        public string Path { get; set; } = null!;
        public string? Description { get; set; }
        public string? CodeTemplate { get; set; }
        [StringLength(4000)]
        public string? Command { get; set; }
        public string? MdContent { get; set; }
        [Column(TypeName = "numeric(10, 2)")]
        public decimal? Price { get; set; }
        public int Public { get; set; }
        [StringLength(450)]
        public string UserId { get; set; } = null!;
        public bool Active { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
