using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("SolutionLanguageList")]
    [Index("Name", Name = "IX_ServerLanguageList", IsUnique = true)]
    public partial class SolutionLanguageList
    {
        public SolutionLanguageList()
        {
            BusinessAddressLists = new HashSet<BusinessAddressList>();
            SolutionUserLists = new HashSet<SolutionUserList>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string Name { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string FullName { get; set; } = null!;
        [Unicode(false)]
        public string? Description { get; set; }
        public int UserId { get; set; }
        public DateTime TimeStamp { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("SolutionLanguageLists")]
        public virtual SolutionUserList User { get; set; } = null!;
        public virtual ICollection<BusinessAddressList> BusinessAddressLists { get; set; }
        public virtual ICollection<SolutionUserList> SolutionUserLists { get; set; }
    }
}
