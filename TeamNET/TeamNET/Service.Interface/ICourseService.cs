using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamNET.Models.Respone.Course;

namespace TeamNET.Service.Interface
{
    public interface ICourseService
    {
        Task<IEnumerable<CourseView>> Gets(string studentId);
    }
}
