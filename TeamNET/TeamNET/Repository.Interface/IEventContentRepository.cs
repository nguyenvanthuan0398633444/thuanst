using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamNET.Models.Respone;
using TeamNET.ViewModels.EventContent;

namespace TeamNET.Repository.Interface
{
    public interface IEventContentRepository
    {
        Task<ResultRequest> Register(EventContentViewModel model);
        EventContentViewModel Get(int id);
        Task<ResultRequest> Update(EventContentViewModel model);
        Task<ResultRequest> Delete(int id);
        Task<ResultRequest> ChangeStatus(int id, int statusId);
        Task<string> UserIdsEventContent(int eventContentId);
    }
}
