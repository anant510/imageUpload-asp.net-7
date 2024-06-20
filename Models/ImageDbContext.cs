using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace thirdimage.Models
{
    public class ImageDbContext : DbContext
    {   
        public ImageDbContext(DbContextOptions<ImageDbContext> options) : base(options)
        {
        }

        public DbSet<ImageModel> Images { get; set; }
    }
}
