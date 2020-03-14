using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace zadanie_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var csvPath = @"data\dane.csv";
            var outputPath = "data.xml";
            var outputType = "xml";
            if (args.Length == 3)
            {
                csvPath = args[0];
                outputPath = args[1];
                outputType = args[2];
            }
            else
            {
                Console.Error.WriteLine("You didn't give enough arguments");
            }
            
            var reader = new CsvReader();
            var students = reader.ReadFile(csvPath).ToList();
            var university = new University()
            {
                Students = students,
                CreatedAt = DateTime.Now.ToString("dd.MM.yyyy"),
                Author = "Maciej Jaworski",
                ActiveStudies = StudiesManager.UpdateNumberOfStudents(students).ToList()
            };

            switch (outputType)
            {
                case "xml":
                {
                    var writer = new FileStream(outputPath, FileMode.Create);
                    var xmlSerializer = new XmlSerializer(university.GetType());
                    xmlSerializer.Serialize(writer, university);
                    break;
                }
                case "json":
                {
                    var jsonString = JsonSerializer.Serialize(university);
                    File.WriteAllText(outputPath, jsonString);
                    break;
                }
            }
        }
    }
}