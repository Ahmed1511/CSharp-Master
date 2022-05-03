using System;

namespace CIndexers
{
    class Program
    {
        static void Main(string[] args)
        {
            var ip = new IP(120, 111, 102, 212);
            var ip2 = new IP("121.214.214.254");
            Console.WriteLine(ip.Address);
            Console.WriteLine(ip2.Address);
            Console.WriteLine("----------------------");
            Console.WriteLine($"first segment : {ip[0]}");
            Console.WriteLine($"first segment : {ip[1]}");
            Console.WriteLine($"first segment : {ip[2]}");
            Console.WriteLine($"first segment : {ip[3]}");
        }
    }

    public class IP
    {
        private int[] Segments = new int[4];


        // this is the current object that created from this class (IP)
        public int this[int index]
        {
            get
            {
                return Segments[index];
            }
            set
            {
                Segments[index] = value;
            }
        }

        public IP(int segment1, int segment2, int segment3, int segment4)
        {
            Segments[0] = segment1;
            Segments[1] = segment2;
            Segments[2] = segment3;
            Segments[3] = segment4;
        }

        public IP(string IPAddress)
        {
            var segs = IPAddress.Split(".");
            for (int i = 0; i < segs.Length; i++)
            {
                Segments[i] = Convert.ToInt32(segs[i]);
            }
        }

       

        public string Address => string.Join(".", Segments);
    }
}
