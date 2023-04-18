using System;

namespace Zadania_warunki
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstnumber;
            int secondnumber;

            Console.WriteLine("Podaj pierwszą liczbę: ");
            string a = Console.ReadLine();

            Console.WriteLine("Podaj drugą liczbę: ");
            string b = Console.ReadLine();
            Int32.TryParse(a, out firstnumber);
            Int32.TryParse(b, out secondnumber);

            if (firstnumber == secondnumber)
            {
                Console.WriteLine($"Liczby {firstnumber} i {secondnumber} są równe.");
            }
            else
            {
                Console.WriteLine("Podane liczby nie są równe");
            }
        }
    }
}