using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamNET.Models.Request.EventContent;
using TeamNET.Models.Respone;
using TeamNET.Models.Respone.Ability;
using TeamNET.Repository.Interface;
using TeamNET.Service.Interface;

namespace TeamNET.Service.Implement
{
    public class AbilityService : IAbilityService
    {
        private readonly IAbilityRepository abilityRepository;

        public AbilityService(IAbilityRepository abilityRepository)
        {
            this.abilityRepository = abilityRepository;
        }

        public async Task<List<AbilityView>> Gets()
        {
            return await abilityRepository.Gets();
        }

        public async Task<int> SaveAbility(int eventContendId, string Ability)
        {
            return await abilityRepository.SaveAbility(eventContendId, Ability);
        }
        public async Task<ResultRequest> CreateEventContentAbility(SaveEventContentAbility request)
        {
            return await abilityRepository.CreateEventContentAbility(request);
        }

        public async Task<IEnumerable<AbilityView>> Gets(string studentId)
        {
            return await abilityRepository.Gets(studentId);
        }

    }
}
