using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("ServerProcessList")]
    public partial class ServerProcessList
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string InheritedProcessType { get; set; } = null!;
        [StringLength(250)]
        [Unicode(false)]
        public string Name { get; set; } = null!;
        [Unicode(false)]
        public string ProcessScript { get; set; } = null!;
        [Unicode(false)]
        public string Description { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string InheritedStatusType { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string InheritedFailedActionType { get; set; } = null!;
        public bool Active { get; set; }
        public int UserId { get; set; }
        public DateTime TimeStamp { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("ServerProcessLists")]
        public virtual SolutionUserList User { get; set; } = null!;
    }
}
