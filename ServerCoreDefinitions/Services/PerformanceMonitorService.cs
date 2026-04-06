using CSJsonDB;
using PerformanceStatistics;
using System.Management;
using Tensorflow;

namespace EasyITCenter.Services {

   public class PerformanceMonitorService : IHostedService, IDisposable {

        private Timer timer;
        private IPerformanceStatistics stats;

        public Task StartAsync(CancellationToken cancellationToken) {

            if (PerformanceStatisticsFactory.IsPlatformSupported) {
                using var stats = PerformanceStatisticsFactory.Create();
                stats.MonitoredProcessNames.Add(DbOperations.GetServerParameterLists("ConfigCoreServerRegisteredName").Value);

                SrvRuntime.PerformanceMonitor.Clear();
                SrvRuntime.PerformanceMonitor.Add("Platform", PerformanceStatisticsFactory.CurrentPlatform.ToString());
                SrvRuntime.PerformanceMonitor.Add("CPU Count", Environment.ProcessorCount.ToString());


                SelectQuery? query = new SelectQuery("Win32_PerfFormattedData_PerfOS_Processor", "PercentProcessorTime", new string[] {"NOT Name LIKE '%_Total'" });
                ManagementObjectSearcher? searcher = new ManagementObjectSearcher(query);

                ManagementObjectCollection results = null;
                try {
                    results = Task.Run(() => searcher.Get()).GetAwaiter().GetResult();
                    foreach (ManagementObject result in results) {
                        
                        float usage = (float)( Convert.ToUInt64(result.Properties["PercentProcessorTime"].Value) ) / Environment.ProcessorCount;
                        SrvRuntime.PerformanceMonitor.Add("CPU Usage", usage.ToString());
                        break; 
                    }
                } catch (Exception ex) {
                   
                }

                //SrvRuntime.PerformanceMonitor.Add("CPU", stats.System.CpuUtilizationPercent.ToString() + "%");
                //SrvRuntime.PerformanceMonitor.Add("Free RAM", stats.System.MemoryFreeMegabytes.ToString() + " MB");

                stats.MonitoredProcessNames.Add("dotnet");
                foreach (var kvp in stats.MonitoredProcesses) {
                    foreach (var proc in kvp.Value) {
                        SrvRuntime.PerformanceMonitor.Add("dotnet | " + proc.ProcessId.ToString() + " | " + proc.ProcessName, ( proc.WorkingSetMemory / 1024 / 1024 ).ToString() + " MB");
                    }
                }

                stats.MonitoredProcessNames.Remove("dotnet");
                stats.MonitoredProcessNames.Add("node");
                foreach (var kvp in stats.MonitoredProcesses) {
                    foreach (var proc in kvp.Value) {
                        SrvRuntime.PerformanceMonitor.Add("node | " + proc.ProcessId.ToString() + " | " + proc.ProcessName, ( proc.WorkingSetMemory / 1024 / 1024 ).ToString() + " MB");
                    }
                }


                stats.MonitoredProcessNames.Remove("node");
                stats.MonitoredProcessNames.Add("cmd");
                foreach (var kvp in stats.MonitoredProcesses) {
                    foreach (var proc in kvp.Value) {
                        SrvRuntime.PerformanceMonitor.Add("cmd | " + proc.ProcessId.ToString() + " | " + proc.ProcessName, ( proc.WorkingSetMemory / 1024 / 1024 ).ToString() + " MB");
                    }
                }

                stats.MonitoredProcessNames.Remove("cmd");
                stats.MonitoredProcessNames.Add("py");
                stats.MonitoredProcessNames.Add("py3");
                foreach (var kvp in stats.MonitoredProcesses) {
                    foreach (var proc in kvp.Value) {
                        SrvRuntime.PerformanceMonitor.Add("python | " + proc.ProcessId.ToString() + " | " + proc.ProcessName, ( proc.WorkingSetMemory / 1024 / 1024 ).ToString() + " MB");
                    }
                }

                // Disk
                //SrvRuntime.PerformanceMonitor.Add("Disc Read", stats.System.TotalDiskReadOperations.ToString());
                //SrvRuntime.PerformanceMonitor.Add("Disc Write", stats.System.TotalDiskWriteOperations.ToString());
                //SrvRuntime.PerformanceMonitor.Add("Disc Read Queue", stats.System.TotalDiskReadQueue.ToString());
                //SrvRuntime.PerformanceMonitor.Add("Disc Write Queue", stats.System.TotalDiskWriteQueue.ToString());
                //SrvRuntime.PerformanceMonitor.Add("Disc Free %", stats.System.TotalDiskFreePercent.ToString());
                //SrvRuntime.PerformanceMonitor.Add("Disc Free MB", stats.System.TotalDiskFreeMegabytes.ToString());
                //SrvRuntime.PerformanceMonitor.Add("Disc Size", stats.System.TotalDiskSizeMegabytes.ToString());
                //SrvRuntime.PerformanceMonitor.Add("Disc Used MB", stats.System.TotalDiskUsedMegabytes.ToString());

                SrvRuntime.PerformanceMonitor.Add("All Connections", stats.GetActiveTcpConnections().Length.ToString());

                int index = 0;
                stats.GetActiveTcpConnections().Select(a => a.LocalEndPoint.ToString() + " " + a.RemoteEndPoint.ToString()).ToList()
                    .ForEach(item => { SrvRuntime.PerformanceMonitor.Add($"{index++} TCP Connection", item); });
                
                timer = new Timer(CheckPerformance, null, TimeSpan.Zero, TimeSpan.FromSeconds(double.Parse(DbOperations.GetServerParameterLists("ServerPerformanceMonitorTimeIntervalSec").Value)));
            }
            return Task.CompletedTask;
        }


        private void CheckPerformance(object state)
        {
            //var cpu = stats.System.CpuUtilizationPercent;
            //var memory = stats.System.MemoryFreeMegabytes;

            //if (cpu.HasValue && cpu > 90)
            //{
            //    SrvRuntime.PerformanceMonitor.Add("Alert CPU is overloaded", cpu.ToString());
            //}

            //if (memory.HasValue && memory < 500)
            //{
            //    SrvRuntime.PerformanceMonitor.Add("Alert Low Memory", memory.ToString());
            //}
        }


        public Task StopAsync(CancellationToken cancellationToken)
        {
            timer?.Change(Timeout.Infinite, 0);
            return Task.CompletedTask;
        }


        public void Stop(CancellationToken cancellationToken)
        {
            timer?.Change(Timeout.Infinite, 0);
        }

        public void Dispose()
        {
            timer?.Dispose();
            stats?.Dispose();
        }
    }
    
}