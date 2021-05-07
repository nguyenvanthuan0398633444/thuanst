using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using TeamNET.Models;
using TeamNET.Models.Entity;
using TeamNET.Models.Request.Student;
using TeamNET.Models.Respone;
using TeamNET.Models.Respone.Ability;
using TeamNET.Models.Respone.Course;
using TeamNET.Models.Respone.Event;
using TeamNET.Models.Respone.EventContent;
using TeamNET.Models.Respone.Student;
using TeamNET.Repository.Interface;

namespace TeamNET.Repository.Implement
{
    public class StudentRepository : BaseRepository, IStudentRepository
    {
        private readonly OJTDbContext context;

        public StudentRepository(OJTDbContext context)
        {
            this.context = context;
        }
        public async Task<List<AbilityView>> Abilities(string userId, int courseCurrentId)
        {
            var Abilities = (from ec in context.EventContents
                             where ec.StudentId == userId && ec.CourseCurrentId == courseCurrentId
                             join eca in context.EventContentAbilities on ec.EventContentId equals eca.EventContentId
                             join a in context.Abilities on eca.AbilityId equals a.AbilityId
                             select (new AbilityView()
                             {
                                 AbilityId = a.AbilityId,
                                 AbilityName = a.AbilityName,
                                 Color = a.Color
                             })).Distinct();
            return await Abilities.OrderBy(e=> e.AbilityId).ToListAsync();
        }
        public async Task<CourseView> Course(int courseCurrentId)
        {
            var course = context.Courses.Where(e => e.CourseId == courseCurrentId).FirstOrDefault();
            return await Task.FromResult(new CourseView() { CourseId = course.CourseId, CourseName = course.CourseName });
        }

        public async Task<List<EventView>> Events(string userId, int courseCurrentId)
        {
            var Events = (from ec in context.EventContents
                          where ec.StudentId == userId && ec.CourseCurrentId == courseCurrentId
                          join e in context.Events on ec.EventId equals e.EventId
                          select (new EventView()
                          {
                              EventId = e.EventId,
                              EventName = e.EventName,
                              Icon = e.Icon
                          })).Distinct();
            return await Events.ToListAsync();
        }

        public async Task<IEnumerable<EventContentView>> SearchStudentEvent(ReqSearchEvent request)
        {
            var result = new List<EventContentView>();
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@studentId", request.StudentId);
                parameters.Add("@courseId", request.CourseId);
                parameters.Add("@eventId", request.EventId);
                parameters.Add("@userCurrentId", request.UserCurrentId);
                string querySQL = "select 	EC.\"EventContentId\", " +
                                            "EC.\"CourseCurrentId\", " +
                                            "(select CR.\"CourseName\" from public.\"Courses\" as CR inner join public.\"UserCourseDetails\" as UCD on CR.\"CourseId\" = UCD.\"CourseId\" " +
                                            "where UCD.\"CourseCurrentId\" = EC.\"CourseCurrentId\" limit 1) as \"CourseName\", " +
                                            "EC.\"EventId\", " +
                                            "(select E.\"EventName\" from public.\"Events\" as E where E.\"EventId\" = EC.\"EventId\" limit 1) as \"EventName\", " +
                                            "(select E.\"Icon\" from public.\"Events\" as E where E.\"EventId\" = EC.\"EventId\" limit 1) as \"EventIcon\", " +
                                            "EC.\"StatusId\", " +
                                            "(select W.\"StatusName\" from public.\"Wikis\" as W where W.\"TableId\" = 1 and W.\"StatusId\" = EC.\"StatusId\" limit 1) as \"StatusName\", " +
                                            "(select NE.\"Notification\" " +
                                                "from public.\"NotificationEventContents\" as NE " +
                                                "where NE.\"EventContentId\" = EC.\"EventContentId\" and NE.\"UserId\" = @userCurrentId " +
                                                "limit 1) as \"CountNotification\" " +
                                            "from public.\"EventContents\" as EC " +
                                            "where EC.\"StudentId\" = @studentId and EC.\"StatusId\" <> 4 ";
                if (request.CourseId > 0)
                {
                    querySQL += "and EC.\"CourseCurrentId\" = @courseId ";
                }
                if (request.EventId > 0)
                {
                    querySQL += "and EC.\"EventId\" = @eventId ";
                }
                if (request.Statuses.Count > 0)
                {
                    if(request.Statuses.Count == 1)
                    {
                        querySQL += " and EC.\"StatusId\" = " + request.Statuses[0];
                    }
                    else
                    {
                        querySQL += " and ( EC.\"StatusId\" = " + request.Statuses[0];
                        for (var i = 1; i < request.Statuses.Count; i++)
                        {
                            querySQL += " or EC.\"StatusId\" = " + request.Statuses[i];
                        }
                        querySQL += " )";
                    }
                }
                querySQL += "order by EC.\"EventContentId\" desc";
                return await SqlMapper.QueryAsync<EventContentView>(cnn: connection,
                                                        sql: querySQL,
                                                        param: parameters,
                                                        commandType: CommandType.Text);
            }
            catch
            {
                return result;
            }
        }
        public async Task<StudentView> GetInfoStudent(string studentId)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Id", studentId);
                string querySQL = "select 	 ANU.\"Id\" as \"UserId\" " +
                                            ",ANU.\"FullName\" as \"StudentName\" " +
                                            ",ANU.\"StudentCode\" as \"StudentCode\" " +
                                            ",ANU.\"CourseCurrentId\" as \"CourseCurrentId\" " +
                                            ",CO.\"CourseName\" as \"CourseName\" " +
                                    "from public.\"UserCourseDetails\" as UCD inner join public.\"AspNetUsers\" as ANU " +
                                                                        "on UCD.\"CourseCurrentId\" = ANU.\"CourseCurrentId\" " +
                                                                            "inner join public.\"Courses\" as CO " +
                                                                        "on UCD.\"CourseId\" = CO.\"CourseId\" " +
                                    "where ANU.\"Id\" = @Id ";
                var result = await SqlMapper.QueryFirstOrDefaultAsync<StudentView>(cnn: connection,
                                                                                sql: querySQL,
                                                                                param: parameters,
                                                                                commandType: CommandType.Text);
                return result;
            }
            catch 
            {
                return new StudentView();
            }
        }
        public async Task<IEnumerable<StudentDetailsView>> Get(string studentId, string userCurentId)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Id", studentId);
                parameters.Add("@userCurentId", userCurentId);
                string querySQL = "select 	EC.\"EventContentId\", " +
                                            "EC.\"CourseCurrentId\", " +
                                            "(select CR.\"CourseName\" from public.\"Courses\" as CR inner join public.\"UserCourseDetails\" as UCD on CR.\"CourseId\" = UCD.\"CourseId\" " +
                                            "where UCD.\"CourseCurrentId\" = EC.\"CourseCurrentId\" limit 1) as \"CourseName\", " +
                                            "EC.\"EventId\", " +
                                            "(select E.\"EventName\" from public.\"Events\" as E where E.\"EventId\" = EC.\"EventId\" limit 1) as \"EventName\", " +
                                            "(select E.\"Icon\" from public.\"Events\" as E where E.\"EventId\" = EC.\"EventId\" limit 1) as \"EventIcon\", " +
                                            "EC.\"StatusId\", " +
                                            "(select W.\"StatusName\" from public.\"Wikis\" as W where W.\"TableId\" = 1 and W.\"StatusId\" = EC.\"StatusId\" limit 1) as \"StatusName\", " +
                                            "(select NE.\"Notification\" " +
                                                "from public.\"NotificationEventContents\" as NE " +
                                                "where NE.\"EventContentId\" = EC.\"EventContentId\" and NE.\"UserId\" = @userCurentId " +
                                                "limit 1) as \"CountNotification\" " +
                                            "from public.\"AspNetUsers\" as ANU " +
                                            "INNER JOIN public.\"EventContents\" AS EC ON EC.\"StudentId\" = ANU.\"Id\" " +
                                            "where ANU.\"Id\" = @Id and EC.\"StatusId\" <> 4 " +
                                            "order by EC.\"EventContentId\" desc";
                var result = await SqlMapper.QueryAsync<StudentDetailsView>(cnn: connection,
                                                                                sql: querySQL,
                                                                                param: parameters,
                                                                                commandType: CommandType.Text);
                return result;
            }
            catch 
            {
                return new List<StudentDetailsView>();
            }
        }
        public async Task<List<StudentView>> GetstudentbyRole(string roleName, string UserId)
        {
            List<StudentView> Students = new List<StudentView>();
            if (roleName == "Guardian")
            {
                Students = await (from u in context.Users
                                  where u.StudentCode != null && u.GuardianId == UserId
                                  join ec in context.EventContents on u.Id equals ec.StudentId into user
                                  from ec1 in user.DefaultIfEmpty()
                                  join ucd in context.UserCourseDetails on ec1.CourseCurrentId equals ucd.CourseCurrentId
                                  join c in context.Courses on ucd.CourseId equals c.CourseId
                                  select (new StudentView()
                                  {
                                      UserId = u.Id,
                                      StudentCode = u.StudentCode,
                                      StudentName = u.FullName,
                                      CourseCurrentId = u.CourseCurrentId
                                  })).Distinct().ToListAsync();
            }
            else if (roleName == "Teacher")
            {
                var Student = await (from u in context.Users
                                     where u.StudentCode != null
                                     join ec in context.EventContents on u.Id equals ec.StudentId into user
                                     from ec1 in user.DefaultIfEmpty()
                                     join ucd in context.UserCourseDetails on ec1.CourseCurrentId equals ucd.CourseCurrentId
                                     join c in context.Courses on ucd.CourseId equals c.CourseId
                                     select (new StudentView()
                                     {
                                         UserId = u.Id,
                                         StudentCode = u.StudentCode,
                                         StudentName = u.FullName,
                                         CourseCurrentId = u.CourseCurrentId,
                                         User = ucd.TeacherId
                                     })).Distinct().ToListAsync();

                foreach (var item in Student)
                {
                    if (item.User == UserId)
                    {
                        Students.Add(item);
                    }
                }
            }
            else if (roleName == "Doctor")
            {
                var Student = await (from u in context.Users
                                     where u.StudentCode != null
                                     join ec in context.EventContents on u.Id equals ec.StudentId into user
                                     from ec1 in user.DefaultIfEmpty()
                                     join ucd in context.UserCourseDetails on ec1.CourseCurrentId equals ucd.CourseCurrentId
                                     join c in context.Courses on ucd.CourseId equals c.CourseId
                                     select (new StudentView()
                                     {
                                         UserId = u.Id,
                                         StudentCode = u.StudentCode,
                                         StudentName = u.FullName,
                                         CourseCurrentId = u.CourseCurrentId,
                                         User = ucd.DoctorId
                                     })).Distinct().ToListAsync();

                foreach (var item in Student)
                {
                    if (item.User == UserId)
                    {
                        Students.Add(item);
                    }
                }
            }
            return Students.OrderBy(e => e.StudentCode).ToList();
        }
        public async Task<List<StudentView>> Students(string UserId)
        {
            var roleId = context.UserRoles.Where(e => e.UserId == UserId).FirstOrDefault().RoleId;
            var roleName = context.Roles.Where(e => e.Id == roleId).FirstOrDefault().Name;
            var Students = await GetstudentbyRole(roleName, UserId);

            return Students;
        }

        public async Task<List<StudentView>> StudentsConditions(string UserId, string studentName, int EventId, string Ability, int CourseId)
        {
            List<StudentView> StudentList = new List<StudentView>();
            if (studentName != "!!!!!")
            {

                var roleId = context.UserRoles.Where(e => e.UserId == UserId).FirstOrDefault().RoleId;
                var roleName = context.Roles.Where(e => e.Id == roleId).FirstOrDefault().Name;
                var Students = await GetstudentbyRole(roleName, UserId);
                foreach (var item in Students)
                {
                    if (studentName == null)
                        studentName = " ";
                    if (item.StudentName.ToLower().Contains(studentName.Trim().ToLower()))
                        StudentList.Add(item);
                }
            }
            else
            {
                var roleId = context.UserRoles.Where(e => e.UserId == UserId).FirstOrDefault().RoleId;
                var roleName = context.Roles.Where(e => e.Id == roleId).FirstOrDefault().Name;
                var Students = await GetstudentbyRole(roleName, UserId);
                foreach (var item in Students)
                {
                    StudentList.Add(item);
                }
            }
            //Events
            List<StudentView> results = new List<StudentView>();
            if (EventId != 0)
            {
                foreach (var item in StudentList)
                {
                    var Events = await (from ec in context.EventContents
                                        where ec.StudentId == item.UserId && ec.CourseCurrentId == item.CourseCurrentId
                                        join e in context.Events on ec.EventId equals e.EventId
                                        select (new EventView()
                                        {
                                            EventId = e.EventId,
                                            EventName = e.EventName,
                                            Icon = e.Icon
                                        })).Distinct().ToListAsync();
                    foreach (var event1 in Events)
                    {
                        if (event1.EventId == EventId)
                        {
                            results.Add(item);
                            break;
                        }
                    }
                }
            }
            else
            {
                foreach (var item in StudentList)
                {
                    results.Add(item);
                }
            }
            //Ability
            List<StudentView> resultAbi = new List<StudentView>();
            if (Ability != "!!!!!")
            {
                foreach (var item in results)
                {
                    var Abilitie = await Abilities(item.UserId, item.CourseCurrentId);

                    var Abilitis = new List<AbilityView>();
                    var check = "";
                    var index = 0;
                    foreach (var item1 in Abilitie)
                    {
                        if (index == 0)
                        {
                            check = item1.AbilityId.ToString();
                            index++;
                        }
                        else
                            check += "," + item1.AbilityId;
                    }

                    if (check.Contains(Ability))
                    {
                        resultAbi.Add(item);
                    }
                }
            }
            else
            {
                foreach (var item in results)
                {
                    resultAbi.Add(item);
                }
            }
            //Course
            List<StudentView> resultCourse = new List<StudentView>();
            if (CourseId != 0)
            {
                foreach (var item in resultAbi)
                {
                    var tam = await Task.FromResult(context.UserCourseDetails.FirstOrDefault(e => e.CourseId == CourseId && item.CourseCurrentId == e.CourseCurrentId));
                    if (tam != null)
                    {
                        resultCourse.Add(item);
                    }
                }
            }
            else
            {
                foreach (var item in resultAbi)
                {
                    resultCourse.Add(item);
                }
            }
            return resultCourse;
        }
    }
}