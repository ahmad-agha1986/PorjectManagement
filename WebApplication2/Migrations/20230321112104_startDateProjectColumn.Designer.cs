﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication2.Models;

#nullable disable

namespace WebApplication2.Migrations
{
    [DbContext(typeof(MyDatabaseContext))]
    [Migration("20230321112104_startDateProjectColumn")]
    partial class startDateProjectColumn
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.3");

            modelBuilder.Entity("WebApplication2.Models.Client", b =>
                {
                    b.Property<int?>("Client_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Client_Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("WebApplication2.Models.Notification", b =>
                {
                    b.Property<int?>("Notification_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("Created_at")
                        .HasColumnType("TEXT");

                    b.Property<bool?>("IsRead")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int?>("User_Id")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.HasKey("Notification_Id");

                    b.HasIndex("User_Id");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("WebApplication2.Models.Project1", b =>
                {
                    b.Property<int?>("Project_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Client_Id")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DueDate")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("StartDate")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Project_Id");

                    b.HasIndex("Client_Id");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("WebApplication2.Models.Roles", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("WebApplication2.Models.Task1", b =>
                {
                    b.Property<int?>("Task_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("EndDate")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("Project_Id")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("StartDate")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .HasColumnType("TEXT");

                    b.Property<double?>("TimeEstimate")
                        .IsRequired()
                        .HasColumnType("REAL");

                    b.Property<int?>("User_Id")
                        .HasColumnType("INTEGER");

                    b.HasKey("Task_Id");

                    b.HasIndex("Project_Id");

                    b.HasIndex("User_Id");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("WebApplication2.Models.User", b =>
                {
                    b.Property<int?>("User_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Job_Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<bool?>("OnLeave")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Registration_date")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("UserAuth_Id")
                        .HasColumnType("INTEGER");

                    b.HasKey("User_Id");

                    b.HasIndex("UserAuth_Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("WebApplication2.Models.UserAuth", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConfirmPassword")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("UserAuths");
                });

            modelBuilder.Entity("WebApplication2.Models.UserRecord", b =>
                {
                    b.Property<int?>("UserRecord_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("Date")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<TimeSpan?>("EndTime")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<TimeSpan?>("StartTime")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("Task_Id")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.HasKey("UserRecord_Id");

                    b.HasIndex("Task_Id");

                    b.ToTable("UserRecords");
                });

            modelBuilder.Entity("WebApplication2.Models.UserRoles", b =>
                {
                    b.Property<int>("UserRoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("RoleId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserAuthId")
                        .HasColumnType("INTEGER");

                    b.HasKey("UserRoleId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserAuthId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("WebApplication2.Models.Notification", b =>
                {
                    b.HasOne("WebApplication2.Models.User", "User")
                        .WithMany("Notification")
                        .HasForeignKey("User_Id")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebApplication2.Models.Project1", b =>
                {
                    b.HasOne("WebApplication2.Models.Client", "Client")
                        .WithMany("Project")
                        .HasForeignKey("Client_Id")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("WebApplication2.Models.Task1", b =>
                {
                    b.HasOne("WebApplication2.Models.Project1", "Project")
                        .WithMany("Task")
                        .HasForeignKey("Project_Id")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("WebApplication2.Models.User", "User")
                        .WithMany("Task")
                        .HasForeignKey("User_Id")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Project");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebApplication2.Models.User", b =>
                {
                    b.HasOne("WebApplication2.Models.UserAuth", "UserAuth")
                        .WithMany("User")
                        .HasForeignKey("UserAuth_Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("UserAuth");
                });

            modelBuilder.Entity("WebApplication2.Models.UserRecord", b =>
                {
                    b.HasOne("WebApplication2.Models.Task1", "Task")
                        .WithMany("UserRecords")
                        .HasForeignKey("Task_Id")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.Navigation("Task");
                });

            modelBuilder.Entity("WebApplication2.Models.UserRoles", b =>
                {
                    b.HasOne("WebApplication2.Models.Roles", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication2.Models.UserAuth", "UserAuth")
                        .WithMany("UserRole")
                        .HasForeignKey("UserAuthId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("UserAuth");
                });

            modelBuilder.Entity("WebApplication2.Models.Client", b =>
                {
                    b.Navigation("Project");
                });

            modelBuilder.Entity("WebApplication2.Models.Project1", b =>
                {
                    b.Navigation("Task");
                });

            modelBuilder.Entity("WebApplication2.Models.Roles", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("WebApplication2.Models.Task1", b =>
                {
                    b.Navigation("UserRecords");
                });

            modelBuilder.Entity("WebApplication2.Models.User", b =>
                {
                    b.Navigation("Notification");

                    b.Navigation("Task");
                });

            modelBuilder.Entity("WebApplication2.Models.UserAuth", b =>
                {
                    b.Navigation("User");

                    b.Navigation("UserRole");
                });
#pragma warning restore 612, 618
        }
    }
}
