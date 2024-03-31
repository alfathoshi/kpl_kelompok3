using System;

namespace tpmodul7_kelompok_3
{
    class Program
    {
        static void Main(string[] args)
        { 
            DataMahasiswa1302223137 dataMhs = new DataMahasiswa1302223137();
            KuliahMahasiswa1302223137 KuliahMhs = new KuliahMahasiswa1302223137();
            
            dataMhs.ReadJSON();
            Console.WriteLine();
            KuliahMhs.ReadJSON();

        }

    }
}
