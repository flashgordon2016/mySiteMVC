﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MySiteMVC.Models;

namespace MySiteMVC.Migrations
{
    [DbContext(typeof(MySiteDBContext))]
    [Migration("20180821215244_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MySiteMVC.Models.BlogPost", b =>
                {
                    b.Property<int>("BlogPostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Blog_PostID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BannerImgPath");

                    b.Property<string>("Content")
                        .IsRequired();

                    b.Property<DateTime>("OriginalPostDate")
                        .HasColumnName("Original_Post_Date")
                        .HasColumnType("date");

                    b.Property<string>("Summary")
                        .IsRequired();

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnName("Updated_Date")
                        .HasColumnType("date");

                    b.HasKey("BlogPostId");

                    b.ToTable("Blog_Post");
                });

            modelBuilder.Entity("MySiteMVC.Models.PostTagsJunction", b =>
                {
                    b.Property<int>("TagId")
                        .HasColumnName("TagID");

                    b.Property<int>("BlogPostId")
                        .HasColumnName("Blog_PostID");

                    b.HasKey("TagId", "BlogPostId");

                    b.HasIndex("BlogPostId");

                    b.ToTable("Post_Tags_Junction");
                });

            modelBuilder.Entity("MySiteMVC.Models.Tag", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("TagID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("TagId");

                    b.ToTable("Tag");
                });

            modelBuilder.Entity("MySiteMVC.Models.PostTagsJunction", b =>
                {
                    b.HasOne("MySiteMVC.Models.BlogPost", "BlogPost")
                        .WithMany("PostTagsJunction")
                        .HasForeignKey("BlogPostId")
                        .HasConstraintName("FK_Blog_Post")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MySiteMVC.Models.Tag", "Tag")
                        .WithMany("PostTagsJunction")
                        .HasForeignKey("TagId")
                        .HasConstraintName("FK_Tag")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
