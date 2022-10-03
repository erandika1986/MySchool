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
        public int AcademicYearId { get; set; }
        public int GradeId { get; set; }
        public int ClassNameId { get; set; }
        public string Name { get; set; }

    }
}
