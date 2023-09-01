
using Entities.DB;
using Microsoft.EntityFrameworkCore;

namespace Repositories
{
    public class PhoneBookContext : DbContext
    {
        public PhoneBookContext(DbContextOptions<PhoneBookContext> options) : base(options)
        {
        }
        public DbSet<Contacts> Contacts { get; set; }
        public DbSet<Phone> Phones { get; set; }


    }
}