using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tonghieutichthuongab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            Console.Write("Nhap a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b=");
            b = int.Parse(Console.ReadLine());
            int n, tong, hieu, tich;
            float thuong;
            tong = a + b;
            hieu = a - b;
            tich = a * b;
            thuong = (float)a / b;
            Console.WriteLine("Nhan phim 1 tinh tong");
            Console.WriteLine("Nhan phim 2 tinh hieu");
            Console.WriteLine("Nhan phim 3 tinh tich");
            Console.WriteLine("Nhan phim 4 tinh thuong");
            Console.Write("Moi ban nhap: ");
            n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                Console.WriteLine("Tong cua {0} va {1} = {2} ", a, b, tong);
            }
            else if (n == 2)
            {
                Console.WriteLine("Hieu cua {0} va {1} = {2} ", a, b, hieu);
            }
            else if (n == 3)
            {
                Console.WriteLine("Tich cua {0} va {1} = {2} ", a, b, tich);
            }
            else if (n == 4)
            {
                Console.WriteLine("Thuong cua {0} va {1} = {2} ", a, b, thuong);
            }



            Console.ReadLine();


        }
    }
}
