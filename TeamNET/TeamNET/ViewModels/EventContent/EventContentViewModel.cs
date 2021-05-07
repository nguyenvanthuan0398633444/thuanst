using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TeamNET.Models.Entity;
using System.Linq;
using System.Threading.Tasks;
using TeamNET.Models.Respone.Event;

namespace TeamNET.ViewModels.EventContent
{
    public class EventContentViewModel
    {
        public IEnumerable<EventView> Events { get; set; }
        public int EventContentId { get; set; }
        [Required(ErrorMessage = "あなたはエベントをまだ選んでしませんでした.")]
        public int EventId { get; set; }
        public string StudentId { get; set; }
        [Required(ErrorMessage = "あなたは一番号解答まだ入力しませんでした.")]
        [MaxLength(500)]
        public string CommunityAbility { get; set; }
        [Required(ErrorMessage = "あなたは二番号解答まだ入力しませんでした.")]
        [MaxLength(500)]
        public string ActionAbility { get; set; }
        [Required(ErrorMessage = "あなたは三番解答まだ入力しませんでした.")]
        [MaxLength(500)]
        public string DemonstratedAbility { get; set; }
        [Required(ErrorMessage = "あなたは四番解答まだ入力しませんでした.")]
        [MaxLength(500)]
        public string SelfDevelopment { get; set; }
        [Required(ErrorMessage = "あなたは五番解答まだ入力しませんでした.")]
        [MaxLength(500)]
        public string ThinkingAbility { get; set; }
        public int CourseCurrentId { get; set; }
        public int StatusId { get; set; }
    }
}
