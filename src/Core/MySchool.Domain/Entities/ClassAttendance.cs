using MySchool.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Domain.Entities
{
    public class ClassAttendance : BaseAuditEntity
    {
        public int ClassId { get; set; }
        public int TeacherId { get; set; }
        public DateTime Date { get; set; }

    }
}
