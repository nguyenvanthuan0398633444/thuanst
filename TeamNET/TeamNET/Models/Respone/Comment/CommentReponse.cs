using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamNET.Models.Respone.Comment
{
    public class CommentReponse
    {
        public int CommentId { get; set; }
        public int EventContentId { get; set; }
        public string UserId { get; set; }
        public string Text { get; set; }
        public DateTime RealTime { get; set; }
        public string RoleName { get; set; }
        public string UserName { get; set; }
        public string Avatar { get; set; }
    }
}
