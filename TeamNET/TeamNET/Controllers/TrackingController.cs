using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamNET.Models;
using TeamNET.Models.Respone.Tracking;
using TeamNET.Repository.Interface;

namespace TeamNET.Controllers
{
    [Authorize]
    public class TrackingController : Controller
    {
        private readonly ITrackingChartRepository trackingChartRepository;

        public TrackingController(ITrackingChartRepository trackingChartRepository)
        {
            this.trackingChartRepository = trackingChartRepository;
        }
        [HttpGet("Tracking/Index/{studentId}")]
        public IActionResult Index(string studentId)
        {
            ViewBag.studentId = studentId;
            return View();
        }
        [HttpGet("Tracking/TrackingChart/{studentId}")]
        public async Task<IActionResult> TrackingChart(string studentId)
        {
            var data = await trackingChartRepository.TrackingByStudentId(studentId);

            return Json(new { data = data });
        }
        [HttpGet("Tracking/TrackingDoughnutByStudentId/{studentId}")]
        public async Task<IActionResult> TrackingDoughnutByStudentId(string studentId)
        {
            var data = await trackingChartRepository.TrackingDoughnutByStudentId(studentId);

            return Json(new { data = data });
        }
        [HttpGet("Tracking/ShowAbility")]
        public async Task<IActionResult> ShowAbility()
        {
            var data = await trackingChartRepository.ShowAbility();

            return Json(new { data = data });
        }
        [HttpGet("Tracking/ShowEventChartDoughnut/{studentId}/{abilityName}")]
        public async Task<IActionResult> ShowEventChartDoughnut(string studentId, string abilityName)
        {
            var data = await trackingChartRepository.ShowEventChartDoughnut(studentId, abilityName);

            return Json(new { data = data });
        }
        [HttpGet("Tracking/ShowEventChartBar/{studentId}/{abilityName}/{courseName}")]
        public async Task<IActionResult> ShowEventChartBar(string studentId, string abilityName, string courseName)
        {
            var data = await trackingChartRepository.ShowEventChartBar(studentId, abilityName, courseName);

            return Json(new { data = data });
        }
        [HttpGet("Tracking/StudentInfo/{studentId}")]
        public async Task<IActionResult> StudentInfo(string studentId)
        {
            var data = await trackingChartRepository.StudentInfo(studentId);

            return Json(new { data = data });
        }
    }
}
