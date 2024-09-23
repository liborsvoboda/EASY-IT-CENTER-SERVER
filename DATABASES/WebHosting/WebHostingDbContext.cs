using System.Data;
using System.Data.Common;


namespace EasyITCenter.DevPortal {

    public class WebHostingDbContext : IdentityDbContext<IdentityUser> {
        public WebHostingDbContext(DbContextOptions<WebHostingDbContext> options) : base(options) {
        }
        protected override void OnModelCreating(ModelBuilder builder) {
            base.OnModelCreating(builder);
        }
    }
}
