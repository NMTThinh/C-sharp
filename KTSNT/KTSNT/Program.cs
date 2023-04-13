using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTSNT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap vao mot so de kiem tra: ");
            n=int.Parse(Console.ReadLine());
            bool KTSNT = true;
            if (n < 2)// so nguyen to bat dau tu 2
            {
                KTSNT = false;
            }
            for (int i = 2; i < n / 2; i++)
            {
                if (n % i == 0)
                {
                    KTSNT = false;
                    break;
                }
            }
            if(KTSNT)
            {
                Console.WriteLine("{0} la so nguyen to.",n);
            }
            else
            {
                Console.WriteLine("{0} khong phai la so nguyen to.",n);
            }
        }
    }
}
