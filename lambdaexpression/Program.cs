using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambdaexpression
{
    class Program
    {
        static void Main(string[] args)
        {

            // lambda();
            // simplelambdaexpression();
           

        }

        private static void lambda()
        {
            Func<int, double, double> Calc = (x, y) => x * y;
            Console.WriteLine(Calc(12, 10.8));
        }

        private static void simplelambdaexpression()
        {
            Func<int, int> Cube = a => a * a * a;            //=> is lambda symbol

            Console.WriteLine("enter any number");
            int cr = int.Parse(Console.ReadLine());
            Console.WriteLine(Cube(cr));
        }

        public static void LambdaLinqOrdr()
        {
            int[] nos = { 45, 23, 12, 98, 65 };
            var sort = nos.OrderBy(x => x);
            Console.WriteLine(string.Join("", sort));
        }

        private static void LambdaLinq()
        {
            int[] numbers = { 2, 3, 4, 5 };
            var squarednumbers = numbers.Select(x => x * x);
            Console.WriteLine(string.Join("", squarednumbers));
        }

        private static void Lambdaexp()
        {
            int[] scores = { 78, 67, 89, 90, 86, 77, 65, 87, 98 };
            int exelent = scores.Where(n => n >= 85).Count();
            int aplus = scores.Where(x => x >= 75).Count() -exelent;
            Console.WriteLine(exelent);
            Console.WriteLine(aplus);


        }


    }
}
