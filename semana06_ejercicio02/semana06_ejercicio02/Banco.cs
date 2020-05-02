using System;
using System.Runtime.CompilerServices;
using semana06_ejercicio02;

public static class Banco{
    public static void registrarTarjeta(){
        try
        {
            Console.Write("Número de tarjeta: ");
            string numero = Console.ReadLine();
            if (!VerificacionTarjeta(numero))
            {
                throw new WrongCardNumberException("Digito un número de tarjeta inválido, tarjeta no creada");
            }
            GestorArchivos.Anexar("Tarjetas.txt", numero);

            Console.WriteLine("Tarjeta creada exitosamente!");
        }
        catch(WrongCardNumberException exc)
        {
            Console.WriteLine(exc.Message);
        }
    }
    
    public static void consultarTarjetas(){
        Console.WriteLine(GestorArchivos.Leer("Tarjetas.txt"));
    }
    
    public static bool realizarCompras(string tarjeta){
        return GestorArchivos.Buscar("Tarjetas.txt", tarjeta);
    }

    private static bool VerificacionTarjeta(string numeroTarjeta)
    {
        bool tarjetaValida = true;
        if (GestorArchivos.Buscar("Tarjetas.txt", numeroTarjeta))
        {
            tarjetaValida = false;
        }
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