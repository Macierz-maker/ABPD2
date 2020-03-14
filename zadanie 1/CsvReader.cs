using System;
using System.Collections.Generic;
using System.IO;

namespace zadanie_1
{
    public class CsvReader
    {
        private readonly HashSet<Student> _students = new HashSet<Student>(new CustomComparator());

        public HashSet<Student> ReadFile(string path)
        {
            var fileInfo = new FileInfo(path);
            using (var readStream = new StreamReader(fileInfo.OpenRead()))
            {
                string line = null;
                while ((line = readStream.ReadLine()) != null)
                {
                    var student = Parse(line);
                    _students.Add(student);
                }
            }

            return _students;
        }

        private Student Parse(string line)
        {
            var lineTokens = line.Split(",");
            return new Student()
            {
                FirstName = lineTokens[0],
                LastName = lineTokens[1],
                Studies = new Studies()
                {
                    Major = lineTokens[2],
                    Mode = lineTokens[3]
                },
                IndexNumber = lineTokens[4],
                Birthday = lineTokens[5],
                Email = lineTokens[6],
                MotherName = lineTokens[7],
                FatherName = lineTokens[8]
            };
        }
    }
}