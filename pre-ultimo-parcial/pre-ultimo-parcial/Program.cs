using System;
using System.Collections.Generic;
using pre_ultimo_parcial.Properties;

namespace pre_ultimo_parcial
{
    internal class Program 
    {
        public static void Main(string[] args)
        {
            Interfaz implementacion = null;
            byte opt = 0;
            do
            {
                menu();
                try
                {
                    opt = Convert.ToByte(Console.ReadLine());
                }
                catch (Exception)
                {
                    opt = 3;
                }
                if (opt == 1)
                {
                    implementacion = new Version1();
                }
                else if (opt == 2)
                {
                    implementacion = new Version2();
                }
                else
                {
                    Console.WriteLine("Opción invalida");   
                }
                MetodosInterfaz(implementacion);
            } while (opt != 0);
        }
        private static void menu()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("MENU");
            Console.WriteLine("1. Versión 1");
            Console.WriteLine("2. Versión 2");
            Console.WriteLine("0. Salir");
            Console.WriteLine("----------------------------");
        }
        private static void MetodosInterfaz(Interfaz i)
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("FUNCIONAMIENTO");
            Console.WriteLine("----------------------------");
            i.Funcionamiento();
            Console.WriteLine("----------------------------");
            Console.WriteLine("DATOS");
            Console.WriteLine("----------------------------");
            i.Datos();
            Console.WriteLine("----------------------------");
            Console.WriteLine("COMENTARIOS");
            Console.WriteLine("----------------------------");
            i.Comentarios();
        }
    }
}