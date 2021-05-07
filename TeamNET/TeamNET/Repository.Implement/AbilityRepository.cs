using Dapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using TeamNET.Models;
using TeamNET.Models.Entity;
using TeamNET.Models.Request.EventContent;
using TeamNET.Models.Respone;
using TeamNET.Models.Respone.Ability;
using TeamNET.Repository.Interface;

namespace TeamNET.Repository.Implement
{
    public class AbilityRepository : BaseRepository, IAbilityRepository
    {
        private readonly OJTDbContext context;

        public AbilityRepository(OJTDbContext context)
        {
            this.context = context;
        }

        public async Task<List<AbilityView>> Gets()
        {
            var ability = await context.Abilities.OrderBy(e => e.AbilityId).ToListAsync();
            var result = new List<AbilityView>();
            foreach (var item in ability)
            {
                var tam = new AbilityView()
                {
                    AbilityId = item.AbilityId,
                    AbilityName = item.AbilityName,
                    Color = item.Color
                };
                result.Add(tam);
            }
            return result;
        }

        public async Task<int> SaveAbility(int eventContendId, string Ability)
        {
            var abilities = await context.EventContentAbilities.Where(e => e.EventContentId == eventContendId).ToArrayAsync();
            foreach(var item in abilities)
            {
                context.EventContentAbilities.Remove(item);
            }
            await context.SaveChangesAsync();
            if(Ability != "0")
            {
                var temporary = Ability.Split(",");
                temporary = temporary.Distinct().ToArray();
                foreach (var item in temporary)
                {
                    var temporary1 = new EventContentAbility()
                    {
                        AbilityId = Int32.Parse(item),
                        EventContentId = eventContendId
                    };
                    context.EventContentAbilities.Add(temporary1);
                }
            }
            
            return await context.SaveChangesAsync();
        }
        public async Task<ResultRequest> CreateEventContentAbility(SaveEventContentAbility request)
        {
            var result = new ResultRequest()
            {
                IsSuccess = false,
                Message = "問題が発生しました。管理者に連絡してください.",
            };
            try
            {
               if(request.EventContentAbilities.Count < 1)
                {
                    result.IsSuccess = false;
                    result.Message = "能力のデータはありません";
                    return result;
                }
                var eventContentId = request.EventContentAbilities[0].EventContentId;
                var ev = await context.EventContents.FindAsync(eventContentId);
                ev.EventContentAbilities = request.EventContentAbilities;
                result.IsSuccess = await context.SaveChangesAsync() > 0 ? true : false;
                if (result.IsSuccess)
                {
                    result.Message = "中身のエベントに新能力を作成するのは成功です";
                }
                else
                {
                    result.Message = "中身のエベントに新能力を作成するのは成功しないです";
                }
                return result;
            }
            catch
            {
                return result;
            }
        }
        public async Task<IEnumerable<AbilityView>> Gets(string studentId)
        {
            var result = new List<AbilityView>();
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Id", studentId);
                string querySQL = "select distinct AB.\"AbilityId\", " +
                                                "AB.\"AbilityName\" " +
                                    "from public.\"EventContentAbilities\" as ECA inner join public.\"Abilities\" as AB on ECA.\"AbilityId\" = AB.\"AbilityId\" " +
                                                                                "inner join public.\"EventContents\" as EC on EC.\"EventContentId\" = ECA.\"EventContentId\" " +
                                    "where EC.\"StudentId\" = @Id " +
                                    "order by AB.\"AbilityId\" ";
                return await SqlMapper.QueryAsync<AbilityView>(cnn: connection,
                                                                sql: querySQL,
                                                                param: parameters,
                                                                commandType: CommandType.Text);
            }
            catch
            {
                return result;
            }
        }
        public async Task<ResultRequest> DeleteAbilityEventContent(int eventContentId)
        {
            var result = new ResultRequest()
            {
                IsSuccess = false,
                Message = "問題が発生しました。管理者に連絡してください.",
            };
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@eventContentId", eventContentId);
                string querySQL = "DELETE FROM public.\"EventContentAbilities\" " +
                                    "WHERE \"EventContentId\" = @eventContentId ";
                await SqlMapper.QueryAsync(cnn: connection,
                                            sql: querySQL,
                                            param: parameters,
                                            commandType: CommandType.Text);
                result.IsSuccess = true;
                result.Message = "エベントをリセットのは成功です";
                return result;
            }
            catch
            {
                return result;
            }
        }

    }
}
