using DataAccess.NewFolder2;
using Microsoft.EntityFrameworkCore;
namespace DataAccess
{
    public class Context :DbContext
    {
        public Context(DbContextOptions options)
            : base(options)
        {

        }
        public DbSet<Member> members { get; set; }

    }
}