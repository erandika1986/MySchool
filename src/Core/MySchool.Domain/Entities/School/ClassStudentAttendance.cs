using MySchool.Domain.Common;
using MySchool.Domain.Entities.School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Domain.Entities
{
    public class ClassStudentAttendance : BaseAuditEntity
    {
        public int StudentId { get; set; }
        public int ClassAttendanceId { get; set; }
        public bool IsPresent { get; set; }


        public virtual User Student { get; set; }
        public virtual ClassAttendance ClassAttendance { get; set; }
    }
}
