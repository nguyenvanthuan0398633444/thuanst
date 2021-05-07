using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamNET.Models.Respone;

namespace TeamNET.Repository.Interface
{
    public interface INotificationRepository
    {
        Task<ResultRequest> ResetNotification(string userId, int eventContentId);
        Task<ResultRequest> PlusNotification(string userId, int eventContentId);
    }
}
