using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using TeamNET.Models.Respone.Ability;
using TeamNET.Models.Respone.Event;
using TeamNET.Models.Respone.Student;
using TeamNET.Models.Respone.Tracking;
using TeamNET.Repository.Interface;

namespace TeamNET.Repository.Implement
{
    public class TrackingChartRepository : BaseRepository, ITrackingChartRepository
    {
        public async Task<IEnumerable<AbilityView>> ShowAbility()
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                var querySQL = "SELECT A.\"AbilityName\", A.\"Color\", A.\"AbilityId\" FROM public.\"Abilities\" AS A " +
                    "ORDER BY A.\"AbilityId\"";
                var result = await SqlMapper.QueryAsync<AbilityView>(cnn: connection,
                                                        sql: querySQL,
                                                        param: parameters,
                                                        commandType: CommandType.Text);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<IEnumerable<TrackingEvent>> ShowEventChartDoughnut(string studentId, string abilityName)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@studentId", studentId);
                parameters.Add("@abilityName", abilityName);
                var querySQL = "SELECT E.\"EventName\", EC.\"EventContentId\" FROM public.\"EventContentAbilities\" AS ECA " +
                               "JOIN public.\"EventContents\" AS EC ON EC.\"EventContentId\" = ECA.\"EventContentId\" " +
                               "JOIN public.\"Events\" AS E ON E.\"EventId\" = EC.\"EventId\" " +
                               "JOIN public.\"Abilities\" AS A ON A.\"AbilityId\" = ECA.\"AbilityId\" " +
                               "WHERE EC.\"StudentId\" = @studentId AND A.\"AbilityName\" = @abilityName " +
                               "ORDER BY EC.\"EventContentId\" DESC";

                var result = await SqlMapper.QueryAsync<TrackingEvent>(cnn: connection,
                                                        sql: querySQL,
                                                        param: parameters,
                                                        commandType: CommandType.Text);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public async Task<IEnumerable<TrackingEvent>> ShowEventChartBar(string studentId, string abilityName, string courseName)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@studentId", studentId);
                parameters.Add("@abilityName", abilityName);
                parameters.Add("@courseName", courseName);
                var querySQL = "SELECT E.\"EventName\", EC.\"EventContentId\" FROM public.\"EventContentAbilities\" AS ECA " +
                               "JOIN public.\"EventContents\" AS EC ON EC.\"EventContentId\" = ECA.\"EventContentId\" " +
                               "JOIN public.\"Events\" AS E ON E.\"EventId\" = EC.\"EventId\" " +
                               "JOIN public.\"Abilities\" AS A ON A.\"AbilityId\" = ECA.\"AbilityId\" " +
                               "JOIN public.\"UserCourseDetails\" AS UCD ON EC.\"CourseCurrentId\" = UCD.\"CourseCurrentId\" " +
                               "JOIN public.\"Courses\" AS CO ON CO.\"CourseId\" = UCD.\"CourseId\" " +
                               "WHERE EC.\"StudentId\" = @studentId AND A.\"AbilityName\" = @abilityName AND CO.\"CourseName\" = @courseName " +
                               "ORDER BY EC.\"EventContentId\" DESC";

                var result = await SqlMapper.QueryAsync<TrackingEvent>(cnn: connection,
                                                        sql: querySQL,
                                                        param: parameters,
                                                        commandType: CommandType.Text);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public async Task<StudentInfoViewChart> StudentInfo(string studentId)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@studentId", studentId);
                var querySQL = "SELECT U.\"FullName\", U.\"StudentCode\", U.\"AvatarName\", " +
                                "CO.\"CourseName\" AS \"CourseCurrentName\" " +
                               "FROM public.\"UserCourseDetails\" AS UCD INNER JOIN public.\"Courses\" AS CO " +
                               "ON UCD.\"CourseId\" = CO.\"CourseId\" " +
                               "INNER JOIN public.\"AspNetUsers\" AS U ON UCD.\"CourseCurrentId\" = U.\"CourseCurrentId\" " +
                               "WHERE U.\"Id\" = @studentId";
                var result = await SqlMapper.QueryFirstOrDefaultAsync<StudentInfoViewChart>(cnn: connection,
                                                        sql: querySQL,
                                                        param: parameters,
                                                        commandType: CommandType.Text);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<TrackingChart>> TrackingByStudentId(string studentId)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@studentId", studentId);
                var querySQL = "SELECT COUNT(Ab.\"AbilityName\"), Ab.\"AbilityName\", C.\"CourseName\", Ab.\"Color\", Ab.\"AbilityId\" FROM public.\"EventContents\" AS EC " +
                    "JOIN public.\"EventContentAbilities\" AS ECA ON EC.\"EventContentId\" = ECA.\"EventContentId\" " +
                    "JOIN public.\"Abilities\" AS Ab ON ECA.\"AbilityId\" = Ab.\"AbilityId\" " +
                    "JOIN public.\"UserCourseDetails\" AS UCD ON EC.\"CourseCurrentId\" = UCD.\"CourseCurrentId\" " +
                    "JOIN public.\"Courses\" AS C ON UCD.\"CourseId\" = C.\"CourseId\" " +
                    "WHERE EC.\"StudentId\" = @studentId " +
                    "GROUP BY Ab.\"AbilityName\", C.\"CourseName\", Ab.\"Color\", Ab.\"AbilityId\" " +
                    "ORDER BY Ab.\"AbilityId\"";

                var result = await SqlMapper.QueryAsync<TrackingChart>(cnn: connection,
                                                        sql: querySQL,
                                                        param: parameters,
                                                        commandType: CommandType.Text);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<TrackingChart>> TrackingDoughnutByStudentId(string studentId)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@studentId", studentId);
                var querySQL = "SELECT COUNT(Ab.\"AbilityName\"), Ab.\"AbilityName\", Ab.\"Color\" FROM public.\"EventContents\" AS EC " +
                    "JOIN public.\"Events\" AS E ON EC.\"EventId\" = E.\"EventId\" " +
                    "JOIN public.\"AspNetUsers\" AS ANU ON EC.\"StudentId\" = ANU.\"Id\" " +
                    "JOIN public.\"EventContentAbilities\" AS ECA ON EC.\"EventContentId\" = ECA.\"EventContentId\" " +
                    "JOIN public.\"Abilities\" AS Ab ON ECA.\"AbilityId\" = Ab.\"AbilityId\" " +
                    "WHERE ANU.\"Id\" = @studentId " +
                    "GROUP BY Ab.\"AbilityName\", Ab.\"Color\"" +
                    "ORDER BY Ab.\"AbilityName\"";


                var result = await SqlMapper.QueryAsync<TrackingChart>(cnn: connection,
                                                        sql: querySQL,
                                                        param: parameters,
                                                        commandType: CommandType.Text);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
