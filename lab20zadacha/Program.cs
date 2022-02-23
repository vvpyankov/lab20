using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*В приложении объявить тип делегата, который ссылается на метод. Требования к сигнатуре метода следующие:
-метод получает входным параметром переменную типа double;
-метод возвращает значение типа double, которое является результатом вычисления.
Реализовать вызов методов с помощью делегата, которые получают радиус R и вычисляют:
-длину окружности по формуле D = 2 * π* R;
-площадь круга по формуле S = π* R²;
-объем шара.Формула V = 4 / 3 * π * R³.
Методы должны быть объявлены как статические.*/

namespace lab20zadacha
{
    internal class Program
    {
        delegate double MyDelegate(double R);
        static void Main(string[] args)
        {
            MyDelegate myDelegate1 = Method1;
            if (myDelegate1 != null)
            {
                double D = myDelegate1(3.5);
                Console.WriteLine(D);
            }
            MyDelegate myDelegate2 = Method2;
            if (myDelegate2 != null)
            {
                double S = myDelegate2(3.5);
                Console.WriteLine(S);
            }
            MyDelegate myDelegate3 = Method3;
            if (myDelegate3 != null)
            {
                double V = myDelegate3(3.5);
                Console.WriteLine(V);
            }
            Console.ReadKey();
        }

        static double Method1(double R)
        {
            Console.WriteLine("Method1");
            return 2 * Math.PI * R;
        }
        static double Method2(double R)
        {
            Console.WriteLine("Method2");
            return Math.PI * R * R;
        }
        static double Method3(double R)
        {
            Console.WriteLine("Method3");
            return 4 * Math.PI * Math.Pow(R, 3) / 3;
        }
    }
}
