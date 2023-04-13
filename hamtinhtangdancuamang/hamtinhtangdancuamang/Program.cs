using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hamtinhtangdancuamang
{
    internal class Program
    {
        static void nhapMang(int[] a,int n)
        {
            //Nhap mang
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap vao phan tu a[" + i + "]: ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static void xuatMang(int[] a,int n)
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
            Console.Write("Nhap vao so phan tu mang: ");
            int n;
            n=int.Parse(Console.ReadLine());
            int[] a = new int[100];
           nhapMang(a,n);
            xuatMang(a,n);
            Console.WriteLine();
            //Sap xep tang dan cua mang
                for (int i = 0; i < n; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (a[i] > a[j])
                        {
                            int temp = a[i];
                            a[i] = a[j];
                            a[j] = temp;
                        }
                    }
                }
            Console.WriteLine("Mang sau khi sap xep tang la: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("\t"+a[i]);
            }
            //sap xep giam dan.
            Console.WriteLine();
            for(int i = 0; i < n; i++)
            {
                for(int j = i + 1; j < n; j++)
                {
                    if (a[i] < a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            Console.WriteLine("mang sau khi sap xep giam la: ");
            for(int i = 0; i < n; i++)
            {
                Console.Write("\t"+a[i]);
            }
            Console.ReadLine();
        }
    }
}
