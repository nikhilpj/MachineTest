using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using WpfApp.Models;

namespace WpfApp.Services
{
    public class TicketService
    {
        private readonly HttpClient httpClient = new HttpClient { BaseAddress = new Uri("https://localhost:7216/api/tickets/") };

        public async Task<List<Ticket>> GetUserTickets(int userId)
        {
            return await httpClient.GetFromJsonAsync<List<Ticket>>($"{userId}");
        }

        public async Task<bool> CreateTicket(Ticket ticket)
        {
            HttpResponseMessage response = await httpClient.PostAsJsonAsync("",ticket);
            return response.IsSuccessStatusCode;
        }

        public async Task UpdateTicketStatus(int ticketId, string newStatus)
        {
            var response = await httpClient.PutAsJsonAsync($"{ticketId}/status", newStatus);
            response.EnsureSuccessStatusCode(); // Throws exception if not successful
        }




    }
}
