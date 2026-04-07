using CSJsonDB;
using Google.Api;
using PerformanceStatistics;
using System.Management;
using Tensorflow;

namespace EasyITCenter.Services {

   public class PerformanceMonitorService : IHostedService, IDisposable {

        private Timer timer;
        private IPerformanceStatistics stats;

        public Task StartAsync(CancellationToken cancellationToken) {

            SrvRuntime.PerformanceMonitorStatus = true;

            if (PerformanceStatisticsFactory.IsPlatformSupported) {
                using var stats = PerformanceStatisticsFactory.Create();
                stats.MonitoredProcessNames.Add(DbOperations.GetServerParameterLists("ConfigCoreServerRegisteredName").Value);

                SrvRuntime.PerformanceMonitor.Clear();
                SrvRuntime.PerformanceMonitor.Add("Platform", PerformanceStatisticsFactory.CurrentPlatform.ToString());
                SrvRuntime.PerformanceMonitor.Add("CPU Count", Environment.ProcessorCount.ToString());

                int index = 1;
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2","SELECT * FROM Win32_PerfFormattedData_PerfProc_Process");
                foreach (ManagementObject queryObj in searcher.Get()) {
                    SrvRuntime.PerformanceMonitor.Add($"CPU {index++} Usage", queryObj["PercentProcessorTime"].ToString());
                }


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

                SrvRuntime.PerformanceMonitor.Add("All Connections", stats.GetActiveTcpConnections().Length.ToString());

                index = 0;
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
            SrvRuntime.PerformanceMonitorStatus = false;
            timer?.Change(Timeout.Infinite, 0);
            return Task.CompletedTask;
        }


        public void Stop(CancellationToken cancellationToken)
        {
            SrvRuntime.PerformanceMonitorStatus = false;
            timer?.Change(Timeout.Infinite, 0);
        }

        public void Dispose()
        {
            timer?.Dispose();
            stats?.Dispose();
        }
    }
    
}