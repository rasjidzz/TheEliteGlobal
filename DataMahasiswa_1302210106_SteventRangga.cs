using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TPMODUL7_kelompokEliteGlobal_6
{
    internal class DataMahasiswa_1302210106_SteventRangga
    {
        public void ReadJSON()
        {
            string json = File.ReadAllText(@"D:\Coding\C#\TP_MOD7\TheEliteGlobal\tp7_1_1302210106.json");
            dynamic json_conv = JsonConvert.DeserializeObject(json);

            Console.WriteLine($"Nama {json_conv.nama.depan} {json_conv.nama.belakang} dengan nim {json_conv.nim} dari fakultas {json_conv.fakultas}");
        }
    }
}
