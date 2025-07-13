﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("BusinessWarehouseList")]
    [Index("Name", Name = "IX_WarehouseList", IsUnique = true)]
    public partial class BusinessWarehouseList
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Name { get; set; } = null!;
        [Unicode(false)]
        public string? Description { get; set; }
        public int UserId { get; set; }
        public bool AllowNegativeStatus { get; set; }
        public bool Default { get; set; }
        public bool LockedByStockTaking { get; set; }
        public DateTime LastStockTaking { get; set; }
        public bool Active { get; set; }
        public DateTime TimeStamp { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("BusinessWarehouseLists")]
        public virtual SolutionUserList User { get; set; } = null!;
    }
}
