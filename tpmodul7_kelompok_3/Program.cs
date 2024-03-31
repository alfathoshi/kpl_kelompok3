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
  
            DataMahasiswa1302223099 dataMhs = new DataMahasiswa1302223099();
            KuliahMahasiswa1302223099 KuliahMhs = new KuliahMahasiswa1302223099();
            dataMhs.ReadJSON();
            Console.WriteLine();
            KuliahMhs.ReadJSON();
        }

    }
}
