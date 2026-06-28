using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("SolutionRegistrationParameterList")]
    [Index("Key", Name = "IX_SolutionRegistrationParameterList", IsUnique = true)]
    public partial class SolutionRegistrationParameterList
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string InheritedServerParamType { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string InheritedDataType { get; set; } = null!;
        public int Sequence { get; set; }
        [StringLength(150)]
        [Unicode(false)]
        public string Key { get; set; } = null!;
        [Unicode(false)]
        public string Value { get; set; } = null!;
        [Unicode(false)]
        public string? Description { get; set; }
        [Unicode(false)]
        public string? MdContent { get; set; }
        public int UserId { get; set; }
        [Required]
        public bool? Active { get; set; }
        public DateTime? Expiry { get; set; }
        public DateTime TimeStamp { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("SolutionRegistrationParameterLists")]
        public virtual SolutionUserList User { get; set; } = null!;
    }
}
