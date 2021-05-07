using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TeamNET.Models.Entity
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
        [MaxLength(450)]
        public string GuardianId { get; set; }
        public int CourseCurrentId { get; set; }
        [MaxLength(100)]
        public string StudentCode { get; set; }
        [MaxLength(100)]
        public string AvatarName { get; set; }
        public ICollection<EventContent> EventContents { get; set; }
    }
}
