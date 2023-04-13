using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mang2chieu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m, n;
            Console.Write("Nhap so hang m: ");
            m=int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot n: ");
            n=int.Parse(Console.ReadLine());
            int[,] Mang = new int[m, n];
            for(int i = 0; i < Mang.GetLength(0); i++)
            {
                for(int j=0;j<Mang.GetLength(1); j++) {
                    Console.Write("Nhap phan tu[{0}][{1}]: ",i,j);
                    Mang[i,j]=int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();
            Console.WriteLine("Mang vua nhap la: ");
            for(int i=0;i<Mang.GetLength(0);i++)
            {
                for(int j = 0; j < Mang.GetLength(1); j++)
                {
                    Console.Write("{0,3}",Mang[i,j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
