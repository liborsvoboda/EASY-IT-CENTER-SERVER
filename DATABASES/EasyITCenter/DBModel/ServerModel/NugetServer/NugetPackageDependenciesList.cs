using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("NugetPackageDependenciesList")]
    public partial class NugetPackageDependenciesList
    {
        [Key]
        public int Key { get; set; }
        [StringLength(128)]
        public string? Id { get; set; }
        [StringLength(256)]
        public string? VersionRange { get; set; }
        [StringLength(256)]
        public string? TargetFramework { get; set; }
        public int? PackageKey { get; set; }

        [ForeignKey("PackageKey")]
        [InverseProperty("NugetPackageDependenciesLists")]
        public virtual NugetPackagesList? PackageKeyNavigation { get; set; }
    }
}
