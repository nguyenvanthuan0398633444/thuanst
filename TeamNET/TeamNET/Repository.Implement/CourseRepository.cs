using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using TeamNET.Models.Respone.Course;
using TeamNET.Repository.Interface;

namespace TeamNET.Repository.Implement
{
    public class CourseRepository : BaseRepository, ICourseRepository
    {
        public async Task<IEnumerable<CourseView>> Gets(string studentId)
        {
            var result = new List<CourseView>();
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Id", studentId);
                string querySQL = "select distinct  CO.\"CourseId\", " +
                                                   "CO.\"CourseName\" " +
                                "from public.\"UserCourseDetails\" as UCD inner join public.\"Courses\" as CO on UCD.\"CourseId\" = CO.\"CourseId\" " +
                                                                        "inner join public.\"EventContents\" as EC on EC.\"CourseCurrentId\" = UCD.\"CourseCurrentId\" " +
                                "where EC.\"StudentId\" = @Id " +
                                "order by CO.\"CourseId\" ";
                return await SqlMapper.QueryAsync<CourseView>(cnn: connection,
                                                                sql: querySQL,
                                                                param: parameters,
                                                                commandType: CommandType.Text);
            }
            catch
            {
                return result;
            }
        }
    }
}
