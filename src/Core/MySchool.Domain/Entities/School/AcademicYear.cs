using MySchool.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Domain.Entities
{
    public class AcademicYear : BaseAuditEntity
    {
        public AcademicYear()
        {
            Classes = new HashSet<Class>();
        }

        public string Name { get; set; }

        public virtual ICollection<Class> Classes { get; set; }
    }
}
