using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MReportWebAPI.Models
{
    public partial class MReportDBContext : DbContext
    {
        public MReportDBContext()
        {
        }

        public MReportDBContext(DbContextOptions<MReportDBContext> options)
            : base(options)
        {
        }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Addmin> Addmins { get; set; }
        public DbSet<SuperAddmin> SuperAddmins { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=MReport");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor>(entity =>
            {
                entity.HasKey(e => e.DoctorId);

                entity.Property(e => e.Doctor_Address).HasColumnName("Doctor_Address");

                entity.Property(e => e.Doctor_Contact).HasColumnName("Doctor_Contact");

                entity.Property(e => e.Doctor_Email).HasColumnName("Doctor_Email");

                entity.Property(e => e.Doctor_FirstName).HasColumnName("Doctor_FirstName");

                entity.Property(e => e.Doctor_Gender).HasColumnName("Doctor_Gender");

                entity.Property(e => e.Doctor_LastName).HasColumnName("Doctor_LastName");

                entity.Property(e => e.Doctor_Password).HasColumnName("Doctor_Password");

                entity.Property(e => e.Doctor_Specialization).HasColumnName("Doctor_Specialization");

                entity.Property(e => e.Doctor_Status).HasColumnName("Doctor_Status");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
