using Microsoft.AspNetCore.SignalR;

namespace Lab.SignalR.Hubs
{
	public class LabHub : Hub
	{
		/// <summary>
		/// SendMessage takes a message from a user and relays it to all connected clients.
		/// </summary>
		/// <param name="user"></param>
		/// <param name="message"></param>
		/// <returns></returns>
		public async Task SendMessage(string user, string message)
		{
			await Clients.All.SendAsync("ReceiveMessage", user, message);
		}
	}
}
