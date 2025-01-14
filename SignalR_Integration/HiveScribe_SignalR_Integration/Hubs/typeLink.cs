using Microsoft.AspNetCore.SignalR;

namespace HiveScribe_SignalR_Integration.Hubs
{
	public class typeLink : Hub
	{
		public async Task updateMessageBox(string message)
		{
			await Clients.All.SendAsync("updateMessageBox", message);
		}
	}
}