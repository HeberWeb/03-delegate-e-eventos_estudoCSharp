using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Delegates
{
    class Program
    {
        delegate int Calcula(int a, int b);
        static void Main(string[] args)
        {
            Calcula calcSoma = new Calcula(Soma);
            var so = calcSoma(10, 20);

            Calcula calcSub = new Calcula(Subtrai);
            var su = calcSub(20, 10);

            //var so = Soma(10, 20);

            //var su = Subtrai(20, 10);

            Console.WriteLine("Soma:" + so);
            Console.WriteLine("Sub:" + su);
        }

        static int Soma(int a, int b)
        {
            return a + b;
        }

        static int Subtrai(int a, int b)
        {
            return a - b;
        }
    }
}
