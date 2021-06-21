using System;

namespace Tarea04_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce un número:  ");
            int  numero = Convert.ToInt32( Console.ReadLine() );

            if (numero%2 == 0)
            {
                Console.WriteLine("El número {0} es divisible entre 2", numero);
            }
            else
            {
                Console.WriteLine("El número {0} NO es divisible entre 2", numero);
            }

            

            Console.ReadKey();
        }
    }
}
