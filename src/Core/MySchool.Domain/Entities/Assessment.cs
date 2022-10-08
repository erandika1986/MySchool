using MySchool.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Domain.Entities
{
    public class Assessment : BaseAuditEntity
    {
        public Assessment()
        {
            AssessmentClassStudentSubjectScores = new HashSet<AssessmentClassStudentSubjectScore>();
        }
        public string Name { get; set; }

        public virtual ICollection<AssessmentClassStudentSubjectScore> AssessmentClassStudentSubjectScores { get; set; }
    }
}
