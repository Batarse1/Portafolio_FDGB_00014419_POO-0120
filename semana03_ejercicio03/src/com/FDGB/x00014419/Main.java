package com.FDGB.x00014419;

import java.util.ArrayList;
import java.util.Scanner;

public class Main {
    ArrayList<Autor> lista_autores = new ArrayList<>();
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        ArrayList<Libro> lista_libros = new ArrayList<>();
        byte option=0;

        int numero_autores=0;
        int numero_libros=0;
        String nombre="\0";
        String email="\0";
        char género='\0';
        int páginas=0;
        int ISBN=0;

        do{
            menu();
            option = scan.nextByte();scan.nextLine();
            switch(option){
                case 1:
                    numero_autores++;
                    System.out.print("Digite el nombre del autor: ");
                    nombre = scan.nextLine();
                    System.out.print("Digite el nombre del email: ");
                    email = scan.nextLine();
                    System.out.print("Digite el genero (m ó f): ");
                    género = scan.next().charAt(0);
                    Autor.requirements(nombre, email, género);
                    for(Autor a: lista_autores){
                        if(a.getNombre().equals(nombre) && a.getEmail().equals(email) && (Character.compare(a.getGénero(),género))==0){
                            throw new IllegalArgumentException("El autor ya existe");
                        }
                    }
                    lista_autores.add(new Autor(nombre, email, género));
                    break;
                case 2:
                    numero_libros++;
                    System.out.printf("Digite el nombre del libro: ");
                    nombre = scan.nextLine();
                    System.out.printf("Digite el número de páginas: ");
                    páginas = scan.nextInt();scan.nextLine();
                    Libro.requirements(nombre,páginas);
                    lista_libros.add(new Libro(nombre,páginas));
                    break;
                case 3:
                    if(numero_autores>0){
                        System.out.println("LISTA DE AUTORES");
                        lista_autores.forEach((a)->System.out.println(a.toString()));
                    }
                    else{
                        System.out.println("No existen autores actualmente");
                    }
                    break;
                case 4:
                    if(numero_libros>0){
                        System.out.println("LISTA DE LIBROS");
                        lista_libros.forEach((a)->System.out.println(a.toString()));
                    }
                    else{
                        System.out.println("No existen libros actualmente");
                    }
                    break;
                case 5:
                    System.out.print("Digite el nombre del autor: ");
                    nombre = scan.nextLine();
                    System.out.print("Digite el nombre del email: ");
                    email = scan.nextLine();
                    System.out.print("Digite el genero (m ó f): ");
                    género = scan.next().charAt(0);
                    Autor.requirements(nombre, email, género);
                    boolean bandera1=false;
                    int cont=0;
                    int contAux=0;
                    for(Autor a: lista_autores){
                        if(a.getNombre().equals(nombre) && a.getEmail().equals(email) && (Character.compare(a.getGénero(),género))==0){
                            bandera1=true;
                            cont=contAux;
                        }
                        contAux++;
                    }
                    if(bandera1==false){
                        System.out.println("El autor no existe");
                    }
                    else{
                        lista_autores.remove(cont);
                        System.out.println("El autor se elimino");
                        numero_autores--;
                    }
                    break;
                case 6:
                    System.out.printf("Digite el ISBN del libro: ");
                    ISBN = scan.nextInt();scan.nextLine();
                    if(Libro.requirementsISBN(ISBN)){
                        int finalISBN = ISBN;
                        lista_libros.removeIf((a)->(a.getISBN() == finalISBN));
                        System.out.println("El libro se a eliminado");
                        numero_libros--;
                    }
                    else{
                        System.out.println("No existe un libro con el ISBN introducido...");
                    }
                    break;
                case 0:
                    System.out.println("Saliendo...");
                    break;
                default:
                    System.out.println("Opción erronea");
                    break;
            }

        }while(option!=0);
    }

    public static void menu(){
        System.out.println("1. Agregar Autor");
        System.out.println("2. Agregar Libro");
        System.out.println("3. Mostrar Autores");
        System.out.println("4. Mostrar Libros");
        System.out.println("5. Eliminar Autor");
        System.out.println("6. Eliminar Libro");
        System.out.println("0. Salir");
    }
}