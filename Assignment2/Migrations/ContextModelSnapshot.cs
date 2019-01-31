﻿// <auto-generated />
using System;
using Assignment2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Assignment2.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Assignment2.Models.Car", b =>
                {
                    b.Property<int>("CarId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId");

                    b.Property<string>("Description");

                    b.Property<string>("Make");

                    b.Property<double>("Mileage");

                    b.Property<string>("Model");

                    b.Property<double>("Range");

                    b.Property<string>("UserName");

                    b.HasKey("CarId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("UserName");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("Assignment2.Models.Company", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Mission");

                    b.Property<string>("Name");

                    b.Property<string>("Strategy");

                    b.Property<string>("Vision");

                    b.Property<string>("Website");

                    b.HasKey("CompanyId");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("Assignment2.Models.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("EndDate");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Name");

                    b.Property<int>("ProjectType");

                    b.Property<string>("StartDate");

                    b.Property<string>("UserName");

                    b.HasKey("ProjectId");

                    b.HasIndex("UserName");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("Assignment2.Models.Skill", b =>
                {
                    b.Property<int>("SkillId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int?>("ProjectId");

                    b.HasKey("SkillId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("ProjectId");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("Assignment2.Models.SkillProject", b =>
                {
                    b.Property<int>("SkillProjectId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProjectId");

                    b.Property<int>("SkillId");

                    b.HasKey("SkillProjectId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("SkillId");

                    b.ToTable("SkillProject");
                });

            modelBuilder.Entity("Assignment2.Models.User", b =>
                {
                    b.Property<string>("UserName")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("lastActivityDate");

                    b.HasKey("UserName");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Assignment2.Models.Car", b =>
                {
                    b.HasOne("Assignment2.Models.Company", "Company")
                        .WithMany("Cars")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Assignment2.Models.User", "User")
                        .WithMany("Cars")
                        .HasForeignKey("UserName");
                });

            modelBuilder.Entity("Assignment2.Models.Project", b =>
                {
                    b.HasOne("Assignment2.Models.User", "User")
                        .WithMany("Projects")
                        .HasForeignKey("UserName");
                });

            modelBuilder.Entity("Assignment2.Models.Skill", b =>
                {
                    b.HasOne("Assignment2.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Assignment2.Models.Project")
                        .WithMany("Skills")
                        .HasForeignKey("ProjectId");
                });

            modelBuilder.Entity("Assignment2.Models.SkillProject", b =>
                {
                    b.HasOne("Assignment2.Models.Project", "Project")
                        .WithMany("SkillProjects")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Assignment2.Models.Skill", "Skill")
                        .WithMany("SkillProject")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
