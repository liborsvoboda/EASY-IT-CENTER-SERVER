using Aguacongas.TheIdServer.Data;
using Aguacongas.TheIdServer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Data;


namespace EasyITCenter.ServerCoreDBSettings {

    public class ApplicationUser : IdentityUser {

    }

    /// <summary>
    /// TODO  Inherit DB Context with 
    /// Table Prefix
    /// </summary>
    public partial class WebHostingDbContext : IdentityDbContext<ApplicationUser> {

        public DbSet<SolutionUserList> Users { get; set; }
        public DbSet<SolutionUserRoleList> Roles { get; set; }

        public WebHostingDbContext(DbContextOptions<WebHostingDbContext> options)
            : base(options) {
        }

        protected override void OnModelCreating(ModelBuilder builder) {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Core Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Core Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }



}