using System;
using System.Collections;

namespace CAEnumeratorandIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var ints = new FiveIntegers(1, 2, 3, 4, 5);
            foreach (var i in ints)
            {
                Console.WriteLine(i);
            }

        }
    }

    public class FiveIntegers : IEnumerable
    {
        int[] _values;
        public FiveIntegers(int n1, int n2, int n3, int n4, int n5)
        {
            _values = new[] { n1, n2, n3, n4, n5 };
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var item in _values)
            {
                yield return item;
            }
        }


    }
}

#region yieldStateMatchine 


//class Enumerator
//{
//    int currentIndex = -1;
//    FiveIntegers _integers;
//    public enumerator(FiveIntegers integers)
//    {
//        _integers = integers;
//    }
//    public object Current
//    {
//        get
//        {
//            if (currentIndex == -1)
//            {
//                throw new InvalidOperationException($"enumeration not started");
//            }
//            if (currentIndex == _integers._values.Length)
//            {
//                throw new InvalidOperationException($"enumeration Ended");
//            }
//            return _integers._values[currentIndex];
//        }
//    }
    
//}
#endregion
