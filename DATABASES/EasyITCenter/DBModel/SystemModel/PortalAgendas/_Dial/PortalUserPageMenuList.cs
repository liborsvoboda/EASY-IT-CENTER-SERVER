using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("PortalUserPageMenuList")]
    public partial class PortalUserPageMenuList
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string UserPreffix { get; set; } = null!;
        [StringLength(100)]
        public string? PageMenuType { get; set; }
        public int Sequence { get; set; }
        [StringLength(100)]
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string? CodeTemplate { get; set; }
        public bool Public { get; set; }
        public bool Active { get; set; }
        [StringLength(450)]
        public string UserId { get; set; } = null!;
        public DateTime TimeStamp { get; set; }
    }
}
