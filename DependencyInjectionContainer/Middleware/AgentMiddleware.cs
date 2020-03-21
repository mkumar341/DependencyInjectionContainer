using DependencyInjectionContainer.Services;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionContainer.Middleware
{
    public class AgentMiddleware
    {
        private readonly RequestDelegate _broadcast;
        public AgentMiddleware(RequestDelegate broadcast)
        {
            _broadcast = broadcast;
        }

        public async Task InvokeAsync(HttpContext request, LuckyDrawService luckyDrawService)
        {
            string message = $"Broadcast to Agents Screen: Winner is {luckyDrawService.GetWinner()}";
            
            request.Items.Add("AgentWinner", message);

            // Call the next delegate/middleware in the pipeline
            await _broadcast(request);
        }

    }
}
