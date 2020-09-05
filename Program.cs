using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using SerializationIphone9;
namespace SerializationIphone9
{
    class Program
    {
  

        static void Main(string[] args)
        {
            string jsonFileName = "Iphone9.txt ";
            Iphone9 i = new Iphone9();
            PrintIphone(i);
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

        static void PrintIphone(Iphone9 i)
        {
            if (i == null) return;

            Console.WriteLine(i.OperationSystem());
            Console.WriteLine(i.SIM());
            Console.WriteLine(i.Camera());
            Console.WriteLine(i.InternalMemory());
            Console.WriteLine(i.RAM());
            Console.WriteLine(i.CPU());
            Console.WriteLine(i.UseProtectedMember());


        }
    }
}
