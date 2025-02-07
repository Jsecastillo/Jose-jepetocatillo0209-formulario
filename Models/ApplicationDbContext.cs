using Microsoft.EntityFrameworkCore;
using WebAppFormMVC.Models; // Asegurate de importar el namespace correcto

namespace WebAppFormMVC.Data
{
    public class ApplicationDbContext : DbContext // Falta heredar de DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<ContactMessage> ContactMessages { get; set; } // Corregí los nombres
    }
}
