using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("NugetTargetFrameworksList")]
    public partial class NugetTargetFrameworksList
    {
        [Key]
        public int Key { get; set; }
        [StringLength(256)]
        public string? Moniker { get; set; }
        public int PackageKey { get; set; }

        [ForeignKey("PackageKey")]
        [InverseProperty("NugetTargetFrameworksLists")]
        public virtual NugetPackagesList PackageKeyNavigation { get; set; } = null!;
    }
}
