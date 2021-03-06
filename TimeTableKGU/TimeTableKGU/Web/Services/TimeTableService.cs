using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TimeTableKGU.Models;

namespace TimeTableKGU.Web.Services
{
    class TimeTableService
    {
        const string Url = WebData.ADRESS + "lessonsapi";


        // получаем расписание для студента
        public async Task<List<TimeTable>> GetStudentTimeTable(int group, int subgroup)
        {
            HttpClient client = WebData.GetClient();
            string result = await client.GetStringAsync(Url+"/"+group+"/"+subgroup);
            return JsonConvert.DeserializeObject<List<TimeTable>>(result);
        }

        public async Task<List<TimeTable>> GetTeacherTimeTable(int teacherid)
        {
            HttpClient client = WebData.GetClient();
            string result = await client.GetStringAsync(Url + teacherid);
            return JsonConvert.DeserializeObject<List<TimeTable>>(result);
        }
    }
}
