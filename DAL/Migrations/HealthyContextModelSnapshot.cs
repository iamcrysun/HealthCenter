﻿// <auto-generated />
using System;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL.Migrations
{
    [DbContext(typeof(HealthyContext))]
    partial class HealthyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DAL.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category1")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("Category");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("DAL.Day", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<string>("DayOfWeek")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Days");
                });

            modelBuilder.Entity("DAL.DoProc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PatientId")
                        .HasColumnType("int")
                        .HasColumnName("PatientID");

                    b.Property<int>("ProcId")
                        .HasColumnType("int")
                        .HasColumnName("ProcID");

                    b.Property<int>("RecordId")
                        .HasColumnType("int")
                        .HasColumnName("RecordID");

                    b.HasKey("Id");

                    b.HasIndex("PatientId");

                    b.HasIndex("ProcId");

                    b.HasIndex("RecordId");

                    b.ToTable("DoProc");
                });

            modelBuilder.Entity("DAL.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("CategoryID");

                    b.Property<bool>("Certificate")
                        .HasColumnType("bit");

                    b.Property<bool>("Closed")
                        .HasColumnType("bit");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<int>("PlaceOfSee")
                        .HasColumnType("int");

                    b.Property<int>("SpecializationId")
                        .HasColumnType("int")
                        .HasColumnName("SpecializationID");

                    b.Property<DateTime?>("ZamEnd")
                        .HasColumnType("date");

                    b.Property<DateTime?>("ZamStart")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("SpecializationId");

                    b.ToTable("Doctor");
                });

            modelBuilder.Entity("DAL.DoctorSee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Closed")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int")
                        .HasColumnName("DoctorID");

                    b.Property<int>("PatientId")
                        .HasColumnType("int")
                        .HasColumnName("PatientID");

                    b.Property<bool?>("Visited")
                        .HasColumnType("bit");

                    b.Property<int?>("ZamId")
                        .HasColumnType("int")
                        .HasColumnName("ZamID");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.ToTable("DoctorSee");
                });

            modelBuilder.Entity("DAL.MakingProcedure", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NurceId")
                        .HasColumnType("int")
                        .HasColumnName("NurceID");

                    b.Property<int>("ProcedureId")
                        .HasColumnType("int")
                        .HasColumnName("ProcedureID");

                    b.HasKey("Id");

                    b.HasIndex("NurceId");

                    b.HasIndex("ProcedureId");

                    b.ToTable("MakingProcedure");
                });

            modelBuilder.Entity("DAL.Medicament", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Medicine")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<int>("RecordId")
                        .HasColumnType("int")
                        .HasColumnName("RecordID");

                    b.HasKey("Id");

                    b.HasIndex("RecordId");

                    b.ToTable("Medicaments");
                });

            modelBuilder.Entity("DAL.Nurce", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Closed")
                        .HasColumnType("bit");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<int>("WorkEx")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Nurce");
                });

            modelBuilder.Entity("DAL.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<bool>("Closed")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("Document")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Male")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("PlaceOfWork")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("StreetId")
                        .HasColumnType("int")
                        .HasColumnName("StreetID");

                    b.HasKey("Id");

                    b.HasIndex("StreetId");

                    b.ToTable("Patient");
                });

            modelBuilder.Entity("DAL.Procedure", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("date");

                    b.Property<int>("DoProcId")
                        .HasColumnType("int")
                        .HasColumnName("DoProcID");

                    b.Property<int>("ScheduleId")
                        .HasColumnType("int")
                        .HasColumnName("ScheduleID");

                    b.Property<bool?>("Visited")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("DoProcId");

                    b.HasIndex("ScheduleId");

                    b.ToTable("Procedure");
                });

            modelBuilder.Entity("DAL.RecordInPatientFile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime");

                    b.Property<string>("Diagnosis")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<int?>("DoctorId")
                        .HasColumnType("int")
                        .HasColumnName("DoctorID");

                    b.Property<int?>("NurseId")
                        .HasColumnType("int")
                        .HasColumnName("NurseID");

                    b.Property<int>("PatientId")
                        .HasColumnType("int")
                        .HasColumnName("PatientID");

                    b.Property<string>("Result")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("NurseId");

                    b.HasIndex("PatientId");

                    b.ToTable("RecordInPatientFile");
                });

            modelBuilder.Entity("DAL.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DayofWeek")
                        .HasColumnType("int")
                        .HasColumnName("dayofWeek");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int")
                        .HasColumnName("DoctorID");

                    b.Property<int>("Room")
                        .HasColumnType("int");

                    b.Property<int>("ShiftId")
                        .HasColumnType("int")
                        .HasColumnName("ShiftID");

                    b.Property<int?>("ZamId")
                        .HasColumnType("int")
                        .HasColumnName("ZamID");

                    b.HasKey("Id");

                    b.HasIndex("DayofWeek");

                    b.HasIndex("DoctorId");

                    b.HasIndex("ShiftId");

                    b.ToTable("Schedule");
                });

            modelBuilder.Entity("DAL.ScheduleProcedure", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Closed")
                        .HasColumnType("bit");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<int>("DayId")
                        .HasColumnType("int")
                        .HasColumnName("DayID");

                    b.Property<int>("ProcedureId")
                        .HasColumnType("int")
                        .HasColumnName("ProcedureID");

                    b.Property<int>("Room")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DayId");

                    b.HasIndex("ProcedureId");

                    b.ToTable("ScheduleProcedure");
                });

            modelBuilder.Entity("DAL.Shift", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Number")
                        .HasColumnType("int")
                        .HasColumnName("number");

                    b.Property<TimeSpan>("TimeofBegin")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("TimeofEnd")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.ToTable("Shifts");
                });

            modelBuilder.Entity("DAL.Specialization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SpecializationName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Specialization");
                });

            modelBuilder.Entity("DAL.Street", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PlaceOfSee")
                        .HasColumnType("int");

                    b.Property<string>("Street1")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("Street");

                    b.HasKey("Id");

                    b.ToTable("Streets");
                });

            modelBuilder.Entity("DAL.TypeofProc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Type")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TypeofProc");
                });

            modelBuilder.Entity("DAL.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DoctorId")
                        .HasColumnType("int")
                        .HasColumnName("DoctorID");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("UserType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("UserType");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DAL.UserType", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<string>("UserType1")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("UserType");

                    b.HasKey("Id");

                    b.ToTable("UserTypes");
                });

            modelBuilder.Entity("DAL.DoProc", b =>
                {
                    b.HasOne("DAL.Patient", "Patient")
                        .WithMany("DoProcs")
                        .HasForeignKey("PatientId")
                        .HasConstraintName("FK_DoProc_Patient")
                        .IsRequired();

                    b.HasOne("DAL.TypeofProc", "Proc")
                        .WithMany("DoProcs")
                        .HasForeignKey("ProcId")
                        .HasConstraintName("FK_DoProc_TypeofProc")
                        .IsRequired();

                    b.HasOne("DAL.RecordInPatientFile", "Record")
                        .WithMany("DoProcs")
                        .HasForeignKey("RecordId")
                        .HasConstraintName("FK_DoProc_RecordInPatientFile")
                        .IsRequired();

                    b.Navigation("Patient");

                    b.Navigation("Proc");

                    b.Navigation("Record");
                });

            modelBuilder.Entity("DAL.Doctor", b =>
                {
                    b.HasOne("DAL.Category", "Category")
                        .WithMany("Doctors")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK_Doctor_Categories")
                        .IsRequired();

                    b.HasOne("DAL.Specialization", "Specialization")
                        .WithMany("Doctors")
                        .HasForeignKey("SpecializationId")
                        .HasConstraintName("FK_Doctor_Specialization")
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Specialization");
                });

            modelBuilder.Entity("DAL.DoctorSee", b =>
                {
                    b.HasOne("DAL.Doctor", "Doctor")
                        .WithMany("DoctorSees")
                        .HasForeignKey("DoctorId")
                        .HasConstraintName("FK_DoctorSee_Doctor")
                        .IsRequired();

                    b.HasOne("DAL.Patient", "Patient")
                        .WithMany("DoctorSees")
                        .HasForeignKey("PatientId")
                        .HasConstraintName("FK_DoctorSee_Patient")
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("DAL.MakingProcedure", b =>
                {
                    b.HasOne("DAL.Nurce", "Nurce")
                        .WithMany("MakingProcedures")
                        .HasForeignKey("NurceId")
                        .HasConstraintName("FK_MakingProcedure_Nurce")
                        .IsRequired();

                    b.HasOne("DAL.TypeofProc", "Procedure")
                        .WithMany("MakingProcedures")
                        .HasForeignKey("ProcedureId")
                        .HasConstraintName("FK_MakingProcedure_TypeofProc")
                        .IsRequired();

                    b.Navigation("Nurce");

                    b.Navigation("Procedure");
                });

            modelBuilder.Entity("DAL.Medicament", b =>
                {
                    b.HasOne("DAL.RecordInPatientFile", "Record")
                        .WithMany("Medicaments")
                        .HasForeignKey("RecordId")
                        .HasConstraintName("FK_Medicaments_RecordInPatientFile")
                        .IsRequired();

                    b.Navigation("Record");
                });

            modelBuilder.Entity("DAL.Patient", b =>
                {
                    b.HasOne("DAL.Street", "Street")
                        .WithMany("Patients")
                        .HasForeignKey("StreetId")
                        .HasConstraintName("FK_Patient_Patient")
                        .IsRequired();

                    b.Navigation("Street");
                });

            modelBuilder.Entity("DAL.Procedure", b =>
                {
                    b.HasOne("DAL.DoProc", "DoProc")
                        .WithMany("Procedures")
                        .HasForeignKey("DoProcId")
                        .HasConstraintName("FK_Procedure_DoProc")
                        .IsRequired();

                    b.HasOne("DAL.ScheduleProcedure", "Schedule")
                        .WithMany("Procedures")
                        .HasForeignKey("ScheduleId")
                        .HasConstraintName("FK_Procedure_ScheduleProcedure")
                        .IsRequired();

                    b.Navigation("DoProc");

                    b.Navigation("Schedule");
                });

            modelBuilder.Entity("DAL.RecordInPatientFile", b =>
                {
                    b.HasOne("DAL.Doctor", "Doctor")
                        .WithMany("RecordInPatientFiles")
                        .HasForeignKey("DoctorId")
                        .HasConstraintName("FK_RecordInPatientFile_Doctor");

                    b.HasOne("DAL.Nurce", "Nurse")
                        .WithMany("RecordInPatientFiles")
                        .HasForeignKey("NurseId")
                        .HasConstraintName("FK_RecordInPatientFile_Nurce");

                    b.HasOne("DAL.Patient", "Patient")
                        .WithMany("RecordInPatientFiles")
                        .HasForeignKey("PatientId")
                        .HasConstraintName("FK_RecordInPatientFile_Patient")
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Nurse");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("DAL.Schedule", b =>
                {
                    b.HasOne("DAL.Day", "DayofWeekNavigation")
                        .WithMany("Schedules")
                        .HasForeignKey("DayofWeek")
                        .HasConstraintName("FK_Schedule_Days")
                        .IsRequired();

                    b.HasOne("DAL.Doctor", "Doctor")
                        .WithMany("Schedules")
                        .HasForeignKey("DoctorId")
                        .HasConstraintName("FK_Schedule_Doctor")
                        .IsRequired();

                    b.HasOne("DAL.Shift", "Shift")
                        .WithMany("Schedules")
                        .HasForeignKey("ShiftId")
                        .HasConstraintName("FK_Schedule_Shifts")
                        .IsRequired();

                    b.Navigation("DayofWeekNavigation");

                    b.Navigation("Doctor");

                    b.Navigation("Shift");
                });

            modelBuilder.Entity("DAL.ScheduleProcedure", b =>
                {
                    b.HasOne("DAL.Day", "Day")
                        .WithMany("ScheduleProcedures")
                        .HasForeignKey("DayId")
                        .HasConstraintName("FK_ScheduleProcedure_Days")
                        .IsRequired();

                    b.HasOne("DAL.TypeofProc", "Procedure")
                        .WithMany("ScheduleProcedures")
                        .HasForeignKey("ProcedureId")
                        .HasConstraintName("FK_ScheduleProcedure_TypeofProc")
                        .IsRequired();

                    b.Navigation("Day");

                    b.Navigation("Procedure");
                });

            modelBuilder.Entity("DAL.User", b =>
                {
                    b.HasOne("DAL.Doctor", "Doctor")
                        .WithMany("Users")
                        .HasForeignKey("DoctorId")
                        .HasConstraintName("FK_Users_Doctor");

                    b.HasOne("DAL.UserType", "UserTypeNavigation")
                        .WithMany("Users")
                        .HasForeignKey("UserType")
                        .HasConstraintName("FK_Users_UserTypes")
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("UserTypeNavigation");
                });

            modelBuilder.Entity("DAL.Category", b =>
                {
                    b.Navigation("Doctors");
                });

            modelBuilder.Entity("DAL.Day", b =>
                {
                    b.Navigation("ScheduleProcedures");

                    b.Navigation("Schedules");
                });

            modelBuilder.Entity("DAL.DoProc", b =>
                {
                    b.Navigation("Procedures");
                });

            modelBuilder.Entity("DAL.Doctor", b =>
                {
                    b.Navigation("DoctorSees");

                    b.Navigation("RecordInPatientFiles");

                    b.Navigation("Schedules");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("DAL.Nurce", b =>
                {
                    b.Navigation("MakingProcedures");

                    b.Navigation("RecordInPatientFiles");
                });

            modelBuilder.Entity("DAL.Patient", b =>
                {
                    b.Navigation("DoctorSees");

                    b.Navigation("DoProcs");

                    b.Navigation("RecordInPatientFiles");
                });

            modelBuilder.Entity("DAL.RecordInPatientFile", b =>
                {
                    b.Navigation("DoProcs");

                    b.Navigation("Medicaments");
                });

            modelBuilder.Entity("DAL.ScheduleProcedure", b =>
                {
                    b.Navigation("Procedures");
                });

            modelBuilder.Entity("DAL.Shift", b =>
                {
                    b.Navigation("Schedules");
                });

            modelBuilder.Entity("DAL.Specialization", b =>
                {
                    b.Navigation("Doctors");
                });

            modelBuilder.Entity("DAL.Street", b =>
                {
                    b.Navigation("Patients");
                });

            modelBuilder.Entity("DAL.TypeofProc", b =>
                {
                    b.Navigation("DoProcs");

                    b.Navigation("MakingProcedures");

                    b.Navigation("ScheduleProcedures");
                });

            modelBuilder.Entity("DAL.UserType", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
