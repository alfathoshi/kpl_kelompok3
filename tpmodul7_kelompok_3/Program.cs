internal class Program
{
    private static void Main(string[] args)
    {
        DataMahasiswa1302223099 dataMhs = new DataMahasiswa1302223099();
        KuliahMahasiswa1302223099 KuliahMhs = new KuliahMahasiswa1302223099();
        dataMhs.ReadJSON();
        Console.WriteLine();
        KuliahMhs.ReadJSON();
    }
}