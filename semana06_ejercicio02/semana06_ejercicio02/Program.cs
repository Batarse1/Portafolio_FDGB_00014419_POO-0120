﻿using System;

namespace semana06_ejercicio02
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            bool continuar = true;
            do{
                try
                {
                    Console.Write(menu());
                    int opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            Banco.registrarTarjeta();
                            break;
                        case 2:
                            Banco.consultarTarjetas();
                            break;
                        case 3:
                            ConsolaJuegos.comprarJuego();
                            break;
                        case 4:
                            ConsolaJuegos.jugar();
                            break;
                        case 5:
                            continuar = false;
                            break;
                        default:
                            Console.WriteLine("Opcion errónea!");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Digite un número...");
                }
            }while(continuar);
            Console.WriteLine("\nTenga un buen día!");
        }
        static string menu(){
            return "\nBienvenido:\n" +
                   "1) Registrar tarjeta (banco).\n" +
                   "2) Consultar tarjetas (banco).\n" +
                   "3) Comprar videojuego (consola).\n" +
                   "4) Jugar videojuego (consola).\n" +
                   "5) Salir.\n" +
                   "Opción elegida: ";
        }
    }
}