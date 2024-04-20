using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;

namespace ProjectMVC.Hubs
{
    public class jobHub:Hub
    {
        public async Task AddJob(string jobName)
        {

            await Clients.All.SendAsync("AddJob", jobName);
        }

    }
}
