using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamNET.Models;
using TeamNET.Models.Respone;
using TeamNET.Repository.Interface;
using TeamNET.Models.Request.Student;
using TeamNET.Service.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using TeamNET.Models.Entity;

namespace TeamNET.Controllers
{
    [Authorize]
    public class StudentController : Controller
    {
        private readonly IStudentService studentService;
        private readonly UserManager<ApplicationUser> userManager;

        public StudentController(IStudentService studentService,
                                 UserManager<ApplicationUser> userManager)
        {
            this.studentService = studentService;
            this.userManager = userManager;
        }
        [Authorize(Roles = "Teacher,Doctor,Guardian ")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("/student/details/{studentId}")]
        public async Task<IActionResult> Details(string studentId)
        {
            var userId = userManager.GetUserId(HttpContext.User);
            var user = await userManager.FindByIdAsync(userId);
            ViewBag.StudentId = studentId;
            ViewBag.UserId = userId;
            ViewBag.RolesUser = await userManager.GetRolesAsync(user);
            var student = await studentService.GetInfoStudent(studentId);
            ViewBag.Student = student;
            return View();
        }
        [Authorize(Roles = "Teacher,Doctor,Guardian ")]
        [HttpGet("/StudentList/{userId}")]
        public async Task<OkObjectResult> StudentList(string userId)
        {
            var Students = await studentService.Students(userId);
            return Ok(Students);
        }
        [Authorize(Roles = "Teacher,Doctor,Guardian ")]
        [HttpGet("/StudentList/{userId}/{studentName}/{eventss}/{ability}/{courseName}")]
        public async Task<OkObjectResult> StudentList(string userId, string studentName, int eventss, string ability, int courseName)
        {
            var result = await studentService.StudentsConditions(userId, studentName, eventss, ability, courseName);

                return Ok(result);
        }
        [HttpGet("/Student/get/{studentId}")]
        public async Task<IActionResult> Get(string studentId)
        {
            var userCurrentId = userManager.GetUserId(HttpContext.User);
            var result = await studentService.Get(studentId, userCurrentId);
            return Json(new { data = result });
        }
        [HttpGet("/Student/EventList/{userId}/{CourseCurrentId}")]
        public async Task<OkObjectResult> EventList(string userId, int courseCurrentId)
        {
            var Events = await studentService.Events(userId, courseCurrentId);
            return Ok(Events);
        }
        [HttpGet("/Student/AbilityList/{userId}/{CourseCurrentId}")]
        public async Task<OkObjectResult> AbilityList(string userId, int courseCurrentId)
        {
            var Abilities = await studentService.Abilities(userId, courseCurrentId);

            return Ok(Abilities);
        }
        public async Task<OkObjectResult> CurrentCourse(int courseCurrentId)
        {
            var course = await studentService.Course(courseCurrentId);
            return Ok(course);
        }
        [HttpPost("/student/searchStudentEvent")]
        public async Task<IActionResult> SearchStudentEvent([FromBody]ReqSearchEvent request)
        {
            request.UserCurrentId = userManager.GetUserId(HttpContext.User);
            var result = await studentService.SearchStudentEvent(request);
            return Json(new { data = result });
        }
    }
}
