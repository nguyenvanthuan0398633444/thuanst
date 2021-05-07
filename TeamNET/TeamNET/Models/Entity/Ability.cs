using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TeamNET.Models.Entity
{
    public class Ability
    {
        [Key]
        public int AbilityId { get; set; }
        [Required]
        [MaxLength(200)]
        public string AbilityName { get; set; }
        [Required]
        [MaxLength(50)]
        public string Color { get; set; }
    }
}
