using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamNET.Models.Request.Comment;
using TeamNET.Service.Interface;

namespace TeamNET.Controllers
{
    [Authorize]
    public class CommentController : Controller
    {
        private readonly ICommentService commentService;

        public CommentController(ICommentService commentService)
        {
            this.commentService = commentService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<OkObjectResult> SaveComment(CommentRequest comment)
        {
            comment.RealTime = DateTime.Now;
            return Ok(await commentService.CreateComment(comment));
        }
        [HttpPost("/Comment/DeleteComment/{commentId}")]
        public async Task<OkObjectResult> DeleteComment(int commentId)
        {
            return Ok(await commentService.DeleteComment(commentId));
        }
        [HttpGet("/Comment/GetsComment/{EventContentId}")]
        public async Task<OkObjectResult> GetsComment(int EventContentId)
        {
            return Ok(await commentService.GetsComment(EventContentId));
        }
    }
}
