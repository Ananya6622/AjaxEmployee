using AjaxEmployeePayroll.Entity;
using Microsoft.EntityFrameworkCore;

namespace AjaxEmployeePayroll.Context
{
    public class EmpContext : DbContext
    {
        public EmpContext()
        {
        }

        public EmpContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<EmpEntity> EmpTable { get; set; }
    }
}
