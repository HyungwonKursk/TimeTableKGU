﻿using System.Collections.Generic;
using TimeTableKGU.Models;
namespace TimeTableKGU.Data
{
    public class TimeTableData
    {
        public static List<TimeTable> TimeTables;
        static TimeTableData()
        {
            TimeTables = new List<TimeTable>();
            /*TimeTables.Add(new TimeTable("понедельник", "13.20-14.50", "Основы теории нейронных сетей(лек.)", "Добрица В.П.", 0, "ССЫЛКА", "числитель"));
            TimeTables.Add(new TimeTable("понедельник", "15.00-16.30", "Технология разработки программного обеспечения(лаб.)", "Ураева Е.Е.", 0, "ССЫЛКА", "числитель"));
            TimeTables.Add(new TimeTable( "вторник", "13.20-14.50", "Интернет-коммуникация на иностранном языке(пр.)", "Бурак М.А.", 0, "ССЫЛКА", "числитель"));
            TimeTables.Add(new TimeTable( "вторник", "15.00-16.30", "Основы теории нейронных сетей(лаб.)", "Добрица В.П.", 0, "ССЫЛКА", "числитель"));
            TimeTables.Add(new TimeTable( "среда", "13.20-14.50", "Зашита информации в компьютерных системах и сетях(лек.)", "Крыжевич Л.С.", 208, "", "числитель"));
            TimeTables.Add(new TimeTable("среда", "15.00-16.30", "Зашита информации в компьютерных системах и сетях(лаб.)", "Крыжевич Л.С.", 199, "", "числитель"));
            TimeTables.Add(new TimeTable( "среда", "16.40-18.10", "Эксплотация информационных систем и баз данных(лек.)", "Макаров К.С.", 209, "", "числитель"));
            TimeTables.Add(new TimeTable("четверг", "15.00-16.30", "Java-технологии(лек.)", "Белова Т.В.", 0, "ССЫЛКА", "числитель"));
            TimeTables.Add(new TimeTable( "четверг", "16.40-18.10", "Java-технологии(лаб.)", "Белова Т.В.", 0, "ССЫЛКА", "числитель"));
            TimeTables.Add(new TimeTable( "пятница", "13.20-14.50", "Технология разработки программного обеспечения(лаб.)", "Ураева Е.Е.", 198, "", "числитель"));
            TimeTables.Add(new TimeTable( "пятница", "15.00-16.30", "Технология разработки программного обеспечения(лек.)", "Ураева Е.Е.", 208, "", "числитель"));
            TimeTables.Add(new TimeTable( "пятница", "16.40-18.10", "Эксплотация информационных систем и баз данных(лаб.)", "Макаров К.С.", 203, "", "числитель"));
            TimeTables.Add(new TimeTable( "суббота", "08.00-09.30", "Администрирование 1С(лаб.)", "Чистилина Е.В.", 0, "ССЫЛКА", "числитель"));
            TimeTables.Add(new TimeTable( "суббота", "09.40-11.10", "Администрирование 1С(лек.)", "Чистилина Е.В.", 0, "ССЫЛКА", "числитель"));
            TimeTables.Add(new TimeTable( "суббота", "11.20-12.50", "Эксплотация информационных систем и баз данных(лаб.)", "Макаров К.С.", 0, "ССЫЛКА", "числитель"));

            TimeTables.Add(new TimeTable( "понедельник", "13.20-14.50", "Основы теории нейронных сетей(лек.)", "Добрица В.П.", 0, "ССЫЛКА", "знаменатель"));
            TimeTables.Add(new TimeTable( "понедельник", "15.00-16.30", "Технология разработки программного обеспечения(лаб.)", "Ураева Е.Е.", 0, "ССЫЛКА", "знаменатель"));
            TimeTables.Add(new TimeTable( "вторник", "13.20-14.50", "Интернет-коммуникация на иностранном языке(пр.)", "Добрица В.П.", 0, "ССЫЛКА", "знаменатель"));
            TimeTables.Add(new TimeTable( "вторник", "15.00-16.30", "Основы теории нейронных сетей(лаб.)", "Добрица В.П.", 0, "ССЫЛКА", "знаменатель"));
            TimeTables.Add(new TimeTable( "среда", "13.20-14.50", "Зашита информации в компьютерных системах и сетях(лек.)", "Крыжевич Л.С.", 208, "", "знаменатель"));
            TimeTables.Add(new TimeTable( "среда", "15.00-16.30", "Зашита информации в компьютерных системах и сетях(лаб.)", "Крыжевич Л.С.", 199, "", "знаменатель"));
            TimeTables.Add(new TimeTable( "среда", "16.40-18.10", "Эксплотация информационных систем и баз данных(лек.)", "Макаров К.С.", 209, "", "знаменатель"));
            TimeTables.Add(new TimeTable( "четверг", "15.00-16.30", "Java-технологии(лек.)", "Белова Т.В.", 0, "ССЫЛКА", "знаменатель"));
            TimeTables.Add(new TimeTable( "четверг", "16.40-18.10", "Java-технологии(лаб.)", "Белова Т.В.", 0, "ССЫЛКА", "знаменатель"));
            TimeTables.Add(new TimeTable( "пятница", "13.20-14.50", "Эксплотация информационных систем и баз данных(лаб.)", "Макаров К.С.", 203, "", "знаменатель"));
            TimeTables.Add(new TimeTable( "пятница", "15.00-16.30", "Технология разработки программного обеспечения(лек.)", "Ураева Е.Е.", 208, "", "знаменатель"));
            TimeTables.Add(new TimeTable( "пятница", "16.40-18.10", "Эксплотация информационных систем и баз данных(лаб.)", "Макаров К.С.", 203, "", "знаменатель"));
            TimeTables.Add(new TimeTable( "суббота", "08.00-09.30", "Администрирование 1С(лаб.)", "Чистилина Е.В.", 0, "ССЫЛКА", "знаменатель"));
            TimeTables.Add(new TimeTable( "суббота", "09.40-11.10", "Администрирование 1С(лек.)", "Чистилина Е.В.", 0, "ССЫЛКА", "знаменатель"));
            TimeTables.Add(new TimeTable( "суббота", "11.20-12.50", "Администрирование 1С(лаб.)", "Чистилина Е.В.", 0, "ССЫЛКА", "знаменатель"));*/
        }
    }
}
