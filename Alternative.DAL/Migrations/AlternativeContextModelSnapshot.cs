﻿// <auto-generated />
using System;
using Alternative.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Alternative.DAL.Migrations
{
    [DbContext(typeof(AlternativeContext))]
    partial class AlternativeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Alternative.Model.Entities.Faculty", b =>
                {
                    b.Property<Guid>("Id");

                    b.Property<string>("Description");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Faculty");
                });

            modelBuilder.Entity("Alternative.Model.Entities.Role", b =>
                {
                    b.Property<Guid>("Id");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Role");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0baa38ac-0252-4066-ab7e-a786cf49106c"),
                            Name = "Admin"
                        },
                        new
                        {
                            Id = new Guid("a0be18b1-509f-4f65-9e11-8e3d13823c0a"),
                            Name = "Student"
                        },
                        new
                        {
                            Id = new Guid("79b449bf-26f1-4d8c-a10d-1991c2489f1f"),
                            Name = "Teacher"
                        });
                });

            modelBuilder.Entity("Alternative.Model.Entities.Subject", b =>
                {
                    b.Property<Guid>("Id");

                    b.Property<string>("Description");

                    b.Property<Guid?>("FacultyId");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.Property<Guid?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("FacultyId");

                    b.HasIndex("UserId");

                    b.ToTable("Subject");
                });

            modelBuilder.Entity("Alternative.Model.Entities.User", b =>
                {
                    b.Property<Guid>("Id");

                    b.Property<string>("Email");

                    b.Property<Guid?>("FacultyId");

                    b.Property<string>("FirstName");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastName");

                    b.Property<string>("MiddleName");

                    b.Property<string>("Password");

                    b.Property<Guid>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("FacultyId");

                    b.HasIndex("RoleId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Alternative.Model.Entities.Subject", b =>
                {
                    b.HasOne("Alternative.Model.Entities.Faculty", "Faculty")
                        .WithMany()
                        .HasForeignKey("FacultyId");

                    b.HasOne("Alternative.Model.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Alternative.Model.Entities.User", b =>
                {
                    b.HasOne("Alternative.Model.Entities.Faculty", "Faculty")
                        .WithMany()
                        .HasForeignKey("FacultyId");

                    b.HasOne("Alternative.Model.Entities.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
