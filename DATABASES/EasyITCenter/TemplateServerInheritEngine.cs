using Microsoft.EntityFrameworkCore.Metadata;
using System.Data;


namespace EasyITCenter.ServerCoreDBSettings {


    /// <summary>
    /// TODO  Inherit DB Context with 
    /// Table Prefix
    /// </summary>
    public partial class WorkFlowContext : DbContext {

        public WorkFlowContext(string connectionString) : base(SqlServerDbContextOptionsExtensions.UseSqlServer(new DbContextOptionsBuilder(), connectionString).Options) {

        }

        public WorkFlowContext(DbContextOptions<DbContext> options)
            : base(options) {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            foreach (IMutableEntityType entity in modelBuilder.Model.GetEntityTypes()) {
                entity.SetTableName("Workflow" + entity.GetTableName());
            }
        }
    }


    /// <summary>
    /// Database Context Extensions for All Types Procedures For Retun Data in procedure can be
    /// Simple SELECT * XXX and you Create Same Class for returned DataSet
    /// </summary>
    public static class WorkflowContextExtensions {

        public static List<T> EasyITCenterCollectionFromSql<T>(this WorkFlowContext dbContext, string sql) where T : class, new() {
            using var cmd = dbContext.Database.GetDbConnection().CreateCommand();
            cmd.CommandText = sql;
            if (cmd.Connection.State != ConnectionState.Open)
                cmd.Connection.Open();
            try {
                List<T> results = null;
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                table.Load(cmd.ExecuteReader());
                results = DataOperations.GenericConvertTableToClassList<T>(table).ToList();

                return results;
            } catch (Exception Ex) { CoreOperations.SendEmail(new SendMailRequest() { Content = DataOperations.GetSystemErrMessage(Ex) }); } finally { cmd.Connection.Close(); }
            return new List<T>();
        }
    }
}