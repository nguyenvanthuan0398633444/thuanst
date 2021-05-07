using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using TeamNET.Models.Respone;
using TeamNET.Repository.Interface;

namespace TeamNET.Repository.Implement
{
    public class NotificationRepository : BaseRepository ,INotificationRepository
    {
        public async Task<ResultRequest> ResetNotification(string userId, int eventContentId)
        {
            var result = new ResultRequest()
            {
                IsSuccess = false,
                Message = "問題が発生しました。管理者に連絡してください.",
            };
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@userId", userId);
                parameters.Add("@eventContentId", eventContentId);
                string querySQL = "UPDATE public.\"NotificationEventContents\" as NEC " +
                                    "SET \"Notification\" = 0 " +
                                    "WHERE NEC.\"UserId\" = @userId and NEC.\"EventContentId\" = @eventContentId ";
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
        public async Task<ResultRequest> PlusNotification(string userId, int eventContentId)
        {
            var result = new ResultRequest()
            {
                IsSuccess = false,
                Message = "問題が発生しました。管理者に連絡してください.",
            };
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@userId", userId);
                parameters.Add("@eventContentId", eventContentId);
                string querySQL = "UPDATE public.\"NotificationEventContents\" as NEC " +
                                    "SET \"Notification\" = \"Notification\" + 1 " +
                                    "WHERE NEC.\"UserId\" <> @userId and NEC.\"EventContentId\" = @eventContentId ";
                await SqlMapper.QueryAsync(cnn: connection,
                                            sql: querySQL,
                                            param: parameters,
                                            commandType: CommandType.Text);
                result.IsSuccess = true;
                result.Message = "エベントをプラスのは成功です";
                return result;
            }
            catch
            {
                return result;
            }
        }
    }
}
