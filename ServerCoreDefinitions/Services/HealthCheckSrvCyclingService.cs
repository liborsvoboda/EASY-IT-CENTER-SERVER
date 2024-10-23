﻿namespace EasyITCenter.Services {

    /// <summary>
    /// Task Context Definition
    /// </summary>
    public class ServerCycleTaskProcess {
        private int _outstandingTaskCount = 0;

        public void RegisterTask() {
            Interlocked.Increment(ref _outstandingTaskCount);
        }

        public void MarkTaskAsComplete() {
            Interlocked.Decrement(ref _outstandingTaskCount);
        }

        public bool IsComplete => _outstandingTaskCount == 0;
    }


    /// <summary>
    /// Hosted Service Interface defintion
    /// </summary>
    public interface IServerCycleTaskService : IHostedService { }


    public static class ServerCycleTaskExtension {
        private static readonly ServerCycleTaskProcess _serverCycleProcess = new ServerCycleTaskProcess();

        public static IServiceCollection AddStartupTasks(this IServiceCollection services) {
            if (services.Any(x => x.ServiceType == typeof(ServerCycleTaskProcess))) { return services; }
            return services.AddSingleton(_serverCycleProcess);
        }

        public static IServiceCollection AddStartupTask<T>(this IServiceCollection services) where T : class, IServerCycleTaskService {
            _serverCycleProcess.RegisterTask();
            return services.AddStartupTasks().AddHostedService<T>();
        }
    }

    

    /// <summary>
    /// HeathCheck Server Cycling Services 
    /// Can be used for Auto Operations
    /// Corrections/Processes/Update/Regenerate/Etc
    /// </summary>
    public class ServerCycleTaskList : BackgroundService, IServerCycleTaskService {
        private readonly ServerCycleTaskProcess _serverCycleTaskProcess;

        public ServerCycleTaskList(ServerCycleTaskProcess startupTaskContext) {
            _serverCycleTaskProcess = startupTaskContext;
        }

        // run the task
        protected override async Task ExecuteAsync(CancellationToken stoppingToken) {
            await Task.Delay(10_000, stoppingToken);
            _serverCycleTaskProcess.MarkTaskAsComplete();
        }
    }


    /// <summary>
    /// Registering to HeathCheck View
    /// </summary>
    public class ServerCycleTaskListHealthCheck : IHealthCheck {
        private readonly ServerCycleTaskProcess _context;
        public ServerCycleTaskListHealthCheck(ServerCycleTaskProcess context) {
            _context = context;
        }

        public Task<HealthCheckResult> CheckHealthAsync(
            HealthCheckContext context,
            CancellationToken cancellationToken = new CancellationToken()) {
            if (_context.IsComplete) {
                return Task.FromResult(HealthCheckResult.Healthy("All startup tasks complete"));
            }

            return Task.FromResult(HealthCheckResult.Unhealthy("Startup tasks not complete"));
        }
    }


    /// <summary>
    /// ServerCycleTaskMiddleware Reference Definition
    /// </summary>
    public class ServerCycleTaskMiddleware {
        private readonly ServerCycleTaskProcess _process;
        private readonly RequestDelegate _next;

        public ServerCycleTaskMiddleware(ServerCycleTaskProcess process, RequestDelegate next) {
            _process = process;
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext) {
            if (_process.IsComplete) {
                await _next(httpContext);
            } else {
                HttpResponse? response = httpContext.Response;
                response.StatusCode = 503;
                response.Headers["Retry-After"] = "30";
                await response.WriteAsync("Service Unavailable");
            }
        }
    }
}