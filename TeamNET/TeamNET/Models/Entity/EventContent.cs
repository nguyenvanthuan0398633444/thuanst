using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TeamNET.Models.Entity
{
    public class EventContent
    {
        [Key]
        public int EventContentId { get; set; }
        public int EventId { get; set; }
        public Event Event { get; set; }
        public string StudentId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        [Required]
        [MaxLength(500)]
        public string CommunityAbility { get; set; }
        [Required]
        [MaxLength(500)]
        public string ActionAbility { get; set; }
        [Required]
        [MaxLength(500)]
        public string DemonstratedAbility { get; set; }
        [Required]
        [MaxLength(500)]
        public string SelfDevelopment { get; set; }
        [Required]
        [MaxLength(500)]
        public string ThinkingAbility { get; set; }
        public int CourseCurrentId { get; set; }
        [ForeignKey("CourseCurrentId")]
        public UserCourseDetail UserCourseDetalis { get; set; }
        [Required]
        public int StatusId { get; set; }
        public ICollection<EventContentAbility> EventContentAbilities { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<NotificationEventContent> NotificationEventContents { get; set; }
    }
}
