using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamNET.Models;
using TeamNET.Models.Request.Comment;
using TeamNET.Models.Respone;
using TeamNET.Models.Respone.Comment;
using TeamNET.Repository.Interface;

namespace TeamNET.Repository.Implement
{
    public class CommentRepository : ICommentRepository
    {
        private readonly OJTDbContext context;

        public CommentRepository(OJTDbContext context)
        {
            this.context = context;
        }
        public async Task<int> CreateComment(CommentRequest comment)
        {
            var commentEntity = new TeamNET.Models.Entity.Comment()
            {
                CommentId = comment.CommentId,
                EventContentId = comment.EventContentId,
                RealTime = comment.RealTime,
                Text = comment.Text,
                UserId = comment.UserId
            };
            if (comment.CommentId == 0)
                context.Comments.Add(commentEntity);
            else
                context.Comments.Update(commentEntity);

            return await context.SaveChangesAsync();
        }

        public async Task<int> DeleteComment(int CommentId)
        {
            var comment = context.Comments.Where(e => e.CommentId == CommentId).FirstOrDefault();
            context.Comments.Remove(comment);
            return await context.SaveChangesAsync();
        }

        public async Task<List<CommentReponse>> GetsComment(int EventContentId)
            {
            var ListComment = await (from c in context.Comments.Where(e => e.EventContentId == EventContentId)
                              join ur in context.UserRoles on c.UserId equals ur.UserId
                              join r in context.Roles on ur.RoleId equals r.Id
                              join us in context.Users on ur.UserId equals us.Id
                              select (new CommentReponse()
                {
                                  CommentId = c.CommentId,
                                  EventContentId = c.EventContentId,
                                  RealTime = c.RealTime,
                                  Text = c.Text,
                                  UserId = c.UserId,
                                  RoleName = r.Name,
                                  UserName = us.FullName,
                                  Avatar = us.AvatarName
                              })).Distinct().ToListAsync();
            var result = ListComment.OrderBy(e => e.CommentId).ToList();
            return result;
        }
    }
}
