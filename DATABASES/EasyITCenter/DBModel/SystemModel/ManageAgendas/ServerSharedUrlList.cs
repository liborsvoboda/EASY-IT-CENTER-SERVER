using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("ServerSharedUrlList")]
    public partial class ServerSharedUrlList
    {
        [Key]
        public int Id { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string UserPrefix { get; set; } = null!;
        [StringLength(100)]
        [Unicode(false)]
        public string ServerPathType { get; set; } = null!;
        [StringLength(512)]
        [Unicode(false)]
        public string SourcePath { get; set; } = null!;
        [StringLength(512)]
        [Unicode(false)]
        public string SharedUrl { get; set; } = null!;
        [StringLength(150)]
        [Unicode(false)]
        public string Title { get; set; } = null!;
        [Unicode(false)]
        public string? Description { get; set; }
        [Column(TypeName = "numeric(10, 2)")]
        public decimal? Price { get; set; }
        public int RankCount { get; set; }
        public int Rank { get; set; }
        public int UserId { get; set; }
        public bool Active { get; set; }
        public DateTime TimeStamp { get; set; }

        public virtual ServerPathTypeList ServerPathTypeNavigation { get; set; } = null!;
        [ForeignKey("UserId")]
        [InverseProperty("ServerSharedUrlLists")]
        public virtual SolutionUserList User { get; set; } = null!;
    }
}
