﻿// <auto-generated />
using System;
using Alternative.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Alternative.DAL.Migrations
{
    [DbContext(typeof(AlternativeContext))]
    [Migration("20191205175347_AddPriority")]
    partial class AddPriority
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Alternative.Model.Entities.Alternative", b =>
                {
                    b.Property<Guid>("Id");

                    b.Property<string>("Description");

                    b.Property<bool>("IsDeleted");

                    b.Property<int>("MaxQuantity");

                    b.Property<string>("Name");

                    b.Property<Guid>("TeacherId");

                    b.HasKey("Id");

                    b.HasIndex("TeacherId");

                    b.ToTable("Alternatives");
                });

            modelBuilder.Entity("Alternative.Model.Entities.AlternativesCourses", b =>
                {
                    b.Property<Guid>("AlternativeId");

                    b.Property<Guid>("CourseId");

                    b.HasKey("AlternativeId", "CourseId");

                    b.HasIndex("CourseId");

                    b.ToTable("AlternativesCourseses");
                });

            modelBuilder.Entity("Alternative.Model.Entities.Course", b =>
                {
                    b.Property<Guid>("Id");

                    b.Property<string>("Name");

                    b.Property<int>("Semestr");

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Alternative.Model.Entities.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Role");

                    b.HasData(
                        new
                        {
                            Id = new Guid("de373e0f-8e9b-4cfb-8369-82ba8c53a88e"),
                            ConcurrencyStamp = "7273cd58-ed05-44e0-9e23-250d0f9ec604"
                        },
                        new
                        {
                            Id = new Guid("7f67dbea-fe25-43e5-a2d5-1623051f691b"),
                            ConcurrencyStamp = "5f1d9312-7b0d-419f-879b-0a56dcc0e850"
                        },
                        new
                        {
                            Id = new Guid("6da720ea-ec2a-437d-bcf9-4efd7b2438fe"),
                            ConcurrencyStamp = "a6b29381-c87a-4636-928b-b274ea487877"
                        });
                });

            modelBuilder.Entity("Alternative.Model.Entities.SpecialityCourses", b =>
                {
                    b.Property<Guid>("SpecialtyId");

                    b.Property<Guid>("CourseId");

                    b.HasKey("SpecialtyId", "CourseId");

                    b.HasIndex("CourseId");

                    b.ToTable("SpecialityCourseses");
                });

            modelBuilder.Entity("Alternative.Model.Entities.Specialty", b =>
                {
                    b.Property<Guid>("Id");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Specialty");
                });

            modelBuilder.Entity("Alternative.Model.Entities.Teacher", b =>
                {
                    b.Property<Guid>("Id");

                    b.Property<string>("LinkKhNure");

                    b.Property<byte[]>("Photo");

                    b.Property<Guid?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique()
                        .HasFilter("[UserId] IS NOT NULL");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("Alternative.Model.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FullName");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<Guid>("RoleId");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("RoleId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Alternative.Model.Entities.UserSpecialty", b =>
                {
                    b.Property<Guid>("SpecialtyId");

                    b.Property<Guid>("UserId");

                    b.HasKey("SpecialtyId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("UserSpecialties");
                });

            modelBuilder.Entity("Alternative.Model.Entities.UsersAlternatives", b =>
                {
                    b.Property<Guid>("AlternativeId");

                    b.Property<Guid>("UserId");

                    b.Property<short>("Priority");

                    b.HasKey("AlternativeId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("UsersAlternativeses");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<Guid>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<Guid>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<Guid>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Alternative.Model.Entities.Alternative", b =>
                {
                    b.HasOne("Alternative.Model.Entities.Teacher", "Teacher")
                        .WithMany("Alternatives")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Alternative.Model.Entities.AlternativesCourses", b =>
                {
                    b.HasOne("Alternative.Model.Entities.Alternative", "Alternative")
                        .WithMany("AlternativesCourses")
                        .HasForeignKey("AlternativeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Alternative.Model.Entities.Course", "Course")
                        .WithMany("AlternativesCourses")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Alternative.Model.Entities.SpecialityCourses", b =>
                {
                    b.HasOne("Alternative.Model.Entities.Course", "Course")
                        .WithMany("SpecialityCourseses")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Alternative.Model.Entities.Specialty", "Specialty")
                        .WithMany("SpecialityCourseses")
                        .HasForeignKey("SpecialtyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Alternative.Model.Entities.Teacher", b =>
                {
                    b.HasOne("Alternative.Model.Entities.User", "User")
                        .WithOne("Teacher")
                        .HasForeignKey("Alternative.Model.Entities.Teacher", "UserId");
                });

            modelBuilder.Entity("Alternative.Model.Entities.User", b =>
                {
                    b.HasOne("Alternative.Model.Entities.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Alternative.Model.Entities.UserSpecialty", b =>
                {
                    b.HasOne("Alternative.Model.Entities.Specialty", "Specialty")
                        .WithMany("UserSpecialties")
                        .HasForeignKey("SpecialtyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Alternative.Model.Entities.User", "User")
                        .WithMany("UsersSpecialtys")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Alternative.Model.Entities.UsersAlternatives", b =>
                {
                    b.HasOne("Alternative.Model.Entities.Alternative", "Alternative")
                        .WithMany("UsersAlternatives")
                        .HasForeignKey("AlternativeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Alternative.Model.Entities.User", "User")
                        .WithMany("UsersAlternativeses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Alternative.Model.Entities.Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("Alternative.Model.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("Alternative.Model.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Alternative.Model.Entities.Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Alternative.Model.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("Alternative.Model.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}