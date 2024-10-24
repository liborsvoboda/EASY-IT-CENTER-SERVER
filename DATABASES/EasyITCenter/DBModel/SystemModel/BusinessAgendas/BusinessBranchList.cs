﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("BusinessBranchList")]
    [Index("CompanyName", Name = "IX_BranchList", IsUnique = true)]
    public partial class BusinessBranchList
    {
        public BusinessBranchList()
        {
            SystemDocumentAdviceLists = new HashSet<SystemDocumentAdviceList>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(150)]
        [Unicode(false)]
        public string CompanyName { get; set; } = null!;
        [StringLength(150)]
        [Unicode(false)]
        public string? ContactName { get; set; }
        [StringLength(150)]
        [Unicode(false)]
        public string Street { get; set; } = null!;
        [StringLength(150)]
        [Unicode(false)]
        public string City { get; set; } = null!;
        [StringLength(20)]
        [Unicode(false)]
        public string PostCode { get; set; } = null!;
        [StringLength(20)]
        [Unicode(false)]
        public string Phone { get; set; } = null!;
        [StringLength(150)]
        [Unicode(false)]
        public string? Email { get; set; }
        [StringLength(150)]
        [Unicode(false)]
        public string? BankAccount { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? Ico { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? Dic { get; set; }
        public int UserId { get; set; }
        public bool Active { get; set; }
        public DateTime TimeStamp { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("BusinessBranchLists")]
        public virtual SolutionUserList User { get; set; } = null!;
        [InverseProperty("Branch")]
        public virtual ICollection<SystemDocumentAdviceList> SystemDocumentAdviceLists { get; set; }
    }
}
