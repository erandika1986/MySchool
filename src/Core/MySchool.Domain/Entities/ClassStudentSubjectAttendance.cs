using MySchool.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Domain.Entities
{
    public class ClassStudentSubjectAttendance : BaseAuditEntity
    {
        public int ClassSubjectAttendanceId { get; set; }
        public int StudentId { get; set; }
        public bool IsPresent { get; set; }

    }
}
