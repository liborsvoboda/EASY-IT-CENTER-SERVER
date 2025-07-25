﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("SystemModuleList")]
    [Index("Name", Name = "IX_SystemModuleList", IsUnique = true)]
    public partial class SystemModuleList
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string InheritedModuleType { get; set; } = null!;
        [StringLength(255)]
        [Unicode(false)]
        public string Name { get; set; } = null!;
        [StringLength(255)]
        [Unicode(false)]
        public string? FolderPath { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? FileName { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? StartupCommand { get; set; }
        [Unicode(false)]
        public string? Description { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string ForegroundColor { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string BackgroundColor { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string IconName { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string IconColor { get; set; } = null!;
        public int UserId { get; set; }
        public DateTime TimeStamp { get; set; }

        public virtual SolutionMixedEnumList InheritedModuleTypeNavigation { get; set; } = null!;
        [ForeignKey("UserId")]
        [InverseProperty("SystemModuleLists")]
        public virtual SolutionUserList User { get; set; } = null!;
    }
}
