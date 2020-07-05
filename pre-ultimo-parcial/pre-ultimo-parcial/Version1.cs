using System;
using System.Collections.Generic;
using pre_ultimo_parcial.Properties;

namespace pre_ultimo_parcial
{
    public class Version1 : Interfaz
    {
        public Version1()
        {
        }

        public void Funcionamiento()
        {
            //List<Persona> p = new List<Persona>();
            var lista = new List<Persona>();
            lista.Add(new Persona(nombre:"Walter", apellido:"Rafael", edad: 20));
            lista.Add(new Persona("Batar", edad:19));
            lista.Add(new Persona(edad:19));
            lista.Add(new Persona(apellido:"Morales"));

            Console.Write("Nombre a cambiar: ");
            String buscar = Console.ReadLine();
      
            lista.ForEach(it =>
            {
                if (buscar.Equals(it.Nombre))
                {
                    Console.Write("Nuevo nombre: ");
                    it.Nombre = Console.ReadLine();
                    Console.WriteLine(it.ToString());
                }

                int añadir = 12;
                int árbol = 14;
            });   
        }

        public void Datos()
        {
            Console.WriteLine("Fecha: 23/04/2020");
            Console.WriteLine("Lenguaje utilizado: C#");
            Console.WriteLine("Tipo de evaluación: meeting y laboratorio");
            Console.WriteLine("Link de Github: https://github.com/Batarse1/00014419_FDGB_POO/tree/master/Meet/Meet2304/Meet2304");
        }
        
        public void Comentarios()
        {
            Console.WriteLine("En la primera versión:\n" +
                              "Se creo una lista\n" +
                              "Se instanciaron objetos\n" +
                              "Se creo un método");
        }
    }
}