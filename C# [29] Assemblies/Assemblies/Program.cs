using DemoLib;
using System;
using System.IO;
using System.Reflection;

namespace Assemblies
{
    class Program
    {
        static void Main(string[] args)
        {
            //var type = typeof(Employee);
            //var assembly = type.Assembly;
            //var AssemblyByStaticMethod = Assembly.GetExecutingAssembly();

            //Console.WriteLine(type);
            //Console.WriteLine("-------");

            //Console.WriteLine(assembly.FullName);
            //Console.WriteLine("-----------");

            //Console.WriteLine(AssemblyByStaticMethod.FullName);

            //Demo.Trace();

            #region using GetName()

            //var type = typeof(Program);
            //var assembly = type.Assembly;
            //Console.WriteLine($"Assembly Name : {assembly.FullName}");
            //Console.WriteLine($"Assembly Location : {assembly.Location}");
            //var assemblyName = assembly.GetName();
            //Console.WriteLine($"Name : { assemblyName.Name}" );
            //Console.WriteLine($"Name : { assemblyName.Version}");
            //Console.WriteLine($"Name : { assemblyName.GetPublicKeyToken().Length}");
            //Console.WriteLine($"Name : { assemblyName.CodeBase}");
            //Console.WriteLine("--------");
            //Console.WriteLine($"Get DateTime Assembly : {typeof(DateTime).Assembly}");
            //Console.WriteLine($"Get DateTime Assembly : {typeof(DateTime).Assembly.GetName()}");

            #endregion

            // Get Embaded Resources Data
            var type = typeof(Program);
            var assembly = type.Assembly;
            var stream = assembly.GetManifestResourceStream("Assemblies.Data.countries.json");
            var stream2 = assembly.GetManifestResourceStream( type, "Data.countries.json");
            var data = new BinaryReader(stream).ReadBytes((int)stream.Length);
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write((char)data[i]);
                System.Threading.Thread.Sleep(300);
            }
            stream.Close();
            Console.ReadKey();

        }
    }

    public class Employee
    {

    }
}
