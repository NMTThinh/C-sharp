using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Program
    {
        static void nhapMang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap phan tu thu [" + i + "]: ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static void xuatMang(int[] a, int n)
        {
            Console.WriteLine("Mang vua nhap la: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("\t" + a[i]);
            }
        }
        //ham tinh tong các phan tu trong mang
        static void sum(int[] a, int n)
        {
            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                tong += a[i];
            }
            Console.WriteLine("Tong cac phan tu trong mang la: " + tong);
        }
        //In ra màn hình tất cả các số lớn hơn hoặc bằng 0 và nhỏ hơn hoặc bằng 10 trong mảng
        static void inSo(int[] a,int n) 
        {
            for(int i = 0; i < n; i++)
            {
                if (a[i]>=0 && a[i] <= 10)
                {
                    Console.Write("\t" +a[i]);
                }
            }
        }
        //Sắp xếp tất cả các phần tử theo thứ tự tăng dần rồi in mảng đã sắp xếp ra màn hình
        static void sapXep(int[] a,int n)
        {
            for(int i = 0; i < n; i++)
            {
                for(int j=i+1;j<n;j++)
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
            for(int i = 0; i < n; i++)
            {
                Console.Write("\t" + a[i]);
            }
        }
        //In ra màn hình số lớn nhất
        static void timMax(int[] a,int n)
        {
            int max = a[0];    
            for(int i = 0; i < n; i++)
            {
                if (max < a[i])
                {
                    max= a[i];
                }
            }
            Console.WriteLine("Phan tu max trong mang la: "+max);
        }
       // In ra màn hình số nhỏ nhất trong mảng
        static void timMin(int[] a, int n)
        {
            int min = a[0];
            for (int i = 0; i < n; i++)
            {
                if (min > a[i])
                {
                    min = a[i];
                }
            }
            Console.WriteLine("Phan tu min trong mang la: " + min);
        }
        static void Main(string[] args)
        {
            int n;
            int[] a = new int[100];
            Console.Write("Nhap so phan tu cho mang: ");
            n=int.Parse(Console.ReadLine());
            nhapMang(a, n);
            xuatMang(a, n);
            Console.WriteLine();
            Console.WriteLine("In TINH TONG cac phan tu trong mang nhan phim 1.");
            Console.WriteLine();

            Console.WriteLine("In ra man hinh cac so >=0 va <=10 nhan phim 2");
            Console.WriteLine();

            Console.WriteLine("In ra man hinh day sap xep TANG DAN nhan phim 3");
            Console.WriteLine();

            Console.WriteLine("In ra 2 so MAX va MIN cua mang nhan phim 4");
            Console.WriteLine();

            int m;
            Console.Write("Nhap phuong an ban chon: ");
            m = int.Parse(Console.ReadLine());
            if (m == 1)
            {
                sum(a, n);
                Console.WriteLine();
            }
            else if (m == 2)
            {
                inSo(a, n);
                Console.WriteLine();
            }
            else if (m == 3)
            {
                sapXep(a, n);
                Console.WriteLine();
            }
            else if (m == 4)
            {
                timMax(a, n);
                Console.WriteLine();
                timMin(a, n);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
