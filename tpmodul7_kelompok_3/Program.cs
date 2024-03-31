using System;

namespace tpmodul7_kelompok_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataMahasiswa = new DataMahasiswa1302223038();
            dataMahasiswa.ReadJSON();

            var kuliahMahasiswa = new KuliahMahasiswa1302223038();
            kuliahMahasiswa.ReadJSON();

            Console.ReadLine(); 
        }
    }
}
