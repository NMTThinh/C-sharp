using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vidu
{
    class DongVatAnCo
    {
        void anCo()
        {

        }
    }
   interface DongVat  // Phải thực thi ( code) đầy đủ định nghĩa 
    {                  
        void anCo(); // định nghĩa
        void nuocUong();  // định nghĩa
        void diChuyen();  // định nghĩa
    }
    class ConDe : DongVat 
    {
       public void anCo() // thực thi code cho lớp cha 
        {
            Console.WriteLine("An rau");
        }
       public void nuocUong()
        {
            Console.WriteLine("uong nuoc song");
        }
       public void diChuyen()
        {
            Console.WriteLine("Di bang 4 chan");
        }
    }
    abstract class dongvat // Phải thực thi(code) đầy đủ định nghĩa, biến và hàm có thể không khai báo vì đã kế thừa từ cha.
    {
        public virtual void diChuyen()
        {
            Console.WriteLine("Di bang 4 chan");
        }
        public virtual void an()
        {
            Console.WriteLine("An co");
        }
    }
    class ConBo : dongvat
    {
       
    }
    class ConCop : dongvat
    {
        public override void an() //override ghi đè lên phương thức cũ không làm thay đổi cha
        {
            Console.WriteLine("An thit");
        }
  //      public super()
        //Chức năng k thay đổi thì k cần ghi ra
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Con deeeeeeeee");
            ConDe conde=new ConDe();
            conde.anCo();
            conde.nuocUong();
            conde.diChuyen();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Con Booooooooo");
            ConBo conbo=new ConBo();
            conbo.diChuyen();
            conbo.an();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Con Coppppppppp");
            ConCop concop=new ConCop();
            concop.an();
            concop.diChuyen();

        }
    }
}
