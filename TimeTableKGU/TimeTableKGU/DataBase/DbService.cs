using System;
using System.Collections.Generic;
using TimeTableKGU.Models;
using TimeTableKGU.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace TimeTableKGU.DataBase
{
    public static class DbService
    {
        private static ApplicationContext db = new ApplicationContext();
        /// <summary>
        /// Обновление базы данных
        /// </summary>
        /// <param name="delete">если true очитстить текущую базу</param>
        public static void RefrashDb(bool delete = false)
        {
            // Удаляем бд, если она существуеты
           // if (delete)
                db.Database.EnsureDeleted();

            // Создаем бд, если она отсутствует
            db.Database.EnsureCreated();
           DbService.AddTimeTable(TimeTableData.TimeTables);
            List<TimeTable> t = new List<TimeTable>();
            t = DbService.LoadAllTimeTable();
            DbService.RemoveTimeTable(TimeTableData.TimeTables[0]);
            t = DbService.LoadAllTimeTable();
            /*DbService.AddTimeTable(TimeTableData.TimeTables[0]);
            DbService.AddTimeTable(TimeTableData.TimeTables[1]);
            DbService.AddTimeTable(TimeTableData.TimeTables[2]);
            DbService.AddTimeTable(TimeTableData.TimeTables[3]);
            

            DbService.AddStudent(new Student(0, "sff", "sjfrge", 7, 9, "sfsj we", true));
            DbService.AddStudent(new Student(0, "sff", "sjfrge", 7, 9, "sfsj we", false));

            List<Student> s = new List<Student>();
            s = DbService.LoadAllStudent();

            DbService.AddTeacher(new Teacher(0, "DFV", "SFNJ", "DF", "SF", "FGSG"));
            DbService.AddTeacher(new Teacher(0, "DFV", "SFNJ", "DF", "SF", "FGSGS"));

            List<Teacher> tr = new List<Teacher>();
            tr = DbService.LoadAllTeacher();*/
        }

        public static void SaveDb()
        {
            db.SaveChanges();
        }
        /// <summary>
        /// Загрузить все данные из базы в память (при запуске)
        /// </summary>
        public static void LoadAll()
        {
          
            
        }
        #region TimeTable
        public static void AddTimeTable(TimeTable timetable)
        {
            if (timetable == null) return;
            db.TimeTables.Add(timetable);
            db.SaveChanges();
        }
        public static void AddTimeTable(List<TimeTable> timetables)
        {

            if (timetables == null) return;

            foreach (var timetable in timetables)
                db.TimeTables.Add(timetable);

            db.SaveChanges();

        }
        public static void RemoveTimeTable(TimeTable timetable)
        {
            if (timetable == null) return;
            db.TimeTables.Remove(timetable);

            db.SaveChanges();
        }

        public static void RemoveTimeTable(List<TimeTable> timetables)
        {
            foreach (var timetable in timetables)
            {
                db.TimeTables.Remove(timetable);
            }
            db.SaveChanges();
        }
        public static List<TimeTable> LoadAllTimeTable()
        {
            return db.TimeTables.ToList();
        }
        #endregion

        #region Student
        public static void AddStudent(Student student)
        {
            if (student == null) return;
            db.Students.Add(student);
            db.SaveChanges();
        }

        public static void RemoveStudent(Student student)
        {
            if (student == null) return;
            db.Students.Remove(student);
            db.SaveChanges();
        }

        public static List<Student> LoadAllStudent()
        {
            return db.Students.ToList();
        }

        #endregion

        #region Teacher
        public static void AddTeacher(Teacher teacher)
        {
            if (teacher == null) return;
            db.Teachers.Add(teacher);
            db.SaveChanges();
        }
        public static void RemoveTeacher(Teacher teacher)
        {
            if (teacher == null) return;
            db.Teachers.Remove(teacher);
            db.SaveChanges();
        }

        public static List<Teacher> LoadAllTeacher()
        {
            return db.Teachers.ToList();
        }

        #endregion
    }
}

