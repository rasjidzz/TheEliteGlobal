using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMODUL7_kelompokEliteGlobal_6
{
    internal class KuliahMahasiswa_1302210036_Zhafran
    {
        public void ReadJSON()
        {
            string JSONStr = File.ReadAllText(@"D:\Telkom Univ\Tingkat 2 (Sem 3-4)\Semester 4\Konstruksi PL\Praktikum\TP\MOD7\TheEliteGlobal\tp7_2_1302210036.json");
            dynamic JSONObj = JsonConvert.DeserializeObject<dynamic>(JSONStr);

            int i = 0;
            Console.WriteLine("Daftar Matakuliah : ");
            foreach (var course in JSONObj.courses)
            {
                Console.WriteLine($"MataKuliah : {i} {course.code} - {course.name}");
                i++;
            }
        }
    }
}
