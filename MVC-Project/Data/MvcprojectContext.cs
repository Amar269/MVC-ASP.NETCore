using Microsoft.EntityFrameworkCore;
using MVC_Project.Models;

namespace MVC_Project.Data
{
    public class MvcprojectContext : DbContext
    {
        public MvcprojectContext(DbContextOptions<MvcprojectContext> options
            ) : base(options)
        {

        }

        public DbSet<Item> Items { get; set; }
    }
}
