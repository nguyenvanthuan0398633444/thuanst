using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TeamNET.Models.Entity
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }
        [Required]
        [MaxLength(200)]
        public string EventName { get; set; }
        [Required]
        [MaxLength(100)]
        public string Icon { get; set; }
    }
}
