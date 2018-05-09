using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolichestvo_variantov_dostavki
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число клиентов");
            int x = Convert.ToInt32(Console.ReadLine());

            int result = 1;

            do
            {
                result *= x;
                x -= 1;
            } while (x > 0);
            Console.WriteLine("Количество вариантов доставки: " + result);
            Console.ReadKey();
        }
    }
}
