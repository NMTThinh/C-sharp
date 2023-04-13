using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hamchuoidaonguocmang
{
    internal class Program
    {
        static void nhapMang(int[] a, int n)
        {
            //Nhap mang
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap vao phan tu a[" + i + "]: ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static void xuatMang(int[] a, int n)
        {
            //xuat mang
            Console.WriteLine("Mang vua nhap la: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("\t" + a[i]);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap so phan tu mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[100];
            nhapMang(a, n);
            xuatMang(a, n);
            Console.WriteLine();
            // Chuoi dao nguoc
            Console.WriteLine("Chuoi dao nguoc la: ");
           for(int i=n-1; i >= 0; i--)
            {
                Console.Write("\t"+a[i]);
            }
            Console.ReadKey();
        }
    }
}
