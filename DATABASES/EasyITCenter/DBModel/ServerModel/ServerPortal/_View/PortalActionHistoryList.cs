using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("PortalActionHistoryList")]
    public partial class PortalActionHistoryList
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string ActionType { get; set; } = null!;
        [StringLength(100)]
        public string? DataType { get; set; }
        public string Value { get; set; } = null!;
        public int UserId { get; set; }
        public DateTime TimeStamp { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("PortalActionHistoryLists")]
        public virtual SolutionUserList User { get; set; } = null!;
    }
}
