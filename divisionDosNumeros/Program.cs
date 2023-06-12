using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace divisionDosNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creamos variables
            double dividendo, divisor, resultado;
            // solicitamos al usuario un valor y convertimos
            Console.Write("Por favor Ingresa el dividendo: ");
            dividendo = Convert.ToDouble(Console.ReadLine());
            // solicitamos al usuario un valor y convertimos
            Console.Write("Por favor ingresa el divisor: ");
            divisor = Convert.ToDouble(Console.ReadLine());

           // Se crea la condicion para el la division entre cero
           if (divisor == 0 || dividendo == 0)
            {
                Console.WriteLine("En matemáticas, la división entre cero es una división en la que el divisor es igual a cero, y que no tiene un resultado bien definido. sigue intentando con divisor diferente a cero. ");
                 return;
                
            }

            resultado = dividendo / divisor;

            if (resultado < 0)
            {
                Console.WriteLine("El resultado de {0} entre {1} es negativo y el resultado es: {2}   ", dividendo, divisor,resultado);
            }
            if (resultado > 0)
            {
                Console.WriteLine("El resultado de {0} entre {1} es positivo y el resultado es: {2}   ", dividendo, divisor, resultado);
            }
           


        }
    }
}
