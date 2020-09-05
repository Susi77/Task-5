using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace Serial
{
    class Program
    {

        static void Main(string[] args)
        {
            string jsonFileName = "Iphone9.txt ";
            Iphone9 i = new Iphone9

            {   OperationSystem = "It works with IOS 12.",
                RAM = "It has 2GB RAM. ",
                CPU = "It has Apple A12Z Bionic CPU .",
                InternalMemory = "It has 32GB,64GB,128GB,256GB internal memory .  ",
                SIM = "It has a SIM.",
                Camera = "It has a camera. ",
                Chip = "It has no chip .",
           };
            PrintIphone9(i);

            //string jsonFileName = "Iphone9.txt ";
            SaveAsJsonFormat(i, jsonFileName);

            Console.ReadLine();

        }
        static void SaveAsJsonFormat(object objGraph, string fileName)
        {
            string jsonString = JsonSerializer.Serialize(objGraph);
            File.WriteAllText(fileName, jsonString);
            Console.WriteLine();
            Console.WriteLine("Save Iphone9 in JSON format. ");

            Console.ReadLine();
        }

        static void PrintIphone9(Iphone9 i)
        {
            if (i == null) return;
            Console.WriteLine($"Operation system : {i.OperationSystem}");
            Console.WriteLine($"CPU : {i.CPU}");
            Console.WriteLine($"RAM : {i.RAM}");
            Console.WriteLine($"Internal memory: {i.InternalMemory}");
            Console.WriteLine($"SIM: {i.SIM}");
            Console.WriteLine($"Camera : {i.Camera}");
            Console.WriteLine($"Chip : {i.Chip}");

            Console.WriteLine();
        }
    }
    
}
