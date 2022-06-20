using OOPsDemoTemp;
using OOPsDemo;
Factory Fact = new Factory();
IAbstactDemo myObj =  Fact.ReturnObj();

myObj.Add(3, 5);

//BasicCal bCal = new BasicCal();
//Console.WriteLine(bCal.Pi);
//bCal.Add(3, 0);