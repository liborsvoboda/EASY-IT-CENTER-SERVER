using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("ServerPathTypeList")]
    [Index("Name", Name = "IX_ServerPathTypeList", IsUnique = true)]
    public partial class ServerPathTypeList
    {
        public ServerPathTypeList()
        {
            ServerPathLists = new HashSet<ServerPathList>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string? CodeTemplate { get; set; }
        [StringLength(1024)]
        public string? Command { get; set; }
        public bool Public { get; set; }
        public bool Active { get; set; }
        [StringLength(450)]
        public string UserId { get; set; } = null!;
        public DateTime TimeStamp { get; set; }

        public virtual ICollection<ServerPathList> ServerPathLists { get; set; }
    }
}
