using ServerCorePages;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.IdentityModel.Tokens;
using NUglify.Helpers;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Management.Automation;
using System.Net.Mail;
using System.Runtime.InteropServices;
using Python.Runtime;

namespace EasyITCenter.ServerCoreStructure {

    public enum ProcessType {
        dotnet,
        cmd,
        bat,
        powershellFile,
        powershellScript,
        py3,
        sh

    }

    /// <summary>
    /// Server Process class for running external prrocesses
    /// </summary>
    public class RunProcessRequest {
        public string Command { get; set; }
        public string? WorkingDirectory { get; set; } = null;
        public ProcessType ProcessType { get; set; }
        public bool WaitForExit = true;
    }


    /// <summary>
    /// Server Process Operations
    /// PowerShell, System Commands, Scripts Processing
    /// Used *.cmd, *.bat, *.ps1, *.sh 
    /// Linux/Windows has same filename,
    /// File Extension has Auto Change *.sh and *.cmd
    /// </summary>
    public static class ProcessOperations {


        /// <summary>
        /// https://stackoverflow.com/questions/2035193/how-to-run-a-powershell-script
        ///SHELL FROM CMD:   Powershell.exe -File C:\Install\script.ps1
        /// Server Function For Running External Processes,
        /// Solved Windows/Linux processing,
        /// startup script name is automatically corrected from .bat to .sh with same name,
        /// Arguments dotnet "path\release\PublishOutput\proces.dll"
        /// </summary>
        /// <param name="processDefinition">The process definition.</param>
        /// <returns></returns>
        public async static Task<string> ServerProcessStart(RunProcessRequest processDefinition) {
            string resultOutput = "", resultError = "";

            try {
                Process proc = new();

                    if (processDefinition.ProcessType == ProcessType.dotnet) {
                        proc.StartInfo.FileName = "dotnet";
                        proc.StartInfo.UseShellExecute = true;
                        proc.StartInfo.Arguments = processDefinition.Command ?? null;
                    } else if (processDefinition.ProcessType == ProcessType.cmd || processDefinition.ProcessType == ProcessType.bat) {
                        proc.StartInfo.FileName = "cmd.exe";
                        proc.StartInfo.UseShellExecute = false;
                        proc.StartInfo.Arguments = processDefinition.Command ?? null;
                    } else if (processDefinition.ProcessType == ProcessType.sh) {
                        proc.StartInfo.FileName = "/bin/bash";
                        proc.StartInfo.Arguments = string.Format(" \"{0}\"", processDefinition.Command);
                        proc.StartInfo.UseShellExecute = false;
                    } else if (processDefinition.ProcessType == ProcessType.powershellFile) {
                        proc.StartInfo.FileName = "powershell";
                        proc.StartInfo.Arguments = string.Format(" \"{0}\"", processDefinition.Command);
                        proc.StartInfo.UseShellExecute = false;
                   } else if (processDefinition.ProcessType == ProcessType.powershellScript) {
                        RunPowerShellProcess(processDefinition);
                    }


            proc.StartInfo.WorkingDirectory = processDefinition.WorkingDirectory + "\\" ?? null;
                    //proc.StartInfo.LoadUserProfile = false;
                    proc.StartInfo.CreateNoWindow = true;
                    proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    proc.StartInfo.RedirectStandardOutput = true;
                    proc.StartInfo.RedirectStandardError = true;
                    proc.StartInfo.Verb = ( Environment.OSVersion.Version.Major >= 6 ) ? "runas" : "";

                    SrvRuntime.SrvProcessManager.Add(new Tuple<string,Process>(proc.ProcessName ,proc));
                    proc.Start();

                    //proc.OutputDataReceived +=;
                    proc.Exited += ServerProcessFinished; 
                    resultOutput += proc.StandardOutput.ReadToEndAsync();
                    resultError += proc.StandardError.ReadToEndAsync();

                    if (processDefinition.WaitForExit) {
                        await proc.WaitForExitAsync();
                        return resultOutput + Environment.NewLine + resultError;
                    } else { return resultOutput + Environment.NewLine + resultError; }

                } catch (Exception ex) { resultError += ex.StackTrace + Environment.NewLine + ex.Message;
                    CoreOperations.SendEmail(new SendMailRequest() { Content = DataOperations.GetErrMsg(ex) });
                }
            return resultOutput + Environment.NewLine + resultError;
        }


        /// <summary>
        /// Server Process Manager Remove Finished Process
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void ServerProcessFinished(object? sender, EventArgs e) {
            try {
                var process = SrvRuntime.SrvProcessManager.Where(a => a.Item2 == (Process)sender).FirstOrDefault();
                if (process != null) { SrvRuntime.SrvProcessManager.Remove(process); }
            } catch (Exception ex) {
                CoreOperations.SendEmail(new SendMailRequest() { Content = DataOperations.GetErrMsg(ex) });
            }
        }


        /// <summary>
        /// Server Kill Running Process
        /// </summary>
        /// <param name="processName"></param>
        /// <returns></returns>
        public static bool ServerProcessKill(string processName) {
            try {
                var process = SrvRuntime.SrvProcessManager.Where(a => a.Item1 == processName).FirstOrDefault();
                process?.Item2.Kill();
                if (process != null) { SrvRuntime.SrvProcessManager.Remove(process); }
                return true;    
            } catch (Exception ex) {
                CoreOperations.SendEmail(new SendMailRequest() { Content = DataOperations.GetErrMsg(ex) });
                return false;
            }
        }


        /// <summary>
        /// https://stackoverflow.com/questions/2035193/how-to-run-a-powershell-script
        /// PowerShell Script Runner
        /// </summary>
        /// <param name="script"></param>
        /// <returns></returns>
        public async static Task<string> RunPowerShellProcess(RunProcessRequest processDefinition) {
            try {
                using (PowerShell ps = PowerShell.Create()) {
                    //ps.AddArgument = processDefinition.WorkingDirectory
                    Collection<PSObject>? results = ps.AddScript(processDefinition.Command).Invoke();
                    ps.Commands.Clear();
                    return results.AsEnumerable().ToList().ObjectToJson();
                }
            } catch (Exception ex) {
                string err = DataOperations.GetErrMsg(ex);
                CoreOperations.SendEmail(new SendMailRequest() { Content = err });
                return err;
            }

        }


    }
}