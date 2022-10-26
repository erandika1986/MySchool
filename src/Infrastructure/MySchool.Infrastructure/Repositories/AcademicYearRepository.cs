using MySchool.Domain.Entities;
using MySchool.Domain.Repositories;
using MySchool.Infrastructure.Data;
using MySchool.Infrastructure.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Infrastructure.Repositories
{
    public class AcademicYearRepository : BaseRepository<AcademicYear>, IAcademicYearRepository
    {
        public AcademicYearRepository(MySchoolContext context)
            :base(context)
        {

        }
    }
}
