using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MySiteMVC.Models
{
    public partial class MySiteDBContext : DbContext
    {
        public MySiteDBContext()
        {
        }

        public MySiteDBContext(DbContextOptions<MySiteDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BlogPost> BlogPost { get; set; }
        public virtual DbSet<Tag> Tag { get; set; }
        public virtual DbSet<PostTagsJunction> PostTagsJunction { get; set; }
        public virtual DbSet<Project> Project { get; set; }
        public virtual DbSet<ProjectTags> ProjectTags { get; set; }
        public virtual DbSet<Education> Education { get; set; }
        public virtual DbSet<EducationProjects> EducationProjects { get; set; }
        public virtual DbSet<Experience> Experience { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                /*#warning To protect potentially sensitive information in your connection string, you should move it out of 
                 * source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.*/
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MySiteDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BlogPost>(entity =>
            {
                entity.ToTable("Blog_Post");

                entity.Property(e => e.BlogPostId).HasColumnName("Blog_PostID");

                entity.Property(e => e.Content).IsRequired();

                entity.Property(e => e.OriginalPostDate)
                    .HasColumnName("Original_Post_Date")
                    .HasColumnType("date");

                entity.Property(e => e.Summary).IsRequired();

                entity.Property(e => e.Title).IsRequired();

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("Updated_Date")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<PostTagsJunction>(entity =>
            {
                //composite key
                entity.HasKey(e => new { e.TagId, e.BlogPostId });

                entity.ToTable("Post_Tags_Junction");

                entity.Property(e => e.TagId).HasColumnName("TagID");

                entity.Property(e => e.BlogPostId).HasColumnName("Blog_PostID");

                entity.HasOne(d => d.BlogPost)
                    .WithMany(p => p.PostTagsJunction)
                    .HasForeignKey(d => d.BlogPostId)
                    .HasConstraintName("FK_Blog_Post");

                entity.HasOne(d => d.Tag)
                    .WithMany(p => p.PostTagsJunction)
                    .HasForeignKey(d => d.TagId)
                    .HasConstraintName("FK_Tag");
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.Property(e => e.TagId).HasColumnName("TagID");
                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<ProjectTags>(entity =>
            {
                entity.HasKey(e => new { e.TagId, e.ProjectId });
            });

            modelBuilder.Entity<EducationProjects>(entity =>
            {
                entity.HasKey(e => new { e.EducationId, e.ProjectId });
            });
        }
    }
}
