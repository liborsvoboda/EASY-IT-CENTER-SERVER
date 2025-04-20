using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("NugetPackagesList")]
    public partial class NugetPackagesList
    {
        public NugetPackagesList()
        {
            NugetPackageDependenciesLists = new HashSet<NugetPackageDependenciesList>();
            NugetPackageTypesLists = new HashSet<NugetPackageTypesList>();
            NugetTargetFrameworksLists = new HashSet<NugetTargetFrameworksList>();
        }

        [Key]
        public int Key { get; set; }
        [StringLength(128)]
        public string Id { get; set; } = null!;
        [StringLength(4000)]
        public string? Authors { get; set; }
        [StringLength(4000)]
        public string? Description { get; set; }
        public long Downloads { get; set; }
        public bool HasReadme { get; set; }
        [StringLength(20)]
        public string? Language { get; set; }
        public bool Listed { get; set; }
        [StringLength(44)]
        public string? MinClientVersion { get; set; }
        public DateTime Published { get; set; }
        public bool RequireLicenseAcceptance { get; set; }
        [StringLength(4000)]
        public string? Summary { get; set; }
        [StringLength(256)]
        public string? Title { get; set; }
        [StringLength(4000)]
        public string? IconUrl { get; set; }
        [StringLength(4000)]
        public string? LicenseUrl { get; set; }
        [StringLength(4000)]
        public string? ProjectUrl { get; set; }
        [StringLength(4000)]
        public string? RepositoryUrl { get; set; }
        [StringLength(100)]
        public string? RepositoryType { get; set; }
        [StringLength(4000)]
        public string? Tags { get; set; }
        public byte[]? RowVersion { get; set; }
        [StringLength(64)]
        public string Version { get; set; } = null!;
        public bool IsPrerelease { get; set; }
        public int SemVerLevel { get; set; }
        [StringLength(64)]
        public string? OriginalVersion { get; set; }
        public string? ReleaseNotes { get; set; }
        public bool HasEmbeddedIcon { get; set; }

        [InverseProperty("PackageKeyNavigation")]
        public virtual ICollection<NugetPackageDependenciesList> NugetPackageDependenciesLists { get; set; }
        [InverseProperty("PackageKeyNavigation")]
        public virtual ICollection<NugetPackageTypesList> NugetPackageTypesLists { get; set; }
        [InverseProperty("PackageKeyNavigation")]
        public virtual ICollection<NugetTargetFrameworksList> NugetTargetFrameworksLists { get; set; }
    }
}
