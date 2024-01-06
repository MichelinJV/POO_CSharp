using System;
using Celular_POO.Models;

namespace Celular_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Smartphone Nokia: ");
            Smartphone nokia = new Nokia("12345", "Modelo A23", "1111111", 64);
            nokia.Ligar();
            nokia.InstalarAplicativo("WhatsApp");

            Console.WriteLine("\n");

            Console.WriteLine("Smartphone Iphone: ");
            Smartphone iphone = new Iphone("5453339", "Modelo I16", "111654", 64);
            nokia.Ligar();
            nokia.InstalarAplicativo("Telegram");
        }
    }
}
