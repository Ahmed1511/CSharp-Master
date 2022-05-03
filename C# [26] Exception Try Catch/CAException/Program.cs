using System;

namespace CAException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MyClass myClass = new MyClass();
                myClass.BadMethod();
                Console.ReadKey();
                
            }
            // Spesific Exception
            catch (DivideByZeroException ex) when (ex.Source == "CAException")
            {
                // Handel the Exceptions               
                Console.WriteLine("Error Because of Deviding By Zero");
            }
            // Spesific Exception   
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Error Because of Deviding By Zero");
            }
            // General Exception
            catch(Exception ex)
            {
                Console.WriteLine("Error Because of Deviding By Zero for exception");
            }
            finally
            {
                Console.WriteLine("Finaly");
            }

                     
            
        }        
    }

    public class MyClass
    {
        public int BadMethod()
        {
            var x = 2;
            var z = 0;
            return x / z;
        }
    }

    
}
