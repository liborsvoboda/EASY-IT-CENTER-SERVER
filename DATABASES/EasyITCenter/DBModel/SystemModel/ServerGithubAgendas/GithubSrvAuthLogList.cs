using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("GithubSrvAuthLogList")]
    [Index("UserId", Name = "IX_GithubSrvAuthLogList_UserId")]
    public partial class GithubSrvAuthLogList
    {
        [Key]
        public int Id { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime Expires { get; set; }
        public string? IssueIp { get; set; }
        public string? LastIp { get; set; }
        public bool IsValid { get; set; }
        public int UserId { get; set; }
        public DateTime TimeStamp { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("GithubSrvAuthLogLists")]
        public virtual SolutionUserList User { get; set; } = null!;
    }
}
