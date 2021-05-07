using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamNET.Models.Request.EventContent;
using TeamNET.Models.Request.EventContent;
using TeamNET.Service.Interface;

namespace TeamNET.Controllers
{
    [Authorize]
    public class AbilityController : Controller
    {
        private readonly IAbilityService abilityService;

        public AbilityController(IAbilityService abilityService)
        {
            this.abilityService = abilityService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("/Ability/Gets")]
        public async Task<OkObjectResult> Gets()
        {
            return Ok(await abilityService.Gets());
        }
        [HttpPost("/Ability/SaveAbility/{eventContentId}/{Ability}")]
        public async Task<OkObjectResult> SaveAbility(int eventContentId, string Ability)
        {
            return Ok(await abilityService.SaveAbility(eventContentId, Ability));
        }
        [HttpPost]
        [Route("/ability/createEventContentAbility")]
        public async Task<IActionResult> CreateEventContentAbility(SaveEventContentAbility request)
        {
            var result = await abilityService.CreateEventContentAbility(request);
            return Json(new { data = result });
        }
        [HttpGet]
        [Route("/ability/gets/{studentId}")]
        public async Task<IActionResult> Gets(string studentId)
        {
            var result = await abilityService.Gets(studentId);
            return Json(new { data = result });
        }
    }
}
