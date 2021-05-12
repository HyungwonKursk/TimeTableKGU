using System;
using System.Collections.Generic;
using System.Text;

namespace TimeTableKGU.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int? GroupId { get; set; }
        public int Subgroup { get; set; }
        public string Full_Name { get; set; }
        public bool Group_Leader { get; set; }
        public Group Group { get; set; }
    }
}
