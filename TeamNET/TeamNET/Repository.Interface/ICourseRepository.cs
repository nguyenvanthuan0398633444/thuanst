using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamNET.Models.Respone.Course;

namespace TeamNET.Repository.Interface
{
    public interface ICourseRepository
    {
        Task<IEnumerable<CourseView>> Gets(string studentId);
    }
}
