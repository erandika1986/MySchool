using Microsoft.EntityFrameworkCore;

namespace MySchool.Infrastructure.Data
{
    public class MySchoolContext : DbContext
    {
        public MySchoolContext(DbContextOptions<MySchoolContext> options) : base(options)
        {

        }
    }
}
