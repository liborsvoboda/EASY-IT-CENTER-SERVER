using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("GithubSrvSshKeyList")]
    [Index("UserId", Name = "IX_GithubSrvSshKeyList_UserId")]
    public partial class GithubSrvSshKeyList
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public string? KeyType { get; set; }
        public string? Fingerprint { get; set; }
        public string? PublicKey { get; set; }
        public DateTime ImportData { get; set; }
        public DateTime LastUse { get; set; }
        public DateTime TimeStamp { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("GithubSrvSshKeyLists")]
        public virtual SolutionUserList User { get; set; } = null!;
    }
}
