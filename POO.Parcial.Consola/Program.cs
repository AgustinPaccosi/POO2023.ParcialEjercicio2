using POO.Parcial.Entidades;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace POO.Parcial.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dia, mes, anio;
            bool validar = true;

            do
            {
                Console.WriteLine("Ingrese el dia: ");
                if(int.TryParse(Console.ReadLine(), out dia))
                { 
                    validar = false;
                }
                else
                {
                    Console.WriteLine("El valor ingresado no es válido.");
                }
            } while (validar);
            validar = true;

            do
            {
                Console.WriteLine("Ingrese el mes: ");
                if (int.TryParse(Console.ReadLine(), out mes))
                {
                    validar = false;
                }
                else
                {
                    Console.WriteLine("El valor ingresado no es válido.");
                }

            } while (validar);
            validar = true;

            do
            {
                Console.WriteLine("Ingrese el anios: ");
                if (int.TryParse(Console.ReadLine(), out anio))
                {
                    validar = false;
                }
                else
                {
                    Console.WriteLine("El valor ingresado no es válido.");
                }

            } while (validar);

            //Console.WriteLine("Ingrese el dia: ");
            //int dia=int.Parse(Console.ReadLine());
            //Console.WriteLine("Ingrese el mes: ");
            //int mes = int.Parse(Console.ReadLine());
            //Console.WriteLine("Ingrese el anio: ");
            //int anio = int.Parse(Console.ReadLine());

            bool esFechaValida = Validador.Validar(dia, mes, anio);
            if (esFechaValida)
            {
                Console.WriteLine("La fecha es válida.");
            }
            else
            {
                Console.WriteLine("La fecha no es válida.");
            }
            Console.ReadLine();
        }
    }
}
