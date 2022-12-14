using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_BasicMokymai
{
    internal class GenericTest<TFirst, TSecond> where TFirst : class where TSecond : struct
    {
        public TFirst First { get; set; } 
        public TSecond Second { get; set; }
        public GenericTest(TFirst first, TSecond second) 
        {
            First = first;
            Second = second;
        }    

        public void DoSomething()
        {
            Console.WriteLine(First);
            Console.WriteLine(Second);
        }

    }
}
