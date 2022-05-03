using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CAJsonSerialization
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

            var jsonCOntent = SerializetoJsonUsingNetonSoft(e1);
            Console.WriteLine(jsonCOntent);
            Console.ReadKey();

        }

        static string SerializetoJsonUsingNetonSoft(Employee employee)
        {
            var result = "";
            result = JsonConvert.SerializeObject(employee, Formatting.Indented);
            return result;
        }

        static Employee DeserializetoJsonUsingNetonSoft(string jsonCOntent)
        {
            Employee employee = null;
            employee = JsonConvert.DeserializeObject<Employee>(jsonCOntent);
            return employee;
        }

        // from dot net 3 dot net has liberary to jsn serialization insteed of netonsoft liberary
        static string serializeJsonUnsigJsonDotNet(Employee employee)
        {
            var result = "";

            return result;
        }

        static Employee DeserializeJsonUnsigJsonDotNet(string jsonContent)
        {
            Employee e1 = null;

            return e1;
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
