using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("PortalUserPageList")]
    public partial class PortalUserPageList
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string UserPreffix { get; set; } = null!;
        [StringLength(100)]
        public string PageMenuType { get; set; } = null!;
        public int Sequence { get; set; }
        [StringLength(100)]
        public string Name { get; set; } = null!;
        public string PageCode { get; set; } = null!;
        public string? Description { get; set; }
        [Column("ReadmeMD")]
        public string? ReadmeMd { get; set; }
        [StringLength(450)]
        public string UserId { get; set; } = null!;
        public bool Public { get; set; }
        public bool Active { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
