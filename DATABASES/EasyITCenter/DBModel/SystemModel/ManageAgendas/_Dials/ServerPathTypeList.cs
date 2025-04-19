using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyITCenter.DBModel
{
    [Table("ServerPathTypeList")]
    [Index("Name", Name = "IX_ServerPathTypeList", IsUnique = true)]
    public partial class ServerPathTypeList
    {
        public ServerPathTypeList()
        {
            //ServerSharedUrlLists = new HashSet<ServerSharedUrlList>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string Name { get; set; } = null!;
        [Unicode(false)]
        public string? Description { get; set; }
        [Unicode(false)]
        public string? CodeTemplate { get; set; }
        [Unicode(false)]
        public string? Command { get; set; }
        public bool Public { get; set; }
        public bool Active { get; set; }
        public int UserId { get; set; }
        public DateTime TimeStamp { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("ServerPathTypeLists")]
        public virtual SolutionUserList User { get; set; } = null!;
        //public virtual ICollection<ServerSharedUrlList> ServerSharedUrlLists { get; set; }
    }
}
