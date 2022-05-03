using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace CASerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            var e1 = new Employee
            {
                Id = 1,
                FNAme = "ahmed",
                LName = "ali"
            };

            var xmlContent = SerializetoXML(e1);
            Console.WriteLine(xmlContent);
            File.WriteAllText("cmlDocument.xml", xmlContent);

            Employee e2 = Deserialize(xmlContent);
            Console.ReadKey();
        }

        private static Employee Deserialize(string xmlContent)
        {
            Employee employee = null;
            var xmlSerializer = new XmlSerializer(typeof(Employee));
            using (TextReader reader = new StringReader(xmlContent))
            {
                employee = xmlSerializer.Deserialize(reader) as Employee;
            }
            return employee;
        }

        public static string SerializetoXML(Employee e1)
        {
            var result = "";
            var xmlSerializer = new XmlSerializer(e1.GetType());
            using (var sw = new StringWriter())
            {
                using (var writer = XmlWriter.Create(sw, new XmlWriterSettings { Indent = true }))
                {
                    xmlSerializer.Serialize(writer, e1);
                    result = sw.ToString();
                }
            }
            return result;
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string FNAme { get; set; }
        public string LName { get; set; }
        public List<string> Benfits { get; set; } = new List<string>();
    }
}
