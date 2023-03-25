using System;

namespace TomarDecisiones
{
    class Program
    {
        static void Main(string[] args)
        {
            bool esAdmin = false;
            bool estaRegistrado = true;
            string nombreDeUsuario = "";

            Console.WriteLine("Por favor, ingrese su nombre de usuario");
            nombreDeUsuario = Console.ReadLine();
            if (estaRegistrado)
            {
                Console.WriteLine("Hola usuario registrado");
                if (nombreDeUsuario != "")
                {
                    Console.WriteLine("Hola " + nombreDeUsuario);
                    if (nombreDeUsuario.Equals("Admin"))
                    {
                        Console.WriteLine("Hola Admin");
                    }
                }
            }

            if(estaRegistrado  && nombreDeUsuario != "" && nombreDeUsuario.Equals("Admin"))
            {
                Console.WriteLine("Hola usuario registrado");
                Console.WriteLine("Hola " + nombreDeUsuario);
                Console.WriteLine("Hola Admin");
            }

            if(esAdmin || estaRegistrado)
            {
                Console.WriteLine("Estás loguado");
            }


            Console.Read();
        }
       
    }
}
