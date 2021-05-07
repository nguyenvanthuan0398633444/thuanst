using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamNET.Models.Entity;
using TeamNET.Service.Interface;
using TeamNET.ViewModels.EventContent;

namespace TeamNET.Controllers
{
    [Authorize]
    public class EventContentController : Controller
    {
        private readonly IEventContentService eventContentService;
        private readonly IEventService eventService;
        private readonly UserManager<ApplicationUser> userManager;

        public EventContentController(IEventContentService eventContentService,
                                      IEventService eventService,
                                   UserManager<ApplicationUser> userManager)
        {
            this.eventContentService = eventContentService;
            this.eventService = eventService;
            this.userManager = userManager;
        }
        [Authorize(Roles = "Student, System Admin")]
        [HttpGet]
        public IActionResult Register()
        {
            var model = new EventContentViewModel();
            model.Events = eventService.Gets();
            ViewBag.StudentId = userManager.GetUserId(HttpContext.User);
            return View(model);
        }
        [Authorize(Roles = "Student, System Admin")]
        [HttpPost]
        public async Task<IActionResult> Register(EventContentViewModel model)
        {
            if (ModelState.IsValid)
            {
                var userId = userManager.GetUserId(HttpContext.User);
                model.StudentId = userId;
                var user = await userManager.FindByIdAsync(userId);
                model.CourseCurrentId = user.CourseCurrentId;
                var result = await eventContentService.Register(model);
                if (result.IsSuccess)
                {
                    TempData["Message"] = result.Message;
                    return Redirect("/Student/Details/" + userId);
                }
                else
                {
                    ViewBag.IsSuccess = result.IsSuccess;
                    TempData["Message"] = result.Message;
                }
            }
            return View(model);
        }
        [HttpGet]
        [Route("/eventContent/update/{id}")]
        public async Task<IActionResult> Update(int id)
        {
            var userId = userManager.GetUserId(HttpContext.User);
            var userIds = await eventContentService.UserIdsEventContent(id);
            if (!userIds.Contains(userId))
            {
                return Redirect("/Account/AccessDenied");
            }
            var user = await userManager.FindByIdAsync(userId);
            ViewBag.User = user;
            var roles = await userManager.GetRolesAsync(user);
            var model = eventContentService.Get(id);
            if (model == null)
            {
                return Redirect("/Student/Details/" + model.StudentId);
            }
            model.Events = eventService.Gets();
            ViewBag.RolesUser = roles;
            await eventContentService.ChangeStatusActive(model, roles.ToList());
            await eventContentService.ResetNotification(userId, id);
            return View(model);
        }
        [Authorize(Roles = "Student, System Admin")]
        [HttpPost]
        public async Task<IActionResult> Update(EventContentViewModel model)
        {
            if (ModelState.IsValid)
            {
                model.Events = eventService.Gets();
                var result = await eventContentService.Update(model);
                var userId = userManager.GetUserId(HttpContext.User);
                var user = await userManager.FindByIdAsync(userId);
                ViewBag.User = user;
                var roles = await userManager.GetRolesAsync(user);
                model.Events = eventService.Gets();
                ViewBag.RolesUser = roles;
                ViewBag.IsSuccess = result.IsSuccess? "true" : "false";
                TempData["Message"] = result.Message;
            }
            return View(model);
        }
        [Authorize(Roles = "Student, System Admin")]
        [HttpPatch]
        [Route("/eventContent/delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await eventContentService.Delete(id);
            return Json(new { data = result});
        }
        [Authorize(Roles = "Doctor, System Admin")]
        [HttpPatch]
        [Route("/eventContent/changeStatus/{id}/{statusId}")]
        public async Task<IActionResult> ChangeStatus(int id, int statusId)
        {
            var result = await eventContentService.ChangeStatus(id, statusId);
            return Json(new { data = result });
        }
        [HttpGet]
        [Route("/eventContent/get/{id}")]
        public IActionResult Get(int id)
        {
            var result = eventContentService.Get(id);
            return Json(new { data = result });
        }
    }
}
