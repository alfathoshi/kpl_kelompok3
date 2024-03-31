﻿using System;
using System.IO;
using System.Text.Json;

public class KuliahMahasiswa1302220005
{
    public class MataKuliah
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public MataKuliah[] courses { get; set; }

    public void ReadJSON()
    {
        string json = File.ReadAllText("tp7_2_1302220005.json");

        var kuliahMahasiswa = JsonSerializer.Deserialize<KuliahMahasiswa1302220005>(json);

        Console.WriteLine("Daftar mata kuliah yang diambil:");
        int i = 0;
        foreach (var mk in kuliahMahasiswa.courses)
        {
            i++;
            Console.WriteLine($"MK {i} {mk.code} - {mk.name}");

        }
    }
}