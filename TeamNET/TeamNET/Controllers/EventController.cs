using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamNET.Service.Interface;

namespace TeamNET.Controllers
{
    [Authorize]
    public class EventController : Controller
    {
        private readonly IEventService eventService;

        public EventController(IEventService eventService)
        {
            this.eventService = eventService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [Route("/event/gets")]
        public IActionResult Gets()
        {
            var result = eventService.Gets();
            return Json(new { data = result });
        }
    }
}
