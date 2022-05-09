﻿// <auto-generated />
using System;
using BlogSiteProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlogSiteProject.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BlogSiteProject.Models.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AvgReadTime")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TotalReadCount")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("BlogSiteProject.Models.ArticlesAndTopics", b =>
                {
                    b.Property<int>("ArticleId")
                        .HasColumnType("int");

                    b.Property<int>("TopicId")
                        .HasColumnType("int");

                    b.HasKey("ArticleId", "TopicId");

                    b.HasIndex("TopicId");

                    b.ToTable("ArticlesAndTopics");
                });

            modelBuilder.Entity("BlogSiteProject.Models.Topic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TotalUse")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Topics");
                });

            modelBuilder.Entity("BlogSiteProject.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Picture")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserRegisterId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserRegisterId")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BlogSiteProject.Models.UserRegister", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserRegisters");
                });

            modelBuilder.Entity("BlogSiteProject.Models.UsersAndTopics", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("TopicId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "TopicId");

                    b.HasIndex("TopicId");

                    b.ToTable("UsersAndTopics");
                });

            modelBuilder.Entity("BlogSiteProject.Models.Article", b =>
                {
                    b.HasOne("BlogSiteProject.Models.User", "User")
                        .WithMany("Articles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("BlogSiteProject.Models.ArticlesAndTopics", b =>
                {
                    b.HasOne("BlogSiteProject.Models.Article", "Article")
                        .WithMany("ArticlesAndTopics")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlogSiteProject.Models.Topic", "Topic")
                        .WithMany("ArticlesAndTopics")
                        .HasForeignKey("TopicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");

                    b.Navigation("Topic");
                });

            modelBuilder.Entity("BlogSiteProject.Models.User", b =>
                {
                    b.HasOne("BlogSiteProject.Models.UserRegister", "UserRegister")
                        .WithOne("User")
                        .HasForeignKey("BlogSiteProject.Models.User", "UserRegisterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserRegister");
                });

            modelBuilder.Entity("BlogSiteProject.Models.UsersAndTopics", b =>
                {
                    b.HasOne("BlogSiteProject.Models.Topic", "Topic")
                        .WithMany("UsersAndTopics")
                        .HasForeignKey("TopicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlogSiteProject.Models.User", "User")
                        .WithMany("UsersAndTopics")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Topic");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BlogSiteProject.Models.Article", b =>
                {
                    b.Navigation("ArticlesAndTopics");
                });

            modelBuilder.Entity("BlogSiteProject.Models.Topic", b =>
                {
                    b.Navigation("ArticlesAndTopics");

                    b.Navigation("UsersAndTopics");
                });

            modelBuilder.Entity("BlogSiteProject.Models.User", b =>
                {
                    b.Navigation("Articles");

                    b.Navigation("UsersAndTopics");
                });

            modelBuilder.Entity("BlogSiteProject.Models.UserRegister", b =>
                {
                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
