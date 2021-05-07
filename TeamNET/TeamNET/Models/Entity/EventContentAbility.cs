using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TeamNET.Models.Entity
{
    public class EventContentAbility
    {
        [Required]
        public int EventContentId { get; set; }
        public EventContent EventContent { get; set; }
        [Required]
        public int AbilityId { get; set; }
        public Ability Ability { get; set; }
    }
}
