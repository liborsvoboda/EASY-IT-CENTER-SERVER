using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using FileContextCore;
using FileContextCore.FileManager;
using FileContextCore.Serializer;
using Microsoft.Extensions.Hosting.Internal;
using LinqToDB;
using Microsoft.Extensions.DependencyInjection;
using EasyITCenter.ServerCoreWebPages;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace EasyITCenter.DevPortal {

    #region DefaultStructure
    public class ApplicationUser : IdentityUser {
    }

    public class ClientWebSetting : WebSetting {
        public string WebSetting { get; set; }
    }

    public class WebSetting  {
        [Key]
        public int Id { get; set; }
        public int? InheritedType { get; set; }

        public string Key { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }

        public string SupportUrl { get; set; }
        public byte[] Attachment { get; set; }
        public bool Active { get; set; }

        public int User { get; set; }

        public DateTime TimeStamp { get; set; }

    }

    #endregion DefaultStructure


    /// <summary>
    /// Shared WebHosting Standalone Database 
    /// https://github.com/morrisjdev/FileContextCore/blob/master/Example/Program.cs
    /// </summary>
    public class WebHostingDbContext : IdentityDbContext<ApplicationUser> { 
        
        private readonly Microsoft.AspNetCore.Hosting.IWebHostEnvironment _hostingEnvironment;
        private readonly IServiceProvider _serviceProvider;

        //public WebHostingDbContext(Microsoft.AspNetCore.Hosting.IWebHostEnvironment hostingEnvironment, IServiceProvider serviceProvider) { 
        //    _hostingEnvironment = hostingEnvironment; _serviceProvider = serviceProvider;
        //}

        public WebHostingDbContext(DbContextOptions<WebHostingDbContext> options)
           : base(options) {
        }

        public WebHostingDbContext() { }

        public DbSet<ClientWebSetting> ClientWebSetting { get; set; }
        public DbSet<WebSetting> WebSetting { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\Projekty\\zEasy\\EASY-IT-CENTER\\EASY-IT-CENTER-SERVER\\wwwroot\\server-private\\databases\\EICwebHosting.mdf;Integrated Security=True;Connect Timeout=30",
                        x => x.MigrationsAssembly(typeof(WebHostingDbContext).Assembly.FullName).MigrationsHistoryTable("MigrationHistory").UseNetTopologySuite())
                    .UseInternalServiceProvider(_serviceProvider);
            //optionsBuilder.UseFileContextDatabase<JSONSerializer, DefaultFileManager>(databaseName: "EICwebHosting",location: Path.Combine(_hostingEnvironment.WebRootPath, FileOperations.GetLastFolderFromPath(ServerRuntimeData.ServerPrivate_path), "databases", "EICwebHosting.mdf"), password: "EICwebHOSTING");
            //optionsBuilder.UseFileContextDatabase<JSONSerializer, DefaultFileManager>();
        }

        protected override void OnModelCreating(ModelBuilder builder) {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
           
        }
    }



}