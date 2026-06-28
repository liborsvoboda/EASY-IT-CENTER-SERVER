namespace EasyITCenter.Controllers {

    [Authorize]
    [ApiController]
    [Route("EasyITCenterSolutionSchedulerProcessSupportList")]
    public class EasyITCenterSolutionSchedulerProcessListApi : ControllerBase {


        [HttpGet("/EasyITCenterSolutionSchedulerProcessSupportList")]
        public async Task<string> GetSolutionSchedulerProcessList() {
            List<SolutionSchedulerProcessSupportList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            })) { data = new EasyITCenterContext().SolutionSchedulerProcessSupportLists.OrderByDescending(a => a.TimeStamp).ToList(); }
            return JsonSerializer.Serialize(data);
        }

        [HttpGet("/EasyITCenterSolutionSchedulerProcessSupportList/{taskId}")]
        public async Task<string> GetSolutionSchedulerProcessListByParent(int taskId ) {
            List<SolutionSchedulerProcessSupportList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            })) { data = new EasyITCenterContext().SolutionSchedulerProcessSupportLists.Where(a=>a.ScheduledTaskId == taskId).OrderByDescending(a => a.TimeStamp).ToList(); }
            return JsonSerializer.Serialize(data);
        }

        /*
            [HttpPost("/EasyITCenterLoginHistory/Name")]
            [Consumes("application/json")]//([FromBody] string Name) Body is only "tester" ([FromBody] NameFilter Name) Body is {"Name":"tester"}
            public async Task<string> GetLoginHistoryName([FromBody] NameFilter Name)
            {
                if (string.IsNullOrWhiteSpace(Name.Name)) return JsonSerializer.Serialize(new DBResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = "Id is null" });

                List<LoginHistory> data;
                using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
                { IsolationLevel = IsolationLevel.ReadUncommitted }))
                { data = new EasyITCenterContext().LoginHistories.Where(a => a.UserName == Name.Name.ToString()).ToList(); }
                return JsonSerializer.Serialize(data);
            }
        */
    }
}
