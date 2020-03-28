package com.FDGB.x00014419;

public class GeneradorISBN {
    private static int contador = 0;

    private GeneradorISBN(){}

    public static int nuevoISBN(){
        contador++;
        return contador;
    }

    public static int getContador() {
        return contador;
    }
}
