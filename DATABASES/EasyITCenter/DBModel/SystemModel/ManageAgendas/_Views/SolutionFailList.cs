﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("SolutionFailList")]
    public partial class SolutionFailList
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string InheritedLogMonitorType { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string? UserName { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? LogLevel { get; set; }
        [Unicode(false)]
        public string Message { get; set; } = null!;
        [StringLength(150)]
        [Unicode(false)]
        public string? ImageName { get; set; }
        public byte[]? Image { get; set; }
        [StringLength(150)]
        [Unicode(false)]
        public string? AttachmentName { get; set; }
        public byte[]? Attachment { get; set; }
        public int? UserId { get; set; }
        public DateTime TimeStamp { get; set; }

        public virtual SolutionMixedEnumList InheritedLogMonitorTypeNavigation { get; set; } = null!;
        [ForeignKey("UserId")]
        [InverseProperty("SolutionFailLists")]
        public virtual SolutionUserList? User { get; set; }
    }
}
