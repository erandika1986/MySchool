using MySchool.Domain.Entities;
using MySchool.Domain.Entities.School;
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
    public class ClassStudentSubjectRepository : BaseRepository<ClassStudentSubject>, IClassStudentSubjectRepository
    {
        public ClassStudentSubjectRepository(MySchoolContext context)
            : base(context)
        {

        }
    }
}
