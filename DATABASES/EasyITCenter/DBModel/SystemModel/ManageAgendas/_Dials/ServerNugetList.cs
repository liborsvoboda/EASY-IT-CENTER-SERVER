using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("ServerNugetList")]
    public partial class ServerNugetList
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string DataType { get; set; } = null!;
        [StringLength(100)]
        public string Name { get; set; } = null!;
        [StringLength(1024)]
        public string GithubUrl { get; set; } = null!;
        public string? Description { get; set; }
        [Column("ReadmeMD")]
        public string? ReadmeMd { get; set; }
        public int? Price { get; set; }
        [StringLength(450)]
        public string UserId { get; set; } = null!;
        public bool Active { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
