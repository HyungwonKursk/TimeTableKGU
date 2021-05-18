using System.Collections.Generic;
using TimeTableKGU.Models;
namespace TimeTableKGU.Data
{
    public class TimeTableData
    {
        public static List<TimeTable> TimeTables;
        static TimeTableData()
        {
            TimeTables = new List<TimeTable>();
            TimeTables.Add(new TimeTable("понедельник", "13.20-14.50","Основы теории нейронных сетей(лек.)", "Добрица В.П.", 0, "ССЫЛКА", "числитель"));
            TimeTables.Add(new TimeTable("понедельник", "15.00-16.30","Технология разработки программного обеспечения(лаб.)", "Ураева Е.Е.", 0, "ССЫЛКА", "числитель"));
            TimeTables.Add(new TimeTable("вторник", "13.20-14.50", "Интернет-коммуникация на иностранном языке(пр.)", "Добрица В.П.", 0, "ССЫЛКА", "числитель"));
            TimeTables.Add(new TimeTable("вторник", "15.00-16.30", "Основы теории нейронных сетей(пр.)", "Добрица В.П.", 0, "ССЫЛКА", "числитель"));
            TimeTables.Add(new TimeTable("среда", "13.20-14.50", "Зашита информации в компьютерных системах и сетях(лек.)", "Крыжевич Л.С.", 208, "", "числитель"));
            TimeTables.Add(new TimeTable("среда", "15.00-16.30", "Зашита информации в компьютерных системах и сетях(пр.)", "Крыжевич Л.С.", 199, "", "числитель"));
            TimeTables.Add(new TimeTable("среда", "16.40-18.10", "Эксплотация информационных систем и баз данных(лек.)", "Макаров К.С.", 209, "", "числитель"));
        }
    }
}
