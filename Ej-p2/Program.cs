using System;

namespace Ej_p2
{
    class Program
    {
        static void Main(string[] args)
        {   
        //Un importante negocio de desinfectante líquido realiza descuentos dependiendo de la 
        //cantidad de litros vendidos según la siguiente escala:

        //Si vende menos de 100 litros, no hay descuento.
        //Si vende entre 101 y 300 litros, el descuento es del 10%.
        //Si vende entre 301 y 500 litros, el descuento es del 15%.
        //Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
        //Hacer un programa que solicite el ingreso del importe total de la venta y la cantidad de litros vendidos 
        //y calcule y emita el importe con el descuento  aplicado..

            float litros, importe;

            Console.WriteLine("Ingrese Litros Vendidos: ");
            litros = float.Parse(Console.ReadLine());

            if(litros > 500){
                importe = importe * 0.75F;
            }
            if(litros > 300 && litros <= 500){
                importe = importe * 0.85F;
            }
            if(litros > 100 && litros <= 300){
                importe = importe * 0.90F;
            }

            Console.WriteLine("Importe total: " + importe);
            
        }
    }
}
