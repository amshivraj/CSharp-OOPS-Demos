using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{

    class BaseClass
    {
        private int _num;
        public int num
        {
            get { return _num; }
            private set
            {
                _num = value;
            }
        }
        public virtual void Method1()
        {
            num = 2;
            Console.WriteLine("Base - Method1");
        }
        public void Method2()
        {
            Console.WriteLine("Base - Method2");
        }
    }

    class DerivedClass : BaseClass
    {
        public override void Method1()
        {
            Console.WriteLine("Derived - Method1");
        }
        public new void Method2()
        {
            Console.WriteLine("Derived - Method2");
        }   
    }
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass bc = new BaseClass();
             //DerivedClass dc = new DerivedClass();
           // BaseClass bcdc = new DerivedClass();
            Console.WriteLine(bc.num);
           //DerivedClass obj = (DerivedClass)(new BaseClass());//error

            bc.Method1();
            Console.WriteLine(bc.num);
            //bc.Method2();
            //dc.Method1();
            //dc.Method2();
            //bcdc.Method1();
            //bcdc.Method2();
            //obj.Method1();
            //obj.Method2();
            Console.ReadKey();
        }
    }
}
