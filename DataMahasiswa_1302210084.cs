using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMODUL7_kelompokEliteGlobal_6
{
    internal class DataMahasiswa_1302210084
    {
        public void ReadJSON()
        {
            string jsonString = File.ReadAllText(@"C:\Users\surya\Documents\KPL Praktikum\TP_MOD7_1302210084\TheEliteGlobal\tp7_1_1302210084.json");
            
            dynamic jsonObject = JsonConvert.DeserializeObject(jsonString);

            Console.WriteLine($"Nama {jsonObject.nama.depan +" "+ jsonObject.nama.belakang} dengan nim {jsonObject.nim} dari fakultas {jsonObject.fakultas}");
        }
    }
}
