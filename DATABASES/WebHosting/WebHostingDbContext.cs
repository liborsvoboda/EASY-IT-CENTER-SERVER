using Acornima.Ast;
using Aguacongas.TheIdServer.Data;
using Aguacongas.TheIdServer.Models;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Data;
using FileContextCore;
using FileContextCore.FileManager;
using FileContextCore.Serializer;
using Microsoft.Extensions.Hosting.Internal;


namespace EasyITCenter.DevPortal {

    #region DefaultStructure

    public class WebRole : IdentityRole {

    }

    public class WebUser : IdentityUser {
        public string WebRole { get; set; }
    }

    public class Setting  {
        [Key]
        public int Id { get; set; }
        public int? InheritedType { get; set; }

        public string Key { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }

        public string SupportUrl { get; set; }
        public byte[] Attachment { get; set; }
        public bool Active { get; set; }

        [ForeignKey("WebUser")]
        public int WebUserId { get; set; }

        public DateTime TimeStamp { get; set; }

        public virtual WebUser User { get; set; }
    }

    #endregion DefaultStructure


    /// <summary>
    /// Shared WebHosting Standalone Database 
    /// https://github.com/morrisjdev/FileContextCore/blob/master/Example/Program.cs
    /// </summary>
    public class WebHostingDbContext : IdentityDbContext<WebUser, WebRole, string> {
        
        private readonly Microsoft.AspNetCore.Hosting.IWebHostEnvironment _hostingEnvironment;
        public WebHostingDbContext(Microsoft.AspNetCore.Hosting.IWebHostEnvironment hostingEnvironment) { _hostingEnvironment = hostingEnvironment; }

        public WebHostingDbContext() { }

        public DbSet<WebRole> Role { get; set; }
        public DbSet<WebUser> User { get; set; }
        public DbSet<Setting> Setting { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseFileContextDatabase<JSONSerializer, DefaultFileManager>(databaseName: "EICwebHosting",location: Path.Combine(_hostingEnvironment.WebRootPath, FileOperations.GetLastFolderFromPath(ServerRuntimeData.ServerPrivate_path), "databases", "EICwebHosting.mdf"), password: "EICwebHOSTING");
            //optionsBuilder.UseFileContextDatabase<JSONSerializer, DefaultFileManager>();
        }

        protected override void OnModelCreating(ModelBuilder builder) {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
            builder.Entity<WebRole>().Property(b => b.NormalizedName).HasMaxLength(255);
            builder.Entity<WebRole>().HasData(
                new IdentityRole() { Id = "1", Name = "Provider" },
                new IdentityRole() { Id = "10", Name = "Partner" },
                new IdentityRole() { Id = "20", Name = "Developer" },
                new IdentityRole() { Id = "30", Name = "Supplier" },
                new IdentityRole() { Id = "40", Name = "Customer" },
                new IdentityRole() { Id = "50", Name = "Tester" },
                new IdentityRole() { Id = "60", Name = "Guest" }
            );

            builder.Entity<WebUser>().Property(b => b.NormalizedEmail).HasMaxLength(255);
            builder.Entity<WebUser>().Property(b => b.NormalizedUserName).HasMaxLength(255);
            builder.Entity<WebUser>().HasData(new WebUser { WebRole= "Provider", UserName = "Developer" });
        }
    }



}