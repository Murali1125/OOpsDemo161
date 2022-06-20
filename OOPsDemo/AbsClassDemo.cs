using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsDemo
{
    public abstract class AbsClassDemo
    {

        public abstract void Mul(int a, int b);
        public void Div(int a, int b)
        {
            Console.WriteLine( a / b);
        }
    }

    public class ChildOfABSCLS : AbsClassDemo
    {
        public void Div(int a, int b)
        {

        }
        public override void Mul(int a, int b)
        {

        }
    }

}
