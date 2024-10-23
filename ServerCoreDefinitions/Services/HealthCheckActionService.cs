namespace EasyITCenter.Services {

    /// <summary>
    /// HeathCheck Handler For Sending Information About Fails
    /// </summary>
    public class HealthCheckActionService : IHealthCheckPublisher {
        private HealthReport? _prevStatus = null;

        /// <summary>
        /// Heath Check Action Service FOR Bad Statuses of Control Result
        /// </summary>
        /// <param name="report"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task PublishAsync(HealthReport report, CancellationToken cancellationToken) {
            if ((report.Status == HealthStatus.Degraded || report.Status == HealthStatus.Unhealthy) &&
            SrvConfig.ServiceCoreCheckerEmailSenderActive &&
            ((SrvConfig.ModuleHealthServiceMessageOnChangeOnly && _prevStatus?.Status == HealthStatus.Healthy) || !SrvConfig.ModuleHealthServiceMessageOnChangeOnly)) {
                string message = "";
                report.Entries.ToList().ForEach(monit => {
                    if (monit.Value.Status == HealthStatus.Degraded || monit.Value.Status == HealthStatus.Unhealthy) {
                        message += monit.Key + " status: " + monit.Value.Status.ToString() + Environment.NewLine + monit.Value.Description + Environment.NewLine;
                    }
                });
                CoreOperations.SendEmail(new SendMailRequest() { Content = message });
            }
            _prevStatus = report;
            return Task.CompletedTask;
        }
    }
}