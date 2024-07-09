using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Hotol_Mgt.Models
{
    public class College
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudentID { get; set; }

        public string StudentName { get; set; }

        public string StudentEmail { get; set; }

        public string StudentPhone { get; set; }
    }
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }
        public DbSet<College> StudentDetails { get; set; }
    }

}
