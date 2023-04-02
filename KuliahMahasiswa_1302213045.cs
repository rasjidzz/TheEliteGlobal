using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMODUL7_kelompokEliteGlobal_6
{
    internal class KuliahMahasiswa_1302213045
    {
        public void ReadJSON()
        {
            string JSONString = File.ReadAllText(@"C:\Users\mrisj\Documents\TELKOM\Telkom University\Semester 4\Praktikum KPL\MODUL 7\TPMODUL7_kelompokEliteGlobal_6\tp7_2_1302213045.json");
            dynamic JSONObject = JsonConvert.DeserializeObject<dynamic>(JSONString);

            int i = 0;
            Console.WriteLine("Daftar Matakuliah : ");
            foreach (var course in JSONObject.courses)
            {
                Console.WriteLine($"MataKuliah : {i} {course.code} - {course.name}");
                i++;
            }
        }
    }
}
