using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace zadanie_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"data\dane.csv";
            var reader = new CsvReader();
            var university = new University()
            {
                Students = reader.ReadFile(path),
                CreatedAt = DateTime.Now,
                Author = "Maciej Jaworski"
            };
            var writer = new FileStream(@"data.xml", FileMode.Create);
            var serializer = new XmlSerializer(university.GetType());
            serializer.Serialize(writer, university);
        }
    }
}