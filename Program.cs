using System;

namespace s
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("> İsmin: ");
            string isim= Console.ReadLine();
            Console.WriteLine("> Soy İsimin: ");
            string soyisim=Console.ReadLine();
            Console.WriteLine("Merhaba!"+" "+isim+" "+soyisim);
            
        }
    }
}