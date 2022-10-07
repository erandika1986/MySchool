﻿using MySchool.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Domain.Entities
{
    public class Grade : BaseAuditEntity
    {
        public Grade()
        {
            Classes = new HashSet<Class>();
            ClassSubjects = new HashSet<ClassSubject>();
        }

        public string Name { get; set; }

        public virtual ICollection<Class> Classes { get; set; }
        public virtual ICollection<ClassSubject> ClassSubjects { get; set; }
    }
}
