using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("NugetPackageTypesList")]
    public partial class NugetPackageTypesList
    {
        [Key]
        public int Key { get; set; }
        [StringLength(512)]
        public string? Name { get; set; }
        [StringLength(64)]
        public string? Version { get; set; }
        public int PackageKey { get; set; }

        [ForeignKey("PackageKey")]
        [InverseProperty("NugetPackageTypesLists")]
        public virtual NugetPackagesList PackageKeyNavigation { get; set; } = null!;
    }
}
