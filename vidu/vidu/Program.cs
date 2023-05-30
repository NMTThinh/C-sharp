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
   interface DongVat
    {
        void anCo();
        void nuocUong();
        void diChuyen();
    }
    class ConDe : DongVat 
    {
       public void anCo()
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
    abstract class dongvat
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
        public override void an()
        {
            Console.WriteLine("An thit");
        }
        
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
            Console.WriteLine("Con Booooooooo");
            ConBo conbo=new ConBo();
            conbo.diChuyen();
            conbo.an();
            Console.WriteLine("Con Coppppppppp");
            ConCop concop=new ConCop();
            concop.an();
            concop.diChuyen();

        }
    }
}
