using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamNET.Models.Entity;
using TeamNET.Models.Respone;
using TeamNET.Repository.Interface;
using TeamNET.Service.Interface;
using TeamNET.ViewModels.EventContent;

namespace TeamNET.Service.Implement
{
    public class EventContentService : IEventContentService
    {
        private readonly IEventContentRepository eventContentRepository;
        private readonly INotificationRepository notificationRepository;
        private readonly IAbilityRepository abilityRepository;

        public EventContentService(IEventContentRepository eventContentRepository,
                                    INotificationRepository notificationRepository,
                                    IAbilityRepository abilityRepository)
        {
            this.eventContentRepository = eventContentRepository;
            this.notificationRepository = notificationRepository;
            this.abilityRepository = abilityRepository;
        }

        public async Task<ResultRequest> ChangeStatus(int id, int statusId)
        {
            return await eventContentRepository.ChangeStatus(id, statusId);
        }

        public async Task<ResultRequest> Delete(int id)
        {
            var delEventContent = await eventContentRepository.Delete(id);
            if (delEventContent.IsSuccess)
            {
                return await abilityRepository.DeleteAbilityEventContent(id); 
            }
            return delEventContent;
        }

        public EventContentViewModel Get(int id)
        {
            return eventContentRepository.Get(id);
        }

        public async Task<ResultRequest> Register(EventContentViewModel model)
        {
            return await eventContentRepository.Register(model);
        }

        public async Task<ResultRequest> Update(EventContentViewModel model)
        {
            return await eventContentRepository.Update(model);
        }
        public async Task<ResultRequest> ChangeStatusActive(EventContentViewModel model, List<string> roles)
        {
            if (model.StatusId == 1 && roles.Contains("Doctor"))
            {
                return await eventContentRepository.ChangeStatus(model.EventContentId, 2);
            }
            return new ResultRequest();
        }

        public async Task<ResultRequest> ResetNotification(string userId, int eventContentId)
        {
            return await notificationRepository.ResetNotification(userId, eventContentId);
        }

        public async Task<string> UserIdsEventContent(int eventContentId)
        {
            return await eventContentRepository.UserIdsEventContent(eventContentId);
        }
    }
}
