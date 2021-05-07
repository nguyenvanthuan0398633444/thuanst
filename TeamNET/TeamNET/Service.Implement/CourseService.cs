using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamNET.Models.Respone.Course;
using TeamNET.Repository.Interface;
using TeamNET.Service.Interface;

namespace TeamNET.Service.Implement
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            this.courseRepository = courseRepository;
        }
        public async Task<IEnumerable<CourseView>> Gets(string studentId)
        {
            return await courseRepository.Gets(studentId);
        }
    }
}
