using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DineshKumar.Models
{
    public class College
    {
        [Key]
         [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int StaffID { get; set; }
        [Required]
        public string StaffName { get; set; }
        [Required]
        public string DepartmentName { get; set; }
        [Required]
        public string Position { get; set; }
        [Required]
        public string Qualification { get; set; }
        [Required]
        public string Masterdepartment { get; set; }
        [NotMapped]
        public IFormFile File { get; set; }
    }
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }
        public DbSet<College> StaffsDetails { get; set; }
    }
}
