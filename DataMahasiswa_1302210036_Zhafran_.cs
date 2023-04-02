using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TPMODUL7_kelompokEliteGlobal_6
{
    internal class DataMahasiswa_1302210036_Zhafran_Hafizh
    {
        public void ReadJSON()
        {

            string jsonStr = File.ReadAllText(@"D:\Telkom Univ\Tingkat 2 (Sem 3-4)\Semester 4\Konstruksi PL\Praktikum\TP\MOD7\TheEliteGlobal\tp7_1_1302210036.json");

            dynamic jsonObj = JsonConvert.DeserializeObject(jsonStr);

            Console.WriteLine($"Nama {jsonObj.nama.depan} {jsonObj.nama.belakang} dengan nim {jsonObj.nim} dari fakultas {jsonObj.fakultas}");
        }
    }
}

