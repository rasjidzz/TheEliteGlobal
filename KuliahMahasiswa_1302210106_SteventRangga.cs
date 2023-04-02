using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text.Json.Nodes;

namespace TPMODUL7_kelompokEliteGlobal_6
{
    internal class KuliahMahasiswa_1302210106_SteventRangga
    {
        public void ReadJson()
        {
            string json = File.ReadAllText(@"D:\Coding\C#\TP_MOD7\TheEliteGlobal\tp7_2_1302210106.json");

            dynamic jsonc = JsonConvert.DeserializeObject(json);

            Console.WriteLine("Daftar mata kuliah yang diambil:");
            int i = 1;
            foreach (var course in jsonc.courses)
            {
                Console.WriteLine($"MK {i} {course.code}-{course.name}");
                i++;
            }
        }
    }
}
