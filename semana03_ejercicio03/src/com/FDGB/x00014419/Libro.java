package com.FDGB.x00014419;

public class Libro {
    private int ISBN = 0;
    private String nombre = "\0";
    private int páginas = 0;

    public Libro(String nombre, int páginas) {
        this.ISBN = GeneradorISBN.nuevoISBN();
        this.nombre = nombre;
        this.páginas = páginas;
    }

    public int getISBN() {
        return ISBN;
    }

    public static void requirements(String nombre, int páginas){
        if(páginas<=0){
            throw new IllegalArgumentException("El número de páginas no puede ser negativo");
        }
    }

    public static boolean requirementsISBN(int ISBN){
        if(ISBN>GeneradorISBN.getContador() || ISBN<0){
            return false;
        }
        else{
            return true;
        }
    }

    @Override
    public String toString() {
        return ISBN + ": " + nombre + " (" + páginas +')';
    }
}