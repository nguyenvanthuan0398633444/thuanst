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
    public class CourseController : Controller
    {
        private readonly ICourseService courseService;

        public CourseController(ICourseService courseService)
        {
            this.courseService = courseService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [Route("/course/gets/{studentId}")]
        public async Task<IActionResult> Gets(string studentId)
        {
            var result = await courseService.Gets(studentId);
            return Json(new { data = result });
        }
    }
}
