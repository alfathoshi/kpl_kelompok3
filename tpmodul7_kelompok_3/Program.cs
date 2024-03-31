using System;

namespace tpmodul7_kelompok_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataMahasiswa = new DataMahasiswa1302220005();
            dataMahasiswa.ReadJSON();

            var kuliahMahasiswa = new KuliahMahasiswa1302220005();
            kuliahMahasiswa.ReadJSON();

            Console.ReadLine(); 
        }
    }
}
