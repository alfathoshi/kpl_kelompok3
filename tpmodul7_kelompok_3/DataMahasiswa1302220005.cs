using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_3
{
    internal class DataMahasiswa1302220005
    {
        public class NamaMahasiswa
        {
            public string depan { get; set; }
            public string belakang { get; set; }
        }
        public NamaMahasiswa nama { get; set; }
        public long nim { get; set; }
        public string fakultas { get; set; }

        public void ReadJSON()
        {
            string json = File.ReadAllText("tp7_1_1302220005.json");

            var dataMahasiswa = JsonSerializer.Deserialize<DataMahasiswa1302220005>(json);

            if (dataMahasiswa.nama != null)
            {
                Console.WriteLine($"Nama {dataMahasiswa.nama.depan} {dataMahasiswa.nama.belakang} dengan nim {dataMahasiswa.nim} dari fakultas {dataMahasiswa.fakultas}");
            }
            else
            {
                Console.WriteLine("Nama mahasiswa tidak ada.");
            }
        }
    }
}
