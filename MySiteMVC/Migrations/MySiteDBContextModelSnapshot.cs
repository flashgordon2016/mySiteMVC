﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MySiteMVC.Models;

namespace MySiteMVC.Migrations
{
    [DbContext(typeof(MySiteDBContext))]
    partial class MySiteDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

            modelBuilder.Entity("MySiteMVC.Models.Education", b =>
                {
                    b.Property<int>("EducationId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Credits");

                    b.Property<string>("Degree");

                    b.Property<DateTime>("EndDate");

                    b.Property<double>("GPA");

                    b.Property<string>("Institution")
                        .IsRequired();

                    b.Property<string>("Logo")
                        .IsRequired();

                    b.Property<string>("Major");

                    b.Property<DateTime>("StartDate");

                    b.Property<int?>("TermTypeId");

                    b.Property<string>("Website");

                    b.HasKey("EducationId");

                    b.HasIndex("TermTypeId");

                    b.ToTable("Education");
                });

            modelBuilder.Entity("MySiteMVC.Models.EducationProjects", b =>
                {
                    b.Property<int>("EducationId");

                    b.Property<int>("ProjectId");

                    b.HasKey("EducationId", "ProjectId");

                    b.HasIndex("ProjectId");

                    b.ToTable("EducationProjects");
                });

            modelBuilder.Entity("MySiteMVC.Models.EducationSkills", b =>
                {
                    b.Property<int>("EducationId");

                    b.Property<int>("SkillId");

                    b.HasKey("EducationId", "SkillId");

                    b.HasIndex("SkillId");

                    b.ToTable("EducationSkills");
                });

            modelBuilder.Entity("MySiteMVC.Models.Experience", b =>
                {
                    b.Property<int>("ExperienceId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<DateTime>("EndDate");

                    b.Property<string>("JobTitle")
                        .IsRequired();

                    b.Property<string>("OrgLogo");

                    b.Property<string>("Organization")
                        .IsRequired();

                    b.Property<DateTime>("StartDate");

                    b.HasKey("ExperienceId");

                    b.ToTable("Experience");
                });

            modelBuilder.Entity("MySiteMVC.Models.ExperienceSkills", b =>
                {
                    b.Property<int>("ExperienceId");

                    b.Property<int>("SkillId");

                    b.HasKey("ExperienceId", "SkillId");

                    b.HasIndex("SkillId");

                    b.ToTable("ExperienceSkills");
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

            modelBuilder.Entity("MySiteMVC.Models.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DemoLink");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<int?>("ExperienceId");

                    b.Property<string>("SourceCode");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<string>("Video");

                    b.HasKey("ProjectId");

                    b.HasIndex("ExperienceId");

                    b.ToTable("Project");
                });

            modelBuilder.Entity("MySiteMVC.Models.ProjectSkills", b =>
                {
                    b.Property<int>("ProjectId");

                    b.Property<int>("SkillId");

                    b.HasKey("ProjectId", "SkillId");

                    b.HasIndex("SkillId");

                    b.ToTable("ProjectSkills");
                });

            modelBuilder.Entity("MySiteMVC.Models.ProjectTags", b =>
                {
                    b.Property<int>("TagId");

                    b.Property<int>("ProjectId");

                    b.HasKey("TagId", "ProjectId");

                    b.HasIndex("ProjectId");

                    b.ToTable("ProjectTags");
                });

            modelBuilder.Entity("MySiteMVC.Models.Skill", b =>
                {
                    b.Property<int>("SkillId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<double>("YearsOfExperience");

                    b.HasKey("SkillId");

                    b.ToTable("Skill");
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

            modelBuilder.Entity("MySiteMVC.Models.TermType", b =>
                {
                    b.Property<int>("TermTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Term")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.HasKey("TermTypeId");

                    b.ToTable("TermTypes");
                });

            modelBuilder.Entity("MySiteMVC.Models.Education", b =>
                {
                    b.HasOne("MySiteMVC.Models.TermType", "TermType")
                        .WithMany("Education")
                        .HasForeignKey("TermTypeId");
                });

            modelBuilder.Entity("MySiteMVC.Models.EducationProjects", b =>
                {
                    b.HasOne("MySiteMVC.Models.Education", "Education")
                        .WithMany("EducationProjects")
                        .HasForeignKey("EducationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MySiteMVC.Models.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MySiteMVC.Models.EducationSkills", b =>
                {
                    b.HasOne("MySiteMVC.Models.Education", "Education")
                        .WithMany("EducationSkills")
                        .HasForeignKey("EducationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MySiteMVC.Models.Skill", "Skill")
                        .WithMany("SkillEducation")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MySiteMVC.Models.ExperienceSkills", b =>
                {
                    b.HasOne("MySiteMVC.Models.Experience", "Experience")
                        .WithMany()
                        .HasForeignKey("ExperienceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MySiteMVC.Models.Skill", "Skill")
                        .WithMany("SkillExperience")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade);
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

            modelBuilder.Entity("MySiteMVC.Models.Project", b =>
                {
                    b.HasOne("MySiteMVC.Models.Experience", "Experience")
                        .WithMany("Projects")
                        .HasForeignKey("ExperienceId");
                });

            modelBuilder.Entity("MySiteMVC.Models.ProjectSkills", b =>
                {
                    b.HasOne("MySiteMVC.Models.Project", "Project")
                        .WithMany("ProjectSkills")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MySiteMVC.Models.Skill", "Skill")
                        .WithMany("SkillProjects")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MySiteMVC.Models.ProjectTags", b =>
                {
                    b.HasOne("MySiteMVC.Models.Project", "Project")
                        .WithMany("ProjectTags")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MySiteMVC.Models.Tag", "Tag")
                        .WithMany()
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}