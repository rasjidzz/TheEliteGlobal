using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace TPMODUL7_kelompokEliteGlobal_6
{
    internal class DataMahasiswa1302213045
    {
        public void READJSON()
        {
            string JSONString = File.ReadAllText(@"C:\Users\mrisj\Documents\TELKOM\Telkom University\Semester 4\Praktikum KPL\MODUL 7\TPMODUL7_kelompokEliteGlobal_6\tp7_1_1302213045.json");
            dynamic JSONObject = JsonConvert.DeserializeObject<dynamic>(JSONString);
            Console.WriteLine($"Nama '{JSONObject.nama.depan} {JSONObject.nama.belakang}' dengan nim '{JSONObject.nim}' dari fakultas {JSONObject.fakultas}");
        }
    }
}
