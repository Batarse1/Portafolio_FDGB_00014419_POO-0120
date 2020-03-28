package com.FDGB.x00014419;

public class Libro {
    private String ISBN = "\0";
    private String nombre = "\0";
    private int páginas = 0;

    public Libro(String ISBN, String nombre, int páginas) {
        this.ISBN = ISBN;
        this.nombre = nombre;
        this.páginas = páginas;
    }

    public String getISBN() {
        return ISBN;
    }

    public static void requirements(String nombre, int páginas){
        if(páginas<=0){
            throw new IllegalArgumentException("El número de páginas no puede ser negativo");
        }
    }

    @Override
    public String toString() {
        return ISBN + ": " + nombre + " (" + páginas +')';
    }
}