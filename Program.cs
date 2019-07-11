using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch09Exercices
{
    public abstract class MyBase
    {
    }
    internal class MyClass : MyBase
    {
    }
    public interface IMyBaseInterface
    {
        string DoSomething();
    }
    internal interface IMyBaseInterface2
    {
        int DoSomething2();
    }
    internal interface IMyInterface : IMyBaseInterface, IMyBaseInterface2
    {
        void DoSomething3();
    }
    internal sealed class MyComplexClass : MyClass, IMyInterface
    {
        public string DoSomething()
        {
            throw new NotImplementedException();
        }
        public int DoSomething2()
        {
            throw new NotImplementedException();
        }
        public void DoSomething3()
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //MyBase myBase = new MyBase();
            MyComplexClass myObj = new MyComplexClass();
            //myObj.
            Console.WriteLine(myObj.ToString());
            Console.ReadKey();
        }
    }
}
