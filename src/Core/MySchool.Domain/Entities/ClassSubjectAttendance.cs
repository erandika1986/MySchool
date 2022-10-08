using MySchool.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Domain.Entities
{
    public class ClassSubjectAttendance : BaseAuditEntity
    {
        public ClassSubjectAttendance()
        {
            ClassStudentSubjectAttendances = new HashSet<ClassStudentSubjectAttendance>();
        }
        public int ClassId { get; set; }
        public int SubjectId { get; set; }
        public int TeacherId { get; set; }
        public DateTime Date { get; set; }


        public virtual Class Class { get; set; }
        public virtual Subjects Subjects { get; set; }
        public virtual User Teacher { get; set; }

        public virtual ICollection<ClassStudentSubjectAttendance> ClassStudentSubjectAttendances { get; set; }



    }
}
