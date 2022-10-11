using MySchool.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Domain.Entities.School
{
    public class ClassStudentSubjectAttendance : BaseAuditEntity
    {
        public int ClassSubjectAttendanceId { get; set; }
        public int StudentId { get; set; }
        public bool IsPresent { get; set; }

        public virtual ClassSubjectAttendance ClassSubjectAttendance { get; set; }
        public virtual User Student { get; set; }

    }
}
