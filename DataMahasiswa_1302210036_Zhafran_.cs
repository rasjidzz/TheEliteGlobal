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

            string jsonString = File.ReadAllText(@"D:\Telkom Univ\Tingkat 2 (Sem 3-4)\Semester 4\Konstruksi PL\Praktikum\TP\MOD7\TheEliteGlobal\tp7_1_1302210036.json");

            dynamic jsonObject = JsonConvert.DeserializeObject(jsonString);

            Console.WriteLine($"Nama {jsonObject.nama.depan} {jsonObject.nama.belakang} dengan nim {jsonObject.nim} dari fakultas {jsonObject.fakultas}");
        }
    }
}

