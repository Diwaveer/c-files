using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;


namespace MVC_DB.Models
{
    public class Photo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FileName { get; set; }

        [Required]
        public byte[] Data { get; set; }
        [NotMapped]

        public IFormFile File { get; set; }

        public DateTime UploadDate { get; set; }
    }

    public class FilePhotoContext : DbContext
    {
        public DbSet<Photo> Photos { get; set; }

        public FilePhotoContext(DbContextOptions<FilePhotoContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Photo>()
                .Ignore(p => p.File);
        }
    }
}
