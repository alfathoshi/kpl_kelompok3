using System;

namespace tpmodul7_kelompok_3
{
    class Program
    {
        static void Main(string[] args)
        { 
            DataMahasiswa1302223123 dataMhs = new DataMahasiswa1302223123();
            KuliahMahasiswa1302223123 KuliahMhs = new KuliahMahasiswa1302223123();
            
            dataMhs.ReadJSON();
            Console.WriteLine();
            KuliahMhs.ReadJSON();

        }

    }
}
