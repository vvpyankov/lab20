using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab20delegateAction
{
    internal class Program
    {

        //delegate void MyDelegate();
        // delegate int MyDelegate(int a, int b);
        //delegate void MyDelegate<T>(T a); //обобщенный делегат
        delegate int MyDelegate(int v1, int v2);
        static void Main(string[] args)
        {
            /*  MyDelegate myDelegale = delegate (int v1, int v2) //анонимный метод, можно записать в сокр форме - лямбда
              {
                  Console.WriteLine("Method 5");
                  return v1 + v2;
              };*/

            MyDelegate myDelegate = (v1, v2) => v1 + v2; //лямбда запись предыдущего
            myDelegate(3, 4);
            
            /*Action<string>  action = Method3;
            action("Hello");*/

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
        static string Method4(string name)
        {
            Console.WriteLine("Method 4");
            Console.WriteLine(name);
            return name;
        }
        /*static int Method5(int v1, int v2)
        {
            Console.WriteLine("Method 5");
            return v1 + v2;
        }*/
    }
}
