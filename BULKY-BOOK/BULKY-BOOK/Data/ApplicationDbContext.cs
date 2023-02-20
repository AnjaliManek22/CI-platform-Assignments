using BULKY_BOOK.Models;
using Microsoft.EntityFrameworkCore;

namespace BULKY_BOOK.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
    }
   
}
