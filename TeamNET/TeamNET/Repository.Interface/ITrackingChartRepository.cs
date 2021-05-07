using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamNET.Models.Respone.Ability;
using TeamNET.Models.Respone.Event;
using TeamNET.Models.Respone.Student;
using TeamNET.Models.Respone.Tracking;

namespace TeamNET.Repository.Interface
{
    public interface ITrackingChartRepository
    {
        Task<IEnumerable<TrackingChart>> TrackingByStudentId(string studentId);
        Task<IEnumerable<TrackingChart>> TrackingDoughnutByStudentId(string studentId);
        Task<IEnumerable<AbilityView>> ShowAbility();
        Task<IEnumerable<TrackingEvent>> ShowEventChartDoughnut(string studentId, string abilityName);
        Task<IEnumerable<TrackingEvent>> ShowEventChartBar(string studentId, string abilityName, string courseName);
        Task<StudentInfoViewChart> StudentInfo(string studentId);


    }
}
