using System;
using System.Collections.Generic;

namespace EasyITCenter.WebDBModel
{
    public partial class AspNetRole
    {
        public AspNetRole()
        {
            AspNetRoleClaims = new HashSet<AspNetRoleClaim>();
            ServerPathListRoleDownloadNavigations = new HashSet<ServerPathList>();
            ServerPathListRoleReadAccessNavigations = new HashSet<ServerPathList>();
            ServerScriptListRoleDownloadNavigations = new HashSet<ServerScriptList>();
            ServerScriptListRoleReadAccessNavigations = new HashSet<ServerScriptList>();
        }

        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? NormalizedName { get; set; }
        public string? ConcurrencyStamp { get; set; }

        public virtual ICollection<AspNetRoleClaim> AspNetRoleClaims { get; set; }
        public virtual ICollection<ServerPathList> ServerPathListRoleDownloadNavigations { get; set; }
        public virtual ICollection<ServerPathList> ServerPathListRoleReadAccessNavigations { get; set; }
        public virtual ICollection<ServerScriptList> ServerScriptListRoleDownloadNavigations { get; set; }
        public virtual ICollection<ServerScriptList> ServerScriptListRoleReadAccessNavigations { get; set; }
    }
}
