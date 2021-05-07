using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamNET.Models.Request.Comment;
using TeamNET.Models.Respone.Comment;
using TeamNET.Repository.Interface;
using TeamNET.Service.Interface;

namespace TeamNET.Service.Implement
{
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository commentRepository;
        private readonly INotificationRepository notificationRepository;

        public CommentService(ICommentRepository commentRepository, INotificationRepository notificationRepository)
        {
            this.commentRepository = commentRepository;
            this.notificationRepository = notificationRepository;
        }
        public async Task<int> CreateComment(CommentRequest comment)
        {
            var result = await commentRepository.CreateComment(comment);
            if(result > 0)
                await notificationRepository.PlusNotification(comment.UserId, comment.EventContentId);
            return result;
        }

        public async Task<int> DeleteComment(int CommentId)
        {
            return await commentRepository.DeleteComment(CommentId);
        }

        public async Task<List<CommentReponse>> GetsComment(int EventContentId)
        {
            return await commentRepository.GetsComment(EventContentId);
        }
    }
}
