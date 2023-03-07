using System;

namespace Ej_p5
{
    class Program
    {
        static void Main(string[] args)
        {

              //Hacer un programa para ingresar 4 números. Luego analizar e informar por pantalla si 
              //los mismos se encuentran ordenados de forma decreciente .

              int a, b, c, d;

              Console.WriteLine("Ingrese primer nro:");
              a = int.Parse(Console.ReadLine());
              Console.WriteLine("Ingrese segundo nro:");
              b = int.Parse(Console.ReadLine());
              Console.WriteLine("Ingrese tercer nro:");
              c = int.Parse(Console.ReadLine());
              Console.WriteLine("Ingrese cuarto nro:");
              d = int.Parse(Console.ReadLine());

              if(a > b && b > c && c > d)
                Console.WriteLine("Esta ordenado");
              else 
                 Console.WriteLine("No esta oredenado");
            
            Console.WriteLine("FIn del programa...");
            
        }
    }
}
