using System;
using Microsoft.EntityFrameworkCore;
using TimeTableKGU.Models;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace TimeTableKGU.DataBase
{
    public class ApplicationContext : DbContext
    {

        // списки подключенных таблиц
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Direction> Directions { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Week> Weeks { get; set; }

        private string databaseName;

        public ApplicationContext(string databasePath = "database.db")
        {
            databaseName = databasePath;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Direction>()
                              .HasMany(m => m.Groups)
                              .WithOne(t => t.Direction)
                              .HasForeignKey(m => m.GroupId)
                              .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Group>()
                              .HasMany(m => m.Students)
                              .WithOne(t => t.Group)
                              .HasForeignKey(m => m.StudentId)
                              .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Group>()
                              .HasMany(m => m.Lessons)
                              .WithOne(t => t.Group)
                              .HasForeignKey(m => m.LessonId)
                              .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Room>()
                              .HasMany(m => m.Lessons)
                              .WithOne(t => t.Classroom)
                              .HasForeignKey(m => m.LessonId)
                              .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Subject>()
                              .HasMany(m => m.Lessons)
                              .WithOne(t => t.Subject)
                              .HasForeignKey(m => m.LessonId)
                              .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Teacher>()
                                 .HasMany(m => m.Lessons)
                                 .WithOne(t => t.Teacher)
                                 .HasForeignKey(m => m.LessonId)
                                 .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Week>()
                                 .HasMany(m => m.Lessons)
                                 .WithOne(t => t.Week)
                                 .HasForeignKey(m => m.LessonId)
                                 .OnDelete(DeleteBehavior.NoAction);



        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            String databasePath =
              Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), databaseName);

            optionsBuilder.UseSqlite($"Filename={databasePath}");
        }
    }
}
