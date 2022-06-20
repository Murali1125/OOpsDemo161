using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsDemo
{
    public class BasicCal
    {
        //
        public static int dNo = 40;

        //
        internal double Pi = 3.142;
        public int age  = 40;
        int mymarks = 40;
        internal int Add(params int[] num)
        {

            int sum = 0;
            foreach(int i in num)
            {
                sum += i;
            }
            return sum;
        }
        public int Sub(int num , int num2)
        {
            return num - num2;
        }
        public int Mul(int num , int num2)
        {
            return num * num2;

        }
        public int Div(int num, int num2)
        {
            return num / num2;

        }
        public void PrintPi()
        {
            Console.WriteLine(this.Pi);
        }

    }
    public class AdvCal : BasicCal
    {
        
        public int Mod(int num, int num2)
        {
            Add(3,5);
            return num % num2;
        }
        public int Per(int num, int num2)
        {
            return (num * 100) / num2;
        }
    }

    public class SciCal : AdvCal
    { 
        public double Sin(int num)
        {
            
            
            return Math.Sin(num);
        }

        public void Start()
        {
            SciCal sCal = new SciCal();
            sCal.Sub(2,4);
            BasicCal bCal = new BasicCal();
            AdvCal aCal = new AdvCal();
        }
    }



}
