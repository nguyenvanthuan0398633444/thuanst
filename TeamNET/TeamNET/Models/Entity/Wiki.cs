using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TeamNET.Models.Entity
{
    public class Wiki
    {
        public int TableId { get; set; }
        [Required]
        [MaxLength(100)]
        public string TableName { get; set; }
        public int StatusId { get; set; }
        [Required]
        [MaxLength(100)]
        public string StatusName { get; set; }
        public bool IsDeleted { get; set; }
    }
}
