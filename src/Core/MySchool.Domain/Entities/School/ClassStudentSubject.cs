using MySchool.Domain.Common;
using MySchool.Domain.Entities.School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Domain.Entities
{
    public class ClassStudentSubject : BaseAuditEntity
    {
        public ClassStudentSubject()
        {
            AssessmentClassStudentSubjectScores = new HashSet<AssessmentClassStudentSubjectScore>();
        }
        public int ClassSubjectId { get; set; }
        public int ClassStudentId { get; set; }

        public virtual ClassSubject ClassSubject { get; set; }
        public virtual ClassStudent ClassStudent { get; set; }

        public virtual ICollection<ClassSubject> ClassSubjects { get; set; }
        public virtual ICollection<AssessmentClassStudentSubjectScore> AssessmentClassStudentSubjectScores { get; set; }

    }
}
