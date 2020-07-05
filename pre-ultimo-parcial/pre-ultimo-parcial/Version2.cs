using System;
using System.Collections.Generic;

namespace pre_ultimo_parcial.Properties
{
    public class Version2 : Interfaz
    {
        public Version2()
        {
        }

        public void Funcionamiento()
        {
            var dictionary = new Dictionary<int, Persona>();
            var nombre = "\0";
            var apellido = "\0";
            var edad = 0;
            var key = 0;
            byte opt = 0;
            do
            {
                Menu();
                try
                {
                    opt = Convert.ToByte(Console.ReadLine());
                }
                catch (Exception)
                {
                    opt = 5;
                }
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("----------------------------");
                switch (opt)
                {
                    case 0:
                        break;
                    case 1:
                        try
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("Nombre: ");
                            nombre = Console.ReadLine();
                            Console.Write("Apellido: ");
                            apellido = Console.ReadLine();
                            Console.Write("Edad: ");
                            edad = Convert.ToInt32(Console.ReadLine());
                            dictionary.Add(key, new Persona(nombre, apellido, edad));
                            key++;
                        }
                        catch(Exception)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("----------------------------");
                            Console.WriteLine("Acción no finalizada\nDatos incorrectos");
                        }
                        break;
                    case 2:
                        try
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            bool exist = false;
                            Console.Write("Nombre a cambiar: ");
                            String s = Console.ReadLine();
                            foreach (Persona i in dictionary.Values)
                            {
                                if (s.Equals(i.Nombre))
                                {
                                    Console.Write("Nuevo nombre: ");
                                    i.Nombre = Console.ReadLine();
                                    Console.WriteLine("----------------------------");
                                    Console.WriteLine($"INFORMACIÓN ACTUALIZADA DE LA PERSONA\nNombre: {i.Nombre}\nApellido: {i.Apellido}\nEdad: {i.Edad}");
                                }
                            }

                            if (!exist)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("----------------------------");
                                Console.WriteLine("Acción no finalizada\nNombre a cambiar inexistente");
                            }
                        }
                        catch (Exception)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("----------------------------");
                            Console.WriteLine("Acción no finalizada\nDatos incorrectos");
                        }
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("LISTA DE PERSONAS");
                        foreach (Persona i in dictionary.Values)
                        {
                            Console.WriteLine($"\nNombre: {i.Nombre}\nApellido: {i.Apellido}\nEdad: {i.Edad}");
                        }
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.White;
                        foreach (Persona i in dictionary.Values)
                        {
                            Console.WriteLine(i.saludar("te saluda"));
                        }
                        break;
                    default:
                        Console.WriteLine("Opción inválida");
                        break;
                }
                Console.ForegroundColor = ConsoleColor.White;
            } while (opt != 0);
        }
        
        private static void Menu()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("----------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("MENU");
            Console.WriteLine("1. Agregar Persona");
            Console.WriteLine("2. Cambiar nombre de persona");
            Console.WriteLine("3. Ver personas");
            Console.WriteLine("4. Saludar personas");
            Console.WriteLine("0. Salir");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("----------------------------");
            Console.ForegroundColor = ConsoleColor.White;
        }
        
        public void Datos()
        {
            Console.WriteLine("Fecha: 1/07/2020");
            Console.WriteLine("Lenguaje utilizado: C#");
            Console.WriteLine("Tipo de evaluación: pre-parcial-final");
            Console.WriteLine("Link de Github: ---");
        }

        public void Comentarios()
        {
            Console.WriteLine("En la segunda versión:\n" +
                              "Se agrego un menú\n" +
                              "Se cambio la lista por un diccionario para mejorar la rápidez de búsqueda\n" +
                              "Se mejoro la presentación");
        }
    }
}