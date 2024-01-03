﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using ResEvi.Data;

#nullable disable

namespace ResEvi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.12");

            modelBuilder.Entity("ResEvi.Data.Entities.Advisor", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("CompanyId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Advisors");
                });

            modelBuilder.Entity("ResEvi.Data.Entities.Company", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("RFC")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("TEXT");

                    b.Property<int>("Sector")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("ResEvi.Data.Entities.Contact", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("CompanyId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasAnnotation("RegularExpression", "^([\\w\\.\\-]+)@([\\w\\-]+)((\\.(\\w){2,3})+)$");

                    b.Property<string>("Extension")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("ResEvi.Data.Entities.Project", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("CompanyId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("RecordId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("RecordId")
                        .IsUnique();

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("ResEvi.Data.Entities.Record", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<long>("ExternalAdvisorId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Gender")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("HasAcceptanceLetter")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("HasInternshipRequest")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("HasPreProject")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("HasPresentationLetter")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("HasProofOfSocialService")
                        .HasColumnType("INTEGER");

                    b.Property<long>("InternalAdvisorId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsRecordClosed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Major")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Module")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Observations")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Period")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("RegisterDate")
                        .HasColumnType("TEXT");

                    b.Property<long>("ReviewerId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Schedule")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Specialty")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ExternalAdvisorId");

                    b.HasIndex("InternalAdvisorId");

                    b.HasIndex("ReviewerId");

                    b.ToTable("Records");
                });

            modelBuilder.Entity("ResEvi.Data.Entities.Advisor", b =>
                {
                    b.HasOne("ResEvi.Data.Entities.Company", "Company")
                        .WithMany("Advisors")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("ResEvi.Data.Entities.Contact", b =>
                {
                    b.HasOne("ResEvi.Data.Entities.Company", "Company")
                        .WithMany("Contacts")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("ResEvi.Data.Entities.Project", b =>
                {
                    b.HasOne("ResEvi.Data.Entities.Company", "Company")
                        .WithMany("Projects")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ResEvi.Data.Entities.Record", "Record")
                        .WithOne("Project")
                        .HasForeignKey("ResEvi.Data.Entities.Project", "RecordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("Record");
                });

            modelBuilder.Entity("ResEvi.Data.Entities.Record", b =>
                {
                    b.HasOne("ResEvi.Data.Entities.Advisor", "ExternalAdvisor")
                        .WithMany("ExternalAdvisorRecords")
                        .HasForeignKey("ExternalAdvisorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ResEvi.Data.Entities.Advisor", "InternalAdvisor")
                        .WithMany("InternalAdvisorRecords")
                        .HasForeignKey("InternalAdvisorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ResEvi.Data.Entities.Advisor", "Reviewer")
                        .WithMany("ReviewerRecords")
                        .HasForeignKey("ReviewerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ExternalAdvisor");

                    b.Navigation("InternalAdvisor");

                    b.Navigation("Reviewer");
                });

            modelBuilder.Entity("ResEvi.Data.Entities.Advisor", b =>
                {
                    b.Navigation("ExternalAdvisorRecords");

                    b.Navigation("InternalAdvisorRecords");

                    b.Navigation("ReviewerRecords");
                });

            modelBuilder.Entity("ResEvi.Data.Entities.Company", b =>
                {
                    b.Navigation("Advisors");

                    b.Navigation("Contacts");

                    b.Navigation("Projects");
                });

            modelBuilder.Entity("ResEvi.Data.Entities.Record", b =>
                {
                    b.Navigation("Project")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
