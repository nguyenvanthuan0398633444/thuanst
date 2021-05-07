using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamNET.Models.Request.Comment;
using TeamNET.Models.Respone;
using TeamNET.Models.Respone.Comment;

namespace TeamNET.Repository.Interface
{
    public interface ICommentRepository
    {
        Task<int> CreateComment(CommentRequest comment);
        Task<List<CommentReponse>> GetsComment(int EventContentId);
        Task<int> DeleteComment(int CommentId);
    }
}
