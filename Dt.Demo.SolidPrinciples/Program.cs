using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dt.Demo.SolidPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            var sourceFileName = Path.Combine(Environment.CurrentDirectory, "..\\..\\..\\Input Documents\\Student.csv");
            var targetFileName = Path.Combine(Environment.CurrentDirectory, "..\\..\\..\\Output Documents\\Student.json");

            #region Read File
                string input;
                using (var stream = File.OpenRead(sourceFileName))
                using (var reader = new StreamReader(stream))
                {
                    input = reader.ReadToEnd();
                }
            #endregion
             
            #region Format Data
            string[] studentsRead = input.Split('\n');
            List<Student> students = new List<Student>();
            foreach (var studentRead in studentsRead)
            {
                string[] studentData = studentRead.Split(',');
                Student student = new Student()
                {
                    StudentId = Guid.Parse(studentData[0]),
                    FirstName = studentData[1],
                    LastName = studentData[2],
                    Age = int.Parse(studentData[3])
                };
                students.Add(student);
            }
            #endregion

            #region Serialize Students
                var serializedStudents = JsonConvert.SerializeObject(students.ToArray());
            #endregion

            #region Persist Data
            using (var stream = File.Open(targetFileName, FileMode.Create, FileAccess.Write))
                using (var streamWriter = new StreamWriter(stream))
                {
                    streamWriter.Write(serializedStudents);
                    streamWriter.Close();
                }
            #endregion

        }
    }
}
