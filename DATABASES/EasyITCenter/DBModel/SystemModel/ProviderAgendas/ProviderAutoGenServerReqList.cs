using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("ProviderAutoGenServerReqList")]
    [Index("Name", Name = "IX_ProviderAutoGenServerCreateRequest", IsUnique = true)]
    public partial class ProviderAutoGenServerReqList
    {
        [Key]
        public int Id { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string IpAddress { get; set; } = null!;
        [StringLength(100)]
        [Unicode(false)]
        public string Name { get; set; } = null!;
        [Unicode(false)]
        public string? Description { get; set; }
        public int? UserId { get; set; }
        public DateTime TimeStamp { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("ProviderAutoGenServerReqLists")]
        public virtual SolutionUserList? User { get; set; }
    }
}
