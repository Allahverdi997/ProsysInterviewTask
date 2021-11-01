using ExamProgramEntities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProgramCoreLayer.DataAccessLayer.EntityFrameworkCore
{
    public class ExamProgramDbContext:DbContext
    {
        public ExamProgramDbContext(DbContextOptions<ExamProgramDbContext> options):base(options)
        {

        }

        public DbSet<ExamResult> ExamResults { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Lesson> Lessons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ExamResult>().HasKey(x => x.Id);
            modelBuilder.Entity<Student>().HasKey(x => x.StudentNumber);
            modelBuilder.Entity<Lesson>().HasKey(x => x.LessonCode);
        }
    }
}
