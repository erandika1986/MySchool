using MySchool.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Domain.Entities
{
    public class Class : BaseAuditEntity
    {
        public Class()
        {
            ClassStudents = new HashSet<ClassStudent>();
        }

        public int AcademicYearId { get; set; }
        public int GradeId { get; set; }
        public int ClassNameId { get; set; }
        public string Name { get; set; }

        public virtual AcademicYear AcademicYear { get; set; }
        public virtual Grade Grade { get; set; }
        public virtual ClassName ClassName { get; set; }

        public ICollection<ClassStudent> ClassStudents { get; set; }


    }
}
