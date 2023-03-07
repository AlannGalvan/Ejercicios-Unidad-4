using System;

namespace Ej_p4
{
    class Program
    {
        static void Main(string[] args)
        {    

            //Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si la suma de los 
            //dos primeros es mayor al producto del segundo con el tercero.
            int a, b, c, suma1, suma2;


            Console.WriteLine("Ingrese primer nro: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese segundo nro: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Tercer nro: ");
            c = int.Parse(Console.ReadLine());

            suma1 = a + b;
            suma2 = b * c;

            if(suma1 > suma2)
                Console.WriteLine("Es mayor");
            
            Console.WriteLine("Programa terminado..");
            

            


        }
    }
}
