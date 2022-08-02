using Microsoft.EntityFrameworkCore;
using RecipeBoxWebApp.Models;

namespace RecipeBoxWebApp.Data
{
    public class ImageDbContext : DbContext
    {
        public ImageDbContext(DbContextOptions<ImageDbContext> options) : base(options)
        {

        }
    
        public DbSet<ImageModel> Images { get; set; }
    }
}
