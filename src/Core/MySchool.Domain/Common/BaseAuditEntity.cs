using MySchool.Domain.Entities.School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Domain.Common
{
    public class BaseAuditEntity : BaseEntity
    {
        public DateTime CreatedDate { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? UpdatedByUserId { get; set; }
        public bool IsActive { get; set; }

        public virtual User CreatedByUser { get; set; }
        public virtual User UpdatedByUser { get; set; }
    }
}
