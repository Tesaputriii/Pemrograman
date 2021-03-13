using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Aplikassi kalkulator";


            Console.WriteLine("Pilih Menu kalkulator :");
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");

            Console.WriteLine("Input nomor menu [1...4]");
            int Pilih = int.Parse(Console.ReadLine());

            Console.WriteLine("Inputkan nilai a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inputkan nilai b");
            int b = Convert.ToInt32(Console.ReadLine());

            if (Pilih == 1)
            {
                Console.WriteLine("Penambahan dari " + a + " + " + b + " = " + Penambahan(a, b));
            }
            else if (Pilih == 2)
            {
                Console.WriteLine("Pengurangan dari " + a + " - " + b + " = " + Pengurangan(a, b));
            }
            else if (Pilih == 3)
            {
                Console.WriteLine("Perkalian dari " + a + " * " + b + " = " + Perkalian(a, b));
            }
            else if (Pilih == 4)
            {
                Console.WriteLine("Pembagian dari " + a + " / " + b + " = " + Pembagian(a, b));
            }

            
            Console.ReadLine();
        
            
        
        
            }
            static int Penambahan(int a, int b)
            {
                return a + b;
            }

            static int Pengurangan(int a, int b)
            {
                return a - b;
            }

            static int Perkalian(int a, int b)
            {
                return a * b;
            }

            static int Pembagian(int a, int b)
            {
                return a / b;
            }
        


    }
}
