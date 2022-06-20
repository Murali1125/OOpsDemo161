using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPsDemo;
namespace OOPsDemoTemp
{
    public class Factory
    {
        public IAbstactDemo ReturnObj()
        {
            IAbstactDemo myObj = new AbstraactionDemo();
            return myObj;
        }
    }
}
