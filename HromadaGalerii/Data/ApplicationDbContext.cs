using FileUpload.Models;
using HromadaGalerii.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HromadaGalerii.Data
{
    public class ApplicationDbContext : IdentityDbContext<User, IdentityRole<string>, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }
        public DbSet<User> User { get; set; }
        public DbSet<StoredFile> Files { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<ThumbnailBlob> Thumbnails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Thumbnail>().HasKey(t => new { t.FileId, t.Type });

        }
    }
}