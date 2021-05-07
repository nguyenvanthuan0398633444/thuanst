using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TeamNET.Models.Entity
{
    public class NotificationEventContent
    {
        [Key]
        public int NotificationEventContentId { get; set; }
        public int EventContentId { get; set; }
        [ForeignKey("EventContentId")]
        public EventContent EventContent { get; set; }
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public ApplicationUser UserNotification { get; set; }
        public int Notification { get; set; }

    }
}
