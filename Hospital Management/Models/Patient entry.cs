using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital_Management.Models
{
    public class Patient_entry
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string PatientID { get; set; }
        [Required]
        public string PatientName { get; set; }
        [Required]
        public string Age { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Mobilenumber { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Checkbox { get; set; }
        [Required]
        public DateTime Date { get; set; }
    }
    public class Doctor_entry
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
       
        public string PatientID { get; set; }
        [Required]
        public string DoctorID { get; set; }
        [Required]
        public string DoctorName { get; set; }
        [Required]
        public string DoctorFees { get; set; }
        [Required]
        public DateTime VisitTime { get; set; }
        [Required]
        public DateTime Date { get; set; }

    }
    public class Bill_entry
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
       
        public string PatientID { get; set; }
        [Required]
        public string DoctorID { get; set; }
        [Required]
        public string DoctorName { get; set; }
        [Required]
        public string Billnumber { get; set; }
        [Required]
        public string Billamount { get; set; }
        [Required]
        public string Medicaldescription { get; set; }

    }
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }
        public DbSet<Patient_entry> PatientDetails { get; set; }
        public DbSet<Doctor_entry> DoctorDetails { get; set; }
        public DbSet<Bill_entry> BillDetails { get; set; }
    }
}   