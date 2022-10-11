using MySchool.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Domain.Entities.School
{
    public class ClassAttendance : BaseAuditEntity
    {
        public ClassAttendance()
        {
            ClassStudentAttendances = new HashSet<ClassStudentAttendance>();
            ClassAttendances = new HashSet<ClassAttendance>();
        }

        public int ClassId { get; set; }
        public int TeacherId { get; set; }
        public DateTime Date { get; set; }

        public virtual Class Class { get; set; }
        public virtual User Teacher { get; set; }

        public virtual ICollection<ClassStudentAttendance> ClassStudentAttendances { get; set; }
        public virtual ICollection<ClassAttendance> ClassAttendances { get; set; }

    }
}
