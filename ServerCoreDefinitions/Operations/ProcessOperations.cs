using EasyITCenter.ServerCoreWebPages;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.IdentityModel.Tokens;
using NUglify.Helpers;
using ServiceStack;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Management.Automation;
using System.Net.Mail;
using System.Runtime.InteropServices;

namespace EasyITCenter.ServerCoreStructure {

    /// <summary>
    /// Server Process Operations
    /// PowerShell, System Commands, Scripts Processing
    /// Used *.cmd, *.bat, *.ps1, *.sh 
    /// Linux/Windows has same filename,
    /// File Extension has Auto Change *.sh and *.cmd
    /// </summary>
    public static class ProcessOperations {


        /// <summary>
        /// Server Function For Running External Processes,
        /// Solved Windows/Linux processing,
        /// startup script name is automatically corrected from .bat to .sh with same name,
        /// </summary>
        /// <param name="processDefinition">The process definition.</param>
        /// <returns></returns>
        public async static Task<string> RunSystemProcess(RunProcessRequest processDefinition) {
            string resultOutput = "", resultError = "";

            try {
                using (Process proc = new Process()) {
                   
                    if (CoreOperations.SrvOStype.IsWindows()) {
                        proc.StartInfo.FileName = processDefinition.Command.Replace(".sh", ".cmd");
                        proc.StartInfo.Arguments = processDefinition.Arguments ?? null;
                        proc.StartInfo.WorkingDirectory = processDefinition.WorkingDirectory + "\\" ?? null;
                    } else {
                        proc.StartInfo.FileName = "/bin/bash";
                        proc.StartInfo.Arguments = string.Format(" \"{0}\"", processDefinition.Command.Replace(".cmd",".sh"));
                    }

                   
                    //proc.StartInfo.LoadUserProfile = false;
                    proc.StartInfo.CreateNoWindow = true;
                    proc.StartInfo.UseShellExecute = false;
                    proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    proc.StartInfo.RedirectStandardOutput = true;
                    proc.StartInfo.RedirectStandardError = true;
                    proc.StartInfo.Verb = (Environment.OSVersion.Version.Major >= 6) ? "runas" : "";
                    proc.Start();

                    resultOutput += proc.StandardOutput.ReadToEndAsync();
                    resultError += proc.StandardError.ReadToEndAsync();

                    if (processDefinition.WaitForExit) {
                        await proc.WaitForExitAsync();
                        return resultOutput + Environment.NewLine + resultError;
                    }
                    else { return resultOutput + Environment.NewLine + resultError; }
                }

            } catch (Exception ex) { resultError += ex.StackTrace + Environment.NewLine + ex.Message;
                CoreOperations.SendEmail(new SendMailRequest() { Content = DataOperations.GetErrMsg(ex) });
            }
            return resultOutput + Environment.NewLine + resultError;
        }



        /// <summary>
        /// PowerShell Script Runner
        /// </summary>
        /// <param name="script"></param>
        /// <returns></returns>
        public async static Task<string> RunPowerShellProcess(string script) {
            try {
                using (PowerShell ps = PowerShell.Create()) {
                    Collection<PSObject>? results = ps.AddScript(script).Invoke();
                    ps.Commands.Clear();
                    return results.AsEnumerable().ToList().ToJson();
                }
            } catch (Exception ex) {
                string err = DataOperations.GetErrMsg(ex);
                CoreOperations.SendEmail(new SendMailRequest() { Content = err });
                return err;
            }

        }

    }
}