using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

namespace TN_Colleges.Models
{
    public class State_Colleges
    {
        [Key]
        public int SNo { get; set; }
        [Required]
        public string CollegeName { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string District { get; set; }
        [Required]
        public string AreaName { get; set; }
        [Required]
        public string Rank { get; set; }

    }
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
            
        }
        public DbSet<State_Colleges>CollegeDetails{ get; set; }
    }
}
