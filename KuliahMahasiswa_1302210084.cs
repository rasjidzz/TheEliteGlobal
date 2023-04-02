using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace TPMODUL7_kelompokEliteGlobal_6
{
    internal class KuliahMahasiswa_1302210084
    {
        public void ReadJSON()
        {
            String jsonStrng = File.ReadAllText(@"C:\Users\surya\Documents\KPL Praktikum\TP_MOD7_1302210084\TheEliteGlobal\tp7_2_1302210084.json");
            dynamic jsonObject = JsonConvert.DeserializeObject(jsonStrng);
            int i = 0;
            Console.WriteLine("Daftar Matakuliah : ");
            foreach (var course in jsonObject.courses)
            {
                Console.WriteLine($"MataKuliah : {i+1} {course.code} - {course.name}");
                i++;
            }

        }
    }
}