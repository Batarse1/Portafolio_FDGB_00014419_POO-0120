using System;
using semana06_ejercicio02;

public static class ConsolaJuegos{
    public static void comprarJuego(){
        try
        {
            Console.Write("Número de tarjeta: ");
            string numero = Console.ReadLine();
            if (!VerificacionTarjeta(numero))
            {
                throw new WrongCardNumberException("Digito un número de tarjeta inválido, juego no comprado");
            }

            if (Banco.realizarCompras(numero))
            {
                try
                {
                    Console.Write("Nombre del juego: ");
                    string juego = Console.ReadLine();
                    if (juego.Equals(""))
                    {
                        throw new WrongGameName("Digito un nombre de juego inválido, juego no comprado");
                    }

                    if (GestorArchivos.Buscar("Juegos.txt", juego))
                    {
                        throw new WrongGameName("Digito un nombre de juego que usted ya tiene, juego no comprado");
                    }
                    GestorArchivos.Anexar("Juegos.txt", juego);

                    Console.WriteLine("Juego comprado exitosamente!");
                }
                catch (WrongGameName exc)
                {
                        throw new WrongGameName(exc.Message);
                }
            }
            else
            {
                throw new WrongCardNumberException("Número de tarjeta no almacenado, juego no comprado");
            }
        }
        catch (WrongCardNumberException exc)
        {
            Console.WriteLine(exc.Message);
        }
        catch(WrongGameName exc)
        {
            Console.WriteLine(exc.Message);
        }
    }
    
    public static void jugar(){
        try
        {
            Console.Write("Nombre del juego: ");
            string juego = Console.ReadLine();
            if (juego.Equals(""))
            {
                throw new WrongGameName("Digito un nombre de juego inválido");
            }
            if (GestorArchivos.Buscar("Juegos.txt", juego))
                Console.WriteLine("Listo para jugar!");
            else
                Console.WriteLine("Primero debe comprar el juego :(");
        }
        catch(WrongGameName exc)
        {
            Console.WriteLine(exc.Message);
        }
    }
    
    private static bool VerificacionTarjeta(string numeroTarjeta)
    {
        bool tarjetaValida = true;
        if (numeroTarjeta.Length != 11)
        {
            tarjetaValida = false;
        }
        else if (numeroTarjeta[3]!='-' || numeroTarjeta[7]!='-')
        {
            tarjetaValida = false;
        }
        foreach(char c in numeroTarjeta)
        {
            if ((c < 48 && c!= 45) || c > 57)
            {
                tarjetaValida = false;
                break;
            }
        }
        return tarjetaValida;
    }
}