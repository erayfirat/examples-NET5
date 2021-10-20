using System;

namespace console_sample
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Adınız:");
            var name = Console.ReadLine();
            Console.WriteLine("Soyadınız: ");
            var surname = Console.ReadLine();
            Console.WriteLine("Merhaba "+ name  + " " + surname);

        }
    }
}
