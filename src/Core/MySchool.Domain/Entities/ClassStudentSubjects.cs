﻿using MySchool.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Domain.Entities
{
    public class ClassStudentSubjects : BaseAuditEntity
    {
        public ClassStudentSubjects()
        {
            AssessmentClassStudentSubjectScores = new HashSet<AssessmentClassStudentSubjectScore>();
        }
        public int ClassSubjectId { get; set; }
        public int ClassStudentId { get; set; }

        public virtual ClassSubject ClassSubject { get; set; }
        public virtual ClassStudent ClassStudent { get; set; }
        public virtual ICollection<AssessmentClassStudentSubjectScore> AssessmentClassStudentSubjectScores { get; set; }

    }
}
