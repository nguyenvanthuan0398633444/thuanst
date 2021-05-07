using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamNET.Models.Request.Comment;
using TeamNET.Models.Respone.Comment;

namespace TeamNET.Service.Interface
{
    public interface ICommentService
    {
        Task<int> CreateComment(CommentRequest comment);
        Task<int> DeleteComment(int CommentId);
        Task<List<CommentReponse>> GetsComment(int EventContentId);
    }
}
