using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("PortalApiTableColumnDataList")]
    [Index("RecGuid", Name = "IX_PortalApiTableColumnDataList")]
    public partial class PortalApiTableColumnDataList
    {
        [Key]
        public int Id { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? UserPrefix { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string ApiTableName { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string ApiTableColumnName { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string RecGuid { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string InheritedDataType { get; set; } = null!;
        [Unicode(false)]
        public string? Value { get; set; }
        [Unicode(false)]
        public string? Description { get; set; }
        public bool Public { get; set; }
        [Required]
        public bool Active { get; set; }
        public int UserId { get; set; }
        public DateTime TimeStamp { get; set; }

        public virtual PortalApiTableList ApiTableNameNavigation { get; set; } = null!;
        public virtual SolutionMixedEnumList InheritedDataTypeNavigation { get; set; } = null!;
        public virtual PortalApiTableColumnList? PortalApiTableColumnList { get; set; }
        [ForeignKey("UserId")]
        [InverseProperty("PortalApiTableColumnDataListUsers")]
        public virtual SolutionUserList User { get; set; } = null!;
        public virtual SolutionUserList? UserPrefixNavigation { get; set; }
    }
}
