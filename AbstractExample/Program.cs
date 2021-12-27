using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Abstract Class : Kendimize, işimize yarayacak bir model çıkarıyoruz
            //Abstract class örneklenmez. Şablon olarak kullanılır
            //Abstract class kural kütüphanesidir. Ondan kalıtım alan sınıflar yapıcı methodunu çalıştırabilir ama program.cs de örneklenmez
            //Abstract olarak tanımlı methodları kullanmak zorunda bırakır, eğer başında abstract ifadesi yoksa kullanımı zorunlu kılmaz.
            //Abstract sınıflarda sealed(kalıtım alınmasını engelleme) işlemi yapılamaz


            Musteri m = new Musteri();
            m.Test();
            m.TestAbstract();

            SuperMusteri sm = new SuperMusteri();
            sm.TestAbstract();

            Console.ReadLine();

        }
    }
}
