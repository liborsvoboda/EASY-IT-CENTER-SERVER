using Microsoft.Extensions.Options;
using System.Buffers;

namespace EasyITCenter.Services {

    public sealed class StartUpService : BackgroundService
    {
        public StartUpService()
        {
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {

            DbOperations.LoadOrRefreshStaticDbDials();


            //RESET DB running Processes
            EasyITCenterContext dbcontext = new EasyITCenterContext();
            List<ServerStartUpScriptList>? runningProcesses = dbcontext.ServerStartUpScriptLists.Where(a => a.Pid != null).ToList();
            runningProcesses.ForEach(item => { item.Pid = null; });
            if (runningProcesses.Any()) {
                EasyITCenterContext itemData = new EasyITCenterContext(); itemData.ServerStartUpScriptLists.UpdateRange(runningProcesses);
                itemData.SaveChanges();
            }
            //RUN Startup Processes
            runningProcesses = dbcontext.ServerStartUpScriptLists.Where(a => a.RunOnServerStartUp == true).ToList();
            runningProcesses.ForEach(process => {
                RunProcessRequest startupProcess = new() {
                    Command = process.StartCommand.Replace("wwwroot", SrvRuntime.WebRootPath),
                    WorkingDirectory = process.WorkingDirectory.Replace("wwwroot", SrvRuntime.WebRootPath),
                    WaitForExit = false,
                    ProcessType = DataOperations.ParseEnum<ProcessType>(process.InheritedProcessType), StartupScriptName = process.Name
                }; ProcessOperations.ServerProcessStartAsync(startupProcess);
            });

            return Task.CompletedTask;
        }
    }




}
