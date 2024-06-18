using Microsoft.AspNetCore.SignalR;

namespace Lab.SignalR.Hubs
{
	public class LabHub : Hub
	{
		public async Task SendMessage(string user, string message)
		{
			await Clients.All.SendAsync("ReceiveMessage", user, message);
		}
	}
}
