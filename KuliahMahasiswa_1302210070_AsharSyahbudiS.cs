using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TPMODUL7_kelompokEliteGlobal_6
{
    internal class KuliahMahasiswa_1302210070_AsharSyahbudiS
    {
        public void ReadJSON()
        {

            string jsonString = File.ReadAllText(@"D:\TELKOM\Pembelajaran\Semester 4\KPL\TP\clone repo\TheEliteGlobal\tp7_2_1302210070.json");

            dynamic jsonObject = JsonConvert.DeserializeObject(jsonString);

            Console.WriteLine("Daftar mata kuliah yang diambil:");
            int iter = 1;
            foreach (var course in jsonObject.courses)
            {
                Console.WriteLine($"MK {iter} {course.code}-{course.name}");
                iter++;
            }

        }
    }

}
