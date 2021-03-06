using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamNET.Models.Request.EventContent;
using TeamNET.Models.Respone;
using TeamNET.Models.Respone.Ability;

namespace TeamNET.Service.Interface
{
    public interface IAbilityService
    {
        Task<ResultRequest> CreateEventContentAbility(SaveEventContentAbility request);
        Task<IEnumerable<AbilityView>> Gets(string studentId);
        Task<int> SaveAbility(int eventContendId, string Ability);
        Task<List<AbilityView>> Gets();

    }
}
