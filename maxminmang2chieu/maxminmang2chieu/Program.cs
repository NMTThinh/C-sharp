using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxminmang2chieu
{
    internal class Program
    {
        static  void nhapMang(int n,int m)
        {
            int[,] Mang = new int[n, m];
            for(int i=0;i<Mang.GetLength(0);i++)
            {
                for(int j = 0; j < Mang.GetLength(1); j++)
                {
                    Console.Write("Nhap phan tu [{}][{}]: ",i,j);
                    Mang[i,j]=int.Parse(Console.ReadLine());
                }
            }
        }
        static void xuatMang( int n,int m)
        {
            int[,] Mang = new int[n, m];
            Console.WriteLine("Mang vua nhap la: ");
            for (int i = 0; i < Mang.GetLength(0); i++)
            {
                for (int j = 0; j < Mang.GetLength(1); j++)
                {
                    Console.Write("\t" + Mang[i, j]);
                }
            }
        }
        static void Main(string[] args)
        {
            int n, m;
            int[,] Mang = new int[100,100];
            Console.WriteLine("Nhap so phan  tu hang n: ");
            n=int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so phan tu cot m: ");
            m=int.Parse(Console.ReadLine());
            nhapMang (Mang, n,m);
            xuatMang (Mang, n,m);

        }
    }
}
