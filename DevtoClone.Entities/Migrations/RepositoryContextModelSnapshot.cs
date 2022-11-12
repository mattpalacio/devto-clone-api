﻿// <auto-generated />
using System;
using DevtoClone.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DevtoClone.Entities.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    partial class RepositoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DevtoClone.Entities.Models.Post", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("PostId");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("DevtoClone.Entities.Models.Tag", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("TagId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Tags");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9ac89a6d-d440-455b-b303-a6d52b4e12b3"),
                            Name = "html"
                        },
                        new
                        {
                            Id = new Guid("84f16bfd-5c77-47d1-8301-3d567b6acbc1"),
                            Name = "css"
                        },
                        new
                        {
                            Id = new Guid("5d11cde9-98ee-4844-8845-09714c472740"),
                            Name = "javascript"
                        });
                });

            modelBuilder.Entity("DevtoClone.Entities.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("UserId");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("JoinedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("015e75c9-b674-4f52-905c-0fa19c29abe1"),
                            Email = "matt@email.com",
                            JoinedDate = new DateTime(2022, 11, 12, 7, 21, 13, 33, DateTimeKind.Utc).AddTicks(6879),
                            Username = "matt"
                        },
                        new
                        {
                            Id = new Guid("ec772a59-3617-4fc6-a971-a45730f87c55"),
                            Email = "patrick@email.com",
                            JoinedDate = new DateTime(2022, 11, 12, 7, 21, 13, 33, DateTimeKind.Utc).AddTicks(6882),
                            Username = "patrick"
                        },
                        new
                        {
                            Id = new Guid("cddabe69-be5c-43be-ab25-5f3e5818b813"),
                            Email = "anne@email.com",
                            JoinedDate = new DateTime(2022, 11, 12, 7, 21, 13, 33, DateTimeKind.Utc).AddTicks(6883),
                            Username = "anne"
                        });
                });

            modelBuilder.Entity("PostTag", b =>
                {
                    b.Property<Guid>("PostsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TagsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PostsId", "TagsId");

                    b.HasIndex("TagsId");

                    b.ToTable("PostTag");
                });

            modelBuilder.Entity("DevtoClone.Entities.Models.Post", b =>
                {
                    b.HasOne("DevtoClone.Entities.Models.User", "User")
                        .WithMany("Posts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("PostTag", b =>
                {
                    b.HasOne("DevtoClone.Entities.Models.Post", null)
                        .WithMany()
                        .HasForeignKey("PostsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DevtoClone.Entities.Models.Tag", null)
                        .WithMany()
                        .HasForeignKey("TagsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DevtoClone.Entities.Models.User", b =>
                {
                    b.Navigation("Posts");
                });
#pragma warning restore 612, 618
        }
    }
}
