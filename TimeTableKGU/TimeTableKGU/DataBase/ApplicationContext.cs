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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            String databasePath =
              Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), databaseName);

            optionsBuilder.UseSqlite($"Filename={databasePath}");
        }
    }
}
