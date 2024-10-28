using Microsoft.EntityFrameworkCore;
using VS2022CORE_CRUD_MVC.Models.Entities;

namespace VS2022CORE_CRUD_MVC.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
    }

}
