using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TeamNET.Models.Entity
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public int EventContentId { get; set; }
        [ForeignKey("EventContentId")]
        public EventContent EventContent { get; set; }
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }
        [Required]
        [MaxLength(500)]
        public string Text { get; set; }
        public DateTime RealTime { get; set; }
    }
}
