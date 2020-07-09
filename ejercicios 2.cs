using System;

namespace Ejercicios_2
{
    class Program
    {
        static void Main(string[] args)
        {
    
           
            float numero;
            Console.WriteLine("ingrese cualquier cosa");
            numero = Int32.Parse(Console.ReadLine());
            while (numero != 3) ;
            {
                if (numero >0)
                {
                 
              Console.WriteLine("El numero ingresado es un numero positivo");
            
                }
                else
                {
                    Console.WriteLine("el numero que usted ingreso es negativo");
                }
            }
        }
    }
}
 



