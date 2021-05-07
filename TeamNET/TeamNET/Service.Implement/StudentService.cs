using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamNET.Models.Request.Student;
using TeamNET.Models.Respone.Ability;
using TeamNET.Models.Respone.Course;
using TeamNET.Models.Respone.Event;
using TeamNET.Models.Respone.EventContent;
using TeamNET.Models.Respone.Student;
using TeamNET.Repository.Interface;
using TeamNET.Service.Interface;

namespace TeamNET.Service.Implement
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        public async Task<List<AbilityView>> Abilities(string userId, int courseCurrentId)
        {
            return await studentRepository.Abilities(userId, courseCurrentId);
        }

        public async Task<CourseView> Course(int courseCurrentId)
        {
            return await studentRepository.Course(courseCurrentId);
        }

        public async Task<List<EventView>> Events(string userId, int courseCurrentId)
        {
            return await studentRepository.Events(userId, courseCurrentId);
        }
        public async Task<IEnumerable<StudentDetailsView>> Get(string studentId, string userCurentId)
        {
          
          return await this.studentRepository.Get(studentId, userCurentId);
        }

        public async Task<IEnumerable<EventContentView>> SearchStudentEvent(ReqSearchEvent request)
        {
            return await studentRepository.SearchStudentEvent(request);
        }

        public async Task<List<StudentView>> Students(string userId)
        {
            return await studentRepository.Students(userId);
        }

        public async Task<List<StudentView>> StudentsConditions(string userId, string studentName, int EventId, string Ability, int CourseId)
        {
            return await studentRepository.StudentsConditions(userId, studentName, EventId, Ability, CourseId);
        }
        public async Task<StudentView> GetInfoStudent(string studentId)
        {
            return await studentRepository.GetInfoStudent(studentId);
        }
    }
}
