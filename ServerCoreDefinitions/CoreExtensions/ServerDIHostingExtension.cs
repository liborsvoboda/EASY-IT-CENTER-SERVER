using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Http.Features;

namespace EasyITCenter.Services {

    public class TaskExecutingServer : IServer {
        private readonly IServer _server;
        private readonly IEnumerable<IStartupTask> _startupTasks;

        public TaskExecutingServer(IServer server, IEnumerable<IStartupTask> startupTasks) {
            _server = server;
            _startupTasks = startupTasks;
        }

        public async Task StartAsync<TContext>(IHttpApplication<TContext> application, CancellationToken cancellationToken) {
            
            foreach (var startupTask in _startupTasks) {
                await startupTask.ExecuteAsync(cancellationToken);
            }

            await _server.StartAsync(application, cancellationToken);
        }

        // Delegate implementation to default IServer
        public IFeatureCollection Features => _server.Features;
        public void Dispose() => _server.Dispose();
        public Task StopAsync(CancellationToken cancellationToken) => _server.StopAsync(cancellationToken);
    }



    /// <summary>
    /// Server Startup Task Definition
    /// Run before Start The Server
    /// Defined For Generic Type
    /// </summary>
    public interface IStartupTask {
        Task ExecuteAsync<T>(T referencedType, CancellationToken cancellationToken = default);
    }

    /// <summary>
    /// Server Core Integration Automatic of
    /// Extension Service Types
    /// For Apply Changes you must Restart Server
    /// </summary>
    public static class ServiceCollectionExtensions {


        public static IServiceCollection AddStartupTask<T>(this IServiceCollection services) where T : class, IStartupTask {
            return services.AddTransient<IStartupTask, T>();
        }
    }



    public static class StartupTaskWebHostExtensions {
        public static async Task RunWithTasksAsync(this IWebHost webHost, CancellationToken cancellationToken = default) {
            var startupTasks = webHost.Services.GetServices<IStartupTask>();

            // Execute all the tasks
            foreach (var startupTask in startupTasks) {
                await startupTask.ExecuteAsync(cancellationToken);
            }

            // Start the tasks as normal
            await webHost.RunAsync(cancellationToken);
        }
    }


    /*
        public interface IStartupTask {
            Task ExecuteAsync(CancellationToken cancellationToken = default);
        }

        public static class ServiceCollectionExtensions {
            public static IServiceCollection AddStartupTask<T>(this IServiceCollection services)
                where T : class, IStartupTask
                => services.AddTransient<IStartupTask, T>();
        }


        public static class StartupTaskWebHostExtensions {
            public static async Task RunWithTasksAsync(this IWebHost webHost, CancellationToken cancellationToken = default) {
                // Load all tasks from DI
                var startupTasks = webHost.Services.GetServices<IStartupTask>();

                // Execute all the tasks
                foreach (var startupTask in startupTasks) {
                    await startupTask.ExecuteAsync(cancellationToken);
                }

                // Start the tasks as normal
                await webHost.RunAsync(cancellationToken);
            }
        }*/
}
