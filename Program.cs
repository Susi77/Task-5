using System;
using System.IO;
using System.Text.Json;

namespace SerializationIp
{
    class Program
    {
        static void Main(string[] args)
        {
            string jsonFileName = "Iphone9.txt ";

             Apple i = new Apple
            {
                OperationSystem = "It works with IOS 13.",

                CPU = "It has Apple A12Z Bionic CPU .",

                RAM = "It has 2GB RAM. ",

                InternalMemory = "It has 32GB,64GB,128GB,256GB internal memory . ",

                Iphone9 = new Iphone9 { Camera = "It has a camera ",SIM = "It has a chip",Chip="It has no chip." } 
            };


            SaveAsJsonFormat(i, jsonFileName);

            Console.ReadKey();

        }
        static void SaveAsJsonFormat(object objGraph, string fileName)
        {
            string jsonString = JsonSerializer.Serialize(objGraph);
            File.WriteAllText(fileName, jsonString);
            Console.WriteLine();
            Console.WriteLine("Save Iphone9 in JSON format. ");

            Console.ReadLine();
        }

    



    }
}
