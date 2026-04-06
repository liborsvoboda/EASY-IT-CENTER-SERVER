using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("ServerStorageVersionFileSupportList")]
    [Index("Folder", "UserId", Name = "IX_ServerStorageVersionFileList")]
    [Index("Path", "Version", "UserId", Name = "IX_ServerStorageVersionList", IsUnique = true)]
    [Index("Path", Name = "IX_ServerStorageVersionList_1")]
    public partial class ServerStorageVersionFileSupportList
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Folder { get; set; } = null!;
        [StringLength(800)]
        [Unicode(false)]
        public string Path { get; set; } = null!;
        [Unicode(false)]
        public string File { get; set; } = null!;
        public int Version { get; set; }
        public int UserId { get; set; }
        public DateTime TimeStamp { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("ServerStorageVersionFileSupportLists")]
        public virtual SolutionUserList User { get; set; } = null!;
    }
}
