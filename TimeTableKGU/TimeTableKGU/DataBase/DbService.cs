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
            if (delete)
                db.Database.EnsureDeleted();

            // Создаем бд, если она отсутствует
            db.Database.EnsureCreated();
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
            DirectionData.Directions = LoadAllDirections();
            GroupData.Groups = LoadAllGroups();
            LessonData.Lessons = LoadAllLessons();
            RoomData.Rooms = LoadAllRooms();
            StudentData.Students = LoadAllStudents();
            SubjectData.Subjects = LoadAllSubjects();
            TeacherData.Teachers = LoadAllTeachers();
            WeekData.Weeks = LoadAllWeeks();
            
        }

        #region Group

        public static void AddGroup(Group group)
        {
            if (group == null) return;
            db.Groups.Add(group);
            db.SaveChanges();
        }

        public static void AddGroup(List<Group> groups)
        {
            if (groups == null) return;

            foreach (var group in groups)
                db.Groups.Add(group);

            db.SaveChanges();
        }
        public static void RemoveGroup(Group group)
        {
            if (group == null) return;
            db.Groups.Remove(group);

            db.SaveChanges();
        }
        public static void RemoveGroup(List<Group> groups)
        {
            foreach (var group in groups)
            {
                db.Groups.Remove(group);
            }
            db.SaveChanges();
        }

        public static List<Group> LoadAllGroups()
        {
            return db.Groups.ToList();
        }

        #endregion
        #region Direction

        public static void AddDirection(Direction direction)
        {
            if (direction == null) return;
            db.Directions.Add(direction);
            db.SaveChanges();
        }

        public static void AddDirection(List<Direction> directions)
        {
            if (directions == null) return;

            foreach (var direction in directions)
                db.Directions.Add(direction);

            db.SaveChanges();
        }
        public static void RemoveDirection(Direction direction)
        {
            if (direction == null) return;
            db.Directions.Remove(direction);

            db.SaveChanges();
        }
        public static void RemoveDirection(List<Direction> directions)
        {
            foreach (var direction in directions)
            {
                db.Directions.Remove(direction);
            }
            db.SaveChanges();
        }

        public static List<Direction> LoadAllDirections()
        {
            return db.Directions.ToList();
        }

        #endregion
        #region Lesson

        public static void AddLesson(Lesson lesson)
        {
            if (lesson == null) return;
            db.Lessons.Add(lesson);
            db.SaveChanges();
        }

        public static void AddLesson(List<Lesson> lessons)
        {
            if (lessons == null) return;

            foreach (var lesson in lessons)
                db.Lessons.Add(lesson);

            db.SaveChanges();
        }
        public static void RemoveLesson(Lesson lesson)
        {
            if (lesson == null) return;
            db.Lessons.Remove(lesson);

            db.SaveChanges();
        }
        public static void RemoveLesson(List<Lesson> lessons)
        {
            foreach (var lesson in lessons)
            {
                db.Lessons.Remove(lesson);
            }
            db.SaveChanges();
        }

        public static List<Lesson> LoadAllLessons()
        {
            return db.Lessons.ToList();
        }

        #endregion
        #region Room

        public static void AddRoom(Room room)
        {
            if (room == null) return;
            db.Rooms.Add(room);
            db.SaveChanges();
        }

        public static void AddRoom(List<Room> rooms)
        {
            if (rooms == null) return;

            foreach (var room in rooms)
                db.Rooms.Add(room);

            db.SaveChanges();
        }
        public static void RemoveRoom(Room room)
        {
            if (room == null) return;
            db.Rooms.Remove(room);

            db.SaveChanges();
        }

        public static void RemoveRoom(List<Room> rooms)
        {
            foreach (var room in rooms)
            {
                db.Rooms.Remove(room);
            }
            db.SaveChanges();
        }

        public static List<Room> LoadAllRooms()
        {
            return db.Rooms.ToList();
        }

        #endregion
        #region Student

        public static void AddStudent(Student student)
        {
            if (student == null) return;
            db.Students.Add(student);
            db.SaveChanges();
        }

        public static void AddStudent(List<Student> students)
        {
            if (students == null) return;

            foreach (var student in students)
                db.Students.Add(student);

            db.SaveChanges();
        }
        public static void RemoveStudent(Student student)
        {
            if (student == null) return;
            db.Students.Remove(student);

            db.SaveChanges();
        }

        public static void RemoveStudent(List<Student> students)
        {
            foreach (var student in students)
            {
                db.Students.Remove(student);
            }
            db.SaveChanges();
        }

        public static List<Student> LoadAllStudents()
        {
            return db.Students.ToList();
        }

        #endregion
        #region Subject

        public static void AddSubject(Subject subject)
        {
            if (subject == null) return;
            db.Subjects.Add(subject);
            db.SaveChanges();
        }

        public static void AddSubject(List<Subject> subjects)
        {
            if (subjects == null) return;

            foreach (var subject in subjects)
                db.Subjects.Add(subject);

            db.SaveChanges();
        }
        public static void RemoveSubject(Subject subject)
        {
            if (subject == null) return;
            db.Subjects.Remove(subject);

            db.SaveChanges();
        }

        public static void RemoveSubject(List<Subject> subjects)
        {
            foreach (var subject in subjects)
            {
                db.Subjects.Remove(subject);
            }
            db.SaveChanges();
        }

        public static List<Subject> LoadAllSubjects()
        {
            return db.Subjects.ToList();
        }

        #endregion
        #region Teacher

        public static void AddTeacher(Teacher teacher)
        {
            if (teacher == null) return;
            db.Teachers.Add(teacher);
            db.SaveChanges();
        }

        public static void AddTeacher(List<Teacher> teachers)
        {
            if (teachers == null) return;

            foreach (var teacher in teachers)
                db.Teachers.Add(teacher);

            db.SaveChanges();
        }
        public static void RemoveTeacher(Teacher teacher)
        {
            if (teacher == null) return;
            db.Teachers.Remove(teacher);

            db.SaveChanges();
        }

        public static void RemoveTeacher(List<Teacher> teachers)
        {
            foreach (var teacher in teachers)
            {
                db.Teachers.Remove(teacher);
            }
            db.SaveChanges();
        }

        public static List<Teacher> LoadAllTeachers()
        {
            return db.Teachers.ToList();
        }

        #endregion
        #region Week

        public static void AddWeek(Week week)
        {
            if (week == null) return;
            db.Weeks.Add(week);
            db.SaveChanges();
        }

        public static void AddWeek(List<Week> weeks)
        {
            if (weeks == null) return;

            foreach (var week in weeks)
                db.Weeks.Add(week);

            db.SaveChanges();
        }
        public static void RemoveWeek(Week week)
        {
            if (week == null) return;
            db.Weeks.Remove(week);

            db.SaveChanges();
        }

        public static void RemoveWeekr(List<Week> weeks)
        {
            foreach (var week in weeks)
            {
                db.Weeks.Remove(week);
            }
            db.SaveChanges();
        }

        public static List<Week> LoadAllWeeks()
        {
            return db.Weeks.ToList();
        }

        #endregion
    }
}

