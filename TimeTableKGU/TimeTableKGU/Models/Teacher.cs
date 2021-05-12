using System;
using System.Collections.Generic;
using System.Text;

namespace TimeTableKGU.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public string Full_Name { get; set; }
        public ICollection<Lesson> Lessons { get; set; }
        public Teacher()
        {
            Lessons = new List<Lesson>();
        }
    }
}
