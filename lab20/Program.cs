using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab20
{
    internal class Program
    {

        /*delegate void MyDelegate();*/
        /* delegate int MyDelegate(int a, int b);*/
        delegate void MyDelegate<T>(T a); //обобщенный делегат

        static void Main(string[] args)
        {
            /*MyDelegate myDelegate = Method2;
            myDelegate += Method1;
            myDelegate -= Method1;
            myDelegate -= Method2;
            if (myDelegate !=null)
                myDelegate();*/

            /*MyDelegate myDelegate = Method5;
            if (myDelegate != null)
            { 
                int r=myDelegate(3,4);
                Console.WriteLine(r);
            }*/

            //MyDelegate myDelegate = new MyDelegate(Method5); //конструктор аналогичный предыдущему методу
            //myDelegate?.Invoke(3, 4);
            // Console.WriteLine(r);

            MyDelegate<string> myDelegate = new MyDelegate<string>(Method3); //конструктор с обощенным делегатом
            myDelegate?.Invoke("Hello!");

            Console.ReadKey();
        }

        static void Method1()
        {
            Console.WriteLine("Method 1");
        }
        static void Method2()
        {
            Console.WriteLine("Method 2");
        }
        static void Method3(string name)
        {
            Console.WriteLine("Method 3");
            Console.WriteLine(name);
        
        }
        static string Method4 (string name)
        {
            Console.WriteLine("Method 4");
            Console.WriteLine(name);
            return name;
        }
        static int Method5(int v1, int v2)
        {
            Console.WriteLine("Method 5");
            return v1 + v2;
        }
    }
}
