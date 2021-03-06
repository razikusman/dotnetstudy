﻿// <auto-generated />
using MReportWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MReportWebAPI.Migrations
{
    [DbContext(typeof(MReportDBContext))]
    [Migration("20201105074514_Create_Table_Admin")]
    partial class Create_Table_Admin
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MReportWebAPI.Models.Addmin", b =>
                {
                    b.Property<int>("AddminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Contact")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HospitalArea")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OTP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OwnerNIC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AddminId");

                    b.ToTable("Addmins");
                });

            modelBuilder.Entity("MReportWebAPI.Models.Doctor", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Doctor_Address")
                        .HasColumnName("Doctor_Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Doctor_Contact")
                        .HasColumnName("Doctor_Contact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Doctor_Email")
                        .HasColumnName("Doctor_Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Doctor_FirstName")
                        .HasColumnName("Doctor_FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Doctor_Gender")
                        .HasColumnName("Doctor_Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Doctor_LastName")
                        .HasColumnName("Doctor_LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Doctor_Password")
                        .HasColumnName("Doctor_Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Doctor_Specialization")
                        .HasColumnName("Doctor_Specialization")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Doctor_Status")
                        .HasColumnName("Doctor_Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DoctorId");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("MReportWebAPI.Models.Patient", b =>
                {
                    b.Property<int>("PatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GuardContact")
                        .HasColumnType("int");

                    b.Property<string>("GuardEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GuardName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GuardType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PatientAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PatientContact")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("arae")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PatientId");

                    b.ToTable("Patients");
                });
#pragma warning restore 612, 618
        }
    }
}
