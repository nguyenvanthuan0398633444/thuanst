using Dapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using TeamNET.Models;
using TeamNET.Models.Entity;
using TeamNET.Models.Respone;
using TeamNET.Models.Respone.Event;
using TeamNET.Repository.Interface;
using TeamNET.ViewModels.EventContent;

namespace TeamNET.Repository.Implement
{
    public class EventContentRepository : BaseRepository, IEventContentRepository
    {
        private readonly OJTDbContext context;

        public EventContentRepository(OJTDbContext context)
        {
            this.context = context;
        }
        public async Task<ResultRequest> Register(EventContentViewModel model)
        {
            var result = new ResultRequest()
            {
                IsSuccess = false,
                Message = "問題が発生しました。管理者に連絡してください.",
            };
            try
            {
                var ev = new EventContent() { 
                    EventId = model.EventId,
                    StudentId = model.StudentId,
                    CommunityAbility = model.CommunityAbility,
                    ActionAbility = model.ActionAbility,
                    DemonstratedAbility = model.DemonstratedAbility,
                    SelfDevelopment = model.SelfDevelopment,
                    ThinkingAbility = model.ThinkingAbility,
                    CourseCurrentId = model.CourseCurrentId,
                    StatusId = 1
                };
                await context.EventContents.AddAsync(ev);
                result.IsSuccess = await context.SaveChangesAsync() > 0 ? true : false;
                if (result.IsSuccess)
                {
                    var eventContent = await (from evc in context.EventContents
                                        where evc.StudentId == model.StudentId
                                        orderby evc.EventContentId descending
                                        select evc.EventContentId).FirstOrDefaultAsync();
                    var resCreateNotification = await CreateNotification(eventContent);
                    if (resCreateNotification.IsSuccess)
                    {
                        
                    result.Message = "新エベントを作成するのは成功です";
                    }
                    else
                    {
                        result.IsSuccess = false;
                    }
                }
                else
                {
                    result.Message = "新エベントを作成するのは成功しないでした";
                }
                return result;
            }
            catch
            {
                return result;
            }
        }
        public EventContentViewModel Get(int id)
        {
            var ev = (from evc in context.EventContents
                      where evc.EventContentId == id
                      select new EventContentViewModel()
                      {
                          EventContentId = evc.EventContentId,
                          EventId = evc.EventId,
                          StudentId = evc.StudentId,
                          CommunityAbility = evc.CommunityAbility,
                          ActionAbility = evc.ActionAbility,
                          DemonstratedAbility = evc.DemonstratedAbility,
                          SelfDevelopment = evc.SelfDevelopment,
                          ThinkingAbility = evc.ThinkingAbility,
                          CourseCurrentId = evc.CourseCurrentId,
                          StatusId = evc.StatusId
                      }).FirstOrDefault();
            return ev;
        }
        public async Task<ResultRequest> Update(EventContentViewModel model)
        {
            var result = new ResultRequest()
            {
                IsSuccess = false,
                Message = "問題が発生しました。管理者に連絡してください.",
            };
            try
            {
                var editEvent = context.EventContents.Find(model.EventContentId);
                if(editEvent.StatusId == 3 || editEvent.StatusId == 4)
                {
                    result.Message = "イベントコンテンツは改変しないでした";
                    return result;
                }
                editEvent.EventId = model.EventId;
                editEvent.CommunityAbility = model.CommunityAbility;
                editEvent.ActionAbility = model.ActionAbility;
                editEvent.DemonstratedAbility = model.DemonstratedAbility;
                editEvent.SelfDevelopment = model.SelfDevelopment;
                editEvent.ThinkingAbility = model.ThinkingAbility;
                result.IsSuccess = await context.SaveChangesAsync() > 0 ? true : false;
                if (result.IsSuccess)
                {
                    result.Message = "エベントを更新するのは成功です";
                }
                else
                {
                    result.Message = "イベントコンテンツは改変しないでした";
                }
                return result;
            }
            catch
            {
                return result;
            }
        }
        public async Task<ResultRequest> ChangeStatus(int id, int statusId)
        {
            var result = new ResultRequest()
            {
                IsSuccess = false,
                Message = "問題が発生しました。管理者に連絡してください.",
            };
            try
            {
                var delEvent = context.EventContents.Find(id);
              
                delEvent.StatusId = statusId;
                result.IsSuccess = await context.SaveChangesAsync() > 0 ? true : false;
                if (result.IsSuccess)
                {
                    result.Message = "アクションは成功でした";
                }
                else
                {
                    result.Message = "アクションは成功しないでした";
                }
                return result;
            }
            catch
            {
                return result;
            }
        }
        public async Task<ResultRequest> Delete(int id)
        {
            var result = new ResultRequest()
            {
                IsSuccess = false,
                Message = "問題が発生しました。管理者に連絡してください.",
            };
            try
            {
                var delEvent = context.EventContents.Find(id);
                delEvent.StatusId = 4;
                result.IsSuccess = await context.SaveChangesAsync() > 0 ? true : false;
                if (result.IsSuccess)
                {
                    result.Message = "エベントを削除のは成功です";
                }
                else
                {
                    result.Message = "エベントを削除のはしないでした";
                }
                return result;
            }
            catch
            {
                return result;
            }
        }
        public async Task<ResultRequest> CreateNotification(int eventContentId)
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
                string querySQL = "call create_notification(@eventContentId);";
                await SqlMapper.QueryAsync(cnn: connection,
                                            sql: querySQL,
                                            param: parameters,
                                            commandType: CommandType.Text);
                result.IsSuccess = true;
                result.Message = "通知を作成するのは成功です";
                return result;
            }
            catch
            {
                return result;
            }
        }
        public async Task<string> UserIdsEventContent(int eventContentId)
        {
            var result = "";
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@eventContentId", eventContentId);
                string querySQL = "select get_user_id_event_content(@eventContentId);";
                result = await SqlMapper.QueryFirstOrDefaultAsync<string>(cnn: connection,
                                            sql: querySQL,
                                            param: parameters,
                                            commandType: CommandType.Text);

                return result;
            }
            catch
            {
                return result;
            }
        }
    }
}
