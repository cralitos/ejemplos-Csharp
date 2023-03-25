using System;

namespace TomarDecisiones
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Por favor, ingresa la temperatura actual");

            string temperatura = Console.ReadLine();
            int numTemperatura = int.Parse(temperatura);
            
            if (numTemperatura < 20)
            {
                Console.Write("Abrígate!");
            }
            if(numTemperatura == 20)
            {
                Console.WriteLine("Vístete cómodo");
            }
            if (numTemperatura > 20)
            {
                Console.WriteLine("Usa ropa bien liviana");
            }

            Console.Read();
        }
    }
}
