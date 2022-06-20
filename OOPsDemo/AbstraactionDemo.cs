using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsDemo
{
    interface IAbsDemoTwo
    {
        int Mod(int a, int b);
        void Add(int a, int b);
    }
    internal class AbstraactionDemo :BasicCal, IAbstactDemo, IAbsDemoTwo
    {
        public int Mod(int a, int b)
        {
            return a % b;
        }
        public void Add(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }
        
        public void Sub(int a, int b)
        {

        }
    }
}
