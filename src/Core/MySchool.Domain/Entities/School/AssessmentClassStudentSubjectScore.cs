using MySchool.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Domain.Entities
{
    public class AssessmentClassStudentSubjectScore : BaseAuditEntity
    {
        public int ClassStudentSubjectId { get; set; }
        public int AssessmentId { get; set; }
        public int PredictedTargetScore { get; set; }
        public int TeacherAdjustedTargetScore { get; set; }
        public int ActualTargetScore { get; set; }

        public virtual ClassStudentSubject ClassStudentSubjects { get; set; }
        public virtual Assessment Assessment { get; set; }

    }
}
