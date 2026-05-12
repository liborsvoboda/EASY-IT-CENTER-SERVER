using Microsoft.AspNetCore.SignalR;


namespace EasyITCenter.ServerCoreStructure {

    public class StreamChat : Hub {


        public async Task RequestUsers() {
            await Clients.Caller.SendAsync("ResponseUsers", JsonSerializer.Serialize(SrvRuntime.SignalRUsers));
        }


        public async Task SendMessage(string user, string message) {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }


        public Task SendMessageToCaller(string user, string message) {
            return Clients.Caller.SendAsync("ReceiveMessage", user, message);
        }


        public Task SendMessageToGroup(string user, string message) {
            return Clients.Group("SignalR Users").SendAsync("ReceiveMessage", user, message);
        }


        public Task SendMessageToUser(string user, string message) {
                return Clients.User(user).SendAsync("ReceiveStream", Context.UserIdentifier != null ? Context.UserIdentifier : "", message);
        }


        public override async Task OnConnectedAsync() {
            if (Context.UserIdentifier != null && SrvRuntime.SignalRUsers.Where(a => a == Context.UserIdentifier.ToString()).Count() == 0) {
                SrvRuntime.SignalRUsers.Add(Context.UserIdentifier.ToString());
                await Groups.AddToGroupAsync(Context.UserIdentifier, "SignalR Users");
            }
            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception exception) {
            if (Context.UserIdentifier != null) {
                SrvRuntime.SignalRUsers.Remove(Context.UserIdentifier.ToString());
                await Groups.RemoveFromGroupAsync(Context.UserIdentifier, "SignalR Users");
            }
            await base.OnDisconnectedAsync(exception);
        }


    }

}