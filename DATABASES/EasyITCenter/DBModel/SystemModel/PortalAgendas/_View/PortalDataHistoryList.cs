using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("PortalDataHistoryList")]
    public partial class PortalDataHistoryList
    {
        [Key]
        public int Id { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string UserDbPreffix { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string TableName { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string DataType { get; set; } = null!;
        public string Value { get; set; } = null!;
        public bool Public { get; set; }
        public int UserId { get; set; }
        public DateTime TimeStamp { get; set; }

        public virtual PortalDataTypeList DataTypeNavigation { get; set; } = null!;
        public virtual PortalApiTableList PortalApiTableList { get; set; } = null!;
        [ForeignKey("UserId")]
        [InverseProperty("PortalDataHistoryLists")]
        public virtual SolutionUserList User { get; set; } = null!;
    }
}
