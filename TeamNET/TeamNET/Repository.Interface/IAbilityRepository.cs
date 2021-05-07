using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamNET.Models.Request.EventContent;
using TeamNET.Models.Respone;
using TeamNET.Models.Respone.Ability;

namespace TeamNET.Repository.Interface
{
    public interface IAbilityRepository
    {
        Task<List<AbilityView>> Gets();
        Task<int> SaveAbility(int eventContendId, string Ability);
        Task<ResultRequest> CreateEventContentAbility(SaveEventContentAbility request);
        Task<IEnumerable<AbilityView>> Gets(string studentId);
        Task<ResultRequest> DeleteAbilityEventContent(int eventContentId);
    }
}
