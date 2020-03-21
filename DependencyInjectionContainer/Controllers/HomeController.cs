using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjectionContainer.Services;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionContainer.Controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly LuckyDrawService _luckyDrawService;
        public HomeController(LuckyDrawService luckyDrawService )
        {
            _luckyDrawService = luckyDrawService;
        }

        [Route("")]
        public IActionResult Index()
        {
            string message = $"Broadcast to Company Home Screen: Winner is {_luckyDrawService.GetWinner()}";

            var screen = new List<string>
            {
                HttpContext.Items["AgentWinner"].ToString(),
                message
            };

            return Ok(screen);
        }
    }
}