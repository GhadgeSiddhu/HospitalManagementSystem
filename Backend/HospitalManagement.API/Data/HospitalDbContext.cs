using HospitalManagement.API.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagement.API.Data
{
    public class HospitalDbContext : DbContext
    {
        public HospitalDbContext(DbContextOptions<HospitalDbContext> options) : base(options)
        {

        }

        public DbSet<Patient> Patients { get; set; }
    }
}
