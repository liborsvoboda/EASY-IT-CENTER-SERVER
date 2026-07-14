using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("ServerStorageVersionSettingSupportList")]
    [Index("Folder", "UserId", Name = "IX_ServerStorageVersionSettingList", IsUnique = true)]
    public partial class ServerStorageVersionSettingSupportList
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Folder { get; set; } = null!;
        public bool VersionEnabled { get; set; }
        public int UserId { get; set; }
        public DateTime TimeStamp { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("ServerStorageVersionSettingSupportLists")]
        public virtual SolutionUserList User { get; set; } = null!;
    }
}
