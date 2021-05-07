﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamNET.Models.Request.Comment
{
    public class CommentRequest
    {
        public int CommentId { get; set; }
        public int EventContentId { get; set; }
        public string UserId { get; set; }
        public string Text { get; set; }
        public DateTime RealTime { get; set; }
    }
}
