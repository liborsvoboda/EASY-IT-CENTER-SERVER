using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using FileContextCore;
using FileContextCore.FileManager;
using FileContextCore.Serializer;
using Microsoft.Extensions.Hosting.Internal;
using LinqToDB;
using Microsoft.Extensions.DependencyInjection;
using ServerCorePages;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Data.Common;

namespace EasyITCenter.WebDBModel {


    public class ApplicationUser : IdentityUser {

    }

    /// <summary>
    /// Shared WebHosting Standalone Database 
    /// </summary>
    public class WebHostingDbContext : EICWebHostingDbContext /* IdentityDbContext */{
        private ApplicationUser _currentUser;
        
        public WebHostingDbContext() { }
        public WebHostingDbContext(DbContextOptions<EICWebHostingDbContext> options)
           : base(options) {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        //    optionsBuilder.UseInternalServiceProvider(SrvRuntime.SrvServiceProvider)
        //        .UseSqlServer($"Data Source={SrvConfig.WebHostingDBConnString};AttachDbFilename=E:\\Projekty\\zEasy\\EASY-IT-CENTER\\EASY-IT-CENTER-SERVER\\wwwroot\\server-private\\databases\\EICwebHosting.mdf;Connect Timeout=30");
        //}

        protected override void OnModelCreating(ModelBuilder builder) {
            base.OnModelCreating(builder);
           
        }
    }


    public static class WebHostingDbInitialize {
        public static async Task Initialize(WebHostingDbContext context) {
            if (await context.Database.CanConnectAsync()) return;
            //SrvRuntime.ConnectedDatabases.Add(context);
        }
    }

    /// <summary>
    /// Database Context Extensions for All Types Procedures For Return Data in procedure can be
    /// Simple SELECT * XXX and you Create Same Class for returned DataSet
    /// </summary>
    public static class WebHostingDbContextExtensions {

        


        /*
        public static async void WriteVisit(string ipAddress, int userId, string? userName) {
            // Save new visit
            if (!string.IsNullOrWhiteSpace(userName)) {
                SystemLoginHistoryList record = new() { IpAddress = ipAddress, UserId = userId, UserName = userName, TimeStamp = DateTimeOffset.Now.DateTime };
                EntityEntry<SystemLoginHistoryList>? result = new WebHostingDbContext().SystemLoginHistoryLists.Add(record);
                await result.Context.SaveChangesAsync();
            }
        }
        */

        public static string CreateDbScript(WebHostingDbContext context) {
            return context.Database.GenerateCreateScript();
        }



        public static List<object>? FileDatabaseCollectionFromSql(this WebHostingDbContext WebHostingDbContext, Type type, string sql) {
            using var cmd = WebHostingDbContext.Database.GetDbConnection().CreateCommand();
            cmd.CommandText = sql;
            if (cmd.Connection?.State != ConnectionState.Open)
                cmd.Connection?.Open();
            try {
                List<object>? results = new List<object>();
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                table.Load(cmd.ExecuteReader());
                results = DataOperations.ConvertTableToClassListByType(table, type).ToList();
                //(table.AsDataView());

                return results;
            } catch (Exception Ex) { CoreOperations.SendEmail(new SendMailRequest() { Content = DataOperations.GetErrMsg(Ex) }); } finally { cmd.Connection?.Close(); }
            return null;
        }


        public static List<T> FileDatabaseCollectionFromSql<T>(this WebHostingDbContext WebHostingDbContext, string sql) where T : class, new() {
            using var cmd = WebHostingDbContext.Database.GetDbConnection().CreateCommand();
            cmd.CommandText = sql;
            if (cmd.Connection?.State != ConnectionState.Open)
                cmd.Connection?.Open();
            try {
                List<T> results = null;
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                table.Load(cmd.ExecuteReader());
                results = DataOperations.GenericConvertTableToClassList<T>(table).ToList();

                return results;
            } catch (Exception Ex) { CoreOperations.SendEmail(new SendMailRequest() { Content = DataOperations.GetErrMsg(Ex) }); } finally { cmd.Connection?.Close(); }
            return new List<T>();
        }

        public static IQueryable? Set(this WebHostingDbContext context, Type T) {
            MethodInfo? method = typeof(WebHostingDbContext).GetMethod(nameof(WebHostingDbContext.Set), BindingFlags.Public | BindingFlags.Instance);
            method = method?.MakeGenericMethod(T);
            return method?.Invoke(context, null) as IQueryable;
        }

        public static IQueryable<T>? Set<T>(this WebHostingDbContext context) {
            MethodInfo? method = typeof(WebHostingDbContext).GetMethod(nameof(WebHostingDbContext.Set), BindingFlags.Public | BindingFlags.Instance);
            method = method?.MakeGenericMethod(typeof(T));
            return method?.Invoke(context, null) as IQueryable<T>;
        }


        public static object? GetDbSet(WebHostingDbContext db, Type T) {
            MethodInfo? method = typeof(WebHostingDbContext).GetMethod(nameof(WebHostingDbContext.Set), BindingFlags.Public | BindingFlags.Instance);
            method = method?.MakeGenericMethod(T);
            return method?.Invoke(Set(db, T), null);
        }


        public static object GetDbSet<T>(WebHostingDbContext db) where T : class {
            return db.Set<T>() as object;
        }

        public static DbTransaction? GetDbTransaction(this WebHostingDbContext source) {
            return ( source.Database.BeginTransaction() as IInfrastructure<DbTransaction> )?.Instance;
        }

        public static object? ExecuteScalar(this WebHostingDbContext context,
        string sql, List<DbParameter> parameters = null,
        CommandType commandType = CommandType.Text,
        int? commandTimeOutInSeconds = null) {
            Object? value;
            try {
                using (var cmd = context.Database.GetDbConnection().CreateCommand()) {

                    if (cmd.Connection?.State != ConnectionState.Open) {
                        cmd.Connection?.Open();
                    }
                    cmd.CommandText = sql;
                    cmd.CommandType = commandType;
                    if (commandTimeOutInSeconds != null) {
                        cmd.CommandTimeout = (int)commandTimeOutInSeconds;
                    }
                    if (parameters != null) {
                        cmd.Parameters.AddRange(parameters.ToArray());
                    }
                    value = cmd.ExecuteScalar();
                    cmd.Connection?.Close();
                }
                return value;

            } catch (Exception Ex) { CoreOperations.SendEmail(new SendMailRequest() { Content = DataOperations.GetErrMsg(Ex) }); }
            return new object();
        }


        public async static Task<object?> ExecuteScalarAsync(this WebHostingDbContext context, string sql, List<DbParameter>? parameters = null, CommandType commandType = CommandType.Text, int? commandTimeOutInSeconds = null) {
            Object? value;
            try {
                using (var cmd = context.Database.GetDbConnection().CreateCommand()) {

                    if (cmd.Connection?.State != ConnectionState.Open) {
                        await cmd.Connection?.OpenAsync();
                    }
                    cmd.CommandText = sql;
                    cmd.CommandType = commandType;
                    if (commandTimeOutInSeconds != null) { cmd.CommandTimeout = (int)commandTimeOutInSeconds; }
                    if (parameters != null) { cmd.Parameters.AddRange(parameters.ToArray()); }
                    value = await cmd.ExecuteScalarAsync();
                    cmd.Connection?.Close();
                }
                return value;

            } catch (Exception Ex) { CoreOperations.SendEmail(new SendMailRequest() { Content = DataOperations.GetErrMsg(Ex) }); }
            return new object();
        }


        public static int ExecuteNonQuery(this WebHostingDbContext context, string command, List<DbParameter>? parameters = null, CommandType commandType = CommandType.Text, int? commandTimeOutInSeconds = null) {
            try {
                using (var cmd = context.Database.GetDbConnection().CreateCommand()) {
                    if (cmd.Connection?.State != ConnectionState.Open) {
                        cmd.Connection?.Open();
                    }
                    var currentTransaction = context.Database.CurrentTransaction;
                    if (currentTransaction != null) {
                        cmd.Transaction = currentTransaction.GetDbTransaction();
                    }
                    cmd.CommandText = command;
                    cmd.CommandType = commandType;
                    if (commandTimeOutInSeconds != null) {
                        cmd.CommandTimeout = (int)commandTimeOutInSeconds;
                    }
                    if (parameters != null) {
                        cmd.Parameters.AddRange(parameters.ToArray());
                    }
                    int value = cmd.ExecuteNonQuery();
                    //cmd.Connection?.Close();
                    return value;
                }
            } catch (Exception Ex) { CoreOperations.SendEmail(new SendMailRequest() { Content = DataOperations.GetErrMsg(Ex) }); }
            return new int();
        }

        public async static Task<int> ExecuteNonQueryAsync(this WebHostingDbContext context, string command, List<DbParameter>? parameters = null, CommandType commandType = CommandType.Text, int? commandTimeOutInSeconds = null) {
            try {
                using (var cmd = context.Database.GetDbConnection().CreateCommand()) {
                    if (cmd.Connection?.State != ConnectionState.Open) {
                        await cmd.Connection?.OpenAsync();
                    }
                    var currentTransaction = context.Database.CurrentTransaction;
                    if (currentTransaction != null) {
                        cmd.Transaction = currentTransaction.GetDbTransaction();
                    }
                    cmd.CommandText = command;
                    cmd.CommandType = commandType;
                    if (commandTimeOutInSeconds != null) {
                        cmd.CommandTimeout = (int)commandTimeOutInSeconds;
                    }
                    if (parameters != null) {
                        cmd.Parameters.AddRange(parameters.ToArray());
                    }
                    int value = await cmd.ExecuteNonQueryAsync();
                    //cmd.Connection?.Close();
                    return value;
                }
            } catch (Exception Ex) { CoreOperations.SendEmail(new SendMailRequest() { Content = DataOperations.GetErrMsg(Ex) }); }
            return new int();
        }


        public static DataTable ExecuteReader(this WebHostingDbContext context, string command, List<DbParameter>? parameters = null, CommandType commandType = CommandType.Text, int? commandTimeOutInSeconds = null) {
            try {
                using (var cmd = context.Database.GetDbConnection().CreateCommand()) {
                    if (cmd.Connection?.State != ConnectionState.Open) {
                        cmd.Connection?.Open();
                    }
                    var currentTransaction = context.Database.CurrentTransaction;
                    if (currentTransaction != null) {
                        cmd.Transaction = currentTransaction.GetDbTransaction();
                    }
                    cmd.CommandText = command;
                    cmd.CommandType = commandType;
                    if (commandTimeOutInSeconds != null) {
                        cmd.CommandTimeout = (int)commandTimeOutInSeconds;
                    }
                    if (parameters != null) { cmd.Parameters.AddRange(parameters.ToArray()); }

                    DataTable? table = new DataTable();
                    table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                    table.Load(cmd.ExecuteReader());
                    table = ( table.DefaultView.Table?.AsDataView()?.Table );

                    //List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
                    //Dictionary<string, object> row;

                    //if (table != null) {
                    //    foreach (DataRow dr in table.Rows) {
                    //        row = new Dictionary<string, object>();
                    //        foreach (DataColumn col in table.Columns) { row.Add(col.ColumnName, dr[col]); }
                    //        rows.Add(row);
                    //    }
                    //}
                    cmd.Connection?.Close();
                    return table;
                }
            } catch (Exception Ex) { CoreOperations.SendEmail(new SendMailRequest() { Content = DataOperations.GetErrMsg(Ex) }); }
            return null;
        }


        public async static Task<DataTable> ExecuteReaderAsync(this WebHostingDbContext context, string command, List<DbParameter>? parameters = null, CommandType commandType = CommandType.Text, int? commandTimeOutInSeconds = null) {
            try {
                using (var cmd = context.Database.GetDbConnection().CreateCommand()) {
                    if (cmd.Connection?.State != ConnectionState.Open) {
                        await cmd.Connection?.OpenAsync();
                    }
                    var currentTransaction = context.Database.CurrentTransaction;
                    if (currentTransaction != null) {
                        cmd.Transaction = currentTransaction.GetDbTransaction();
                    }
                    cmd.CommandText = command;
                    cmd.CommandType = commandType;
                    if (commandTimeOutInSeconds != null) {
                        cmd.CommandTimeout = (int)commandTimeOutInSeconds;
                    }
                    if (parameters != null) { cmd.Parameters.AddRange(parameters.ToArray()); }

                    DataTable? table = new DataTable();
                    table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                    table.Load(await cmd.ExecuteReaderAsync());
                    table = ( table.DefaultView.Table?.AsDataView()?.Table );

                    //List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
                    //Dictionary<string, object> row;

                    //if (table != null) {
                    //    foreach (DataRow dr in table.Rows) {
                    //        row = new Dictionary<string, object>();
                    //        foreach (DataColumn col in table.Columns) { row.Add(col.ColumnName, dr[col]); }
                    //        rows.Add(row);
                    //    }
                    //}
                    cmd.Connection?.Close();
                    return table;
                }
            } catch (Exception Ex) { CoreOperations.SendEmail(new SendMailRequest() { Content = DataOperations.GetErrMsg(Ex) }); }
            return null;
        }


        public static IQueryable<TSource> FromSqlRaw<TSource>(this WebHostingDbContext db, string sql, params object[] parameters) where TSource : class {
            var item = db.Set<TSource>().FromSqlRaw(sql, parameters);
            return item;
        }
    }

}