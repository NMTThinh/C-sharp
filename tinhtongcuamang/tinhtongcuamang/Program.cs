using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tinhtongcuamang
{
    internal class Program
    {
        static void nhapMang(int[] a,int n)
        {
            for(int i = 0; i < n; i++)
            {
                Console.Write("Nhap phan tu thu ["+i+"]: ");
                a[i]=int.Parse(Console.ReadLine());
            }
        }
        static void xuatMang(int[] a,int n)
        {
            Console.WriteLine("Mang vua nhap la: ");
            for(int i=0;i<n;i++)
            {
                Console.Write("\t" + a[i]);
            }
        }
      static  void sum(int[] a, int n)//ham tinh tong các phan tu trong mang
        {
            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                tong += a[i];// tinh tong cua cac phan tu trong mang
            }
            Console.WriteLine("Tong cac phan tu trong mang la: "+ tong);  
        }
        static void Main(string[] args)
        {
            int n;
            int[] a = new int[100];
            Console.Write("Nhap so phan tu mang: ");
            n=int.Parse(Console.ReadLine());
            nhapMang(a,n);
            xuatMang(a,n);
            Console.WriteLine( );
            sum(a,n);
            Console.ReadKey();
        }
    }
}
