using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamNET.Models.Request.Student;
using TeamNET.Models.Respone;
using TeamNET.Models.Respone.Ability;
using TeamNET.Models.Respone.Course;
using TeamNET.Models.Respone.Event;
using TeamNET.Models.Respone.EventContent;
using TeamNET.Models.Respone.Student;

namespace TeamNET.Repository.Interface
{
    public interface IStudentRepository
    {
        Task<List<EventView>> Events(string userId, int courseCurrentId);
        Task<List<AbilityView>> Abilities(string userId, int courseCurrentId);
        Task<CourseView> Course(int courseCurrentId);
        Task<List<StudentView>> Students(string userId);
        Task<List<StudentView>> StudentsConditions(string userId, string studentName, int eventId, string ability, int courseId);
        Task<IEnumerable<EventContentView>> SearchStudentEvent(ReqSearchEvent request);
        Task<IEnumerable<StudentDetailsView>> Get(string studentId, string userCurentId);
        Task<StudentView> GetInfoStudent(string studentId);
    }
}
