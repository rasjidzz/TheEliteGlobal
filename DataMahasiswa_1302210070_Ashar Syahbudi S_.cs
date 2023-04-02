using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TPMODUL7_kelompokEliteGlobal_6
{
    internal class DataMahasiswa_1302210070_Ashar_Syahbudi_S_
    {
        public void ReadJSON()
        {

            string jsonString = File.ReadAllText(@"D:\TELKOM\Pembelajaran\Semester 4\KPL\TP\clone repo\TheEliteGlobal\tp7_1_1302210070.json");

            dynamic jsonObject = JsonConvert.DeserializeObject(jsonString);

            Console.WriteLine($"Nama {jsonObject.nama.depan} {jsonObject.nama.belakang} dengan nim {jsonObject.nim} dari fakultas {jsonObject.fakultas}");
        }
    }
}

