using MySchool.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Domain.Entities
{
    public class SubjectMonitor : BaseAuditEntity //??????????
    {
        public SubjectMonitor()
        {
            ClassSubjects = new HashSet<ClassSubject>();
        }
        public int MonitorId { get; set; }
        public int SubjectId { get; set; }
        public virtual ICollection<ClassSubject> ClassSubjects { get; set; }
    }
}
