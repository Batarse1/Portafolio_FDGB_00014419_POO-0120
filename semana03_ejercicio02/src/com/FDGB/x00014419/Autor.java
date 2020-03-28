package com.FDGB.x00014419;

public class Autor {
    private String nombre = "\0";
    private String email = "\0";
    private char género = '\0';
    private float pago = 0.00f;

    public Autor(String nombre, String email, char género) {
        this.nombre = nombre;
        this.email = email;
        this.género = género;
    }

    public String getNombre() {
        return nombre;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public char getGénero() {
        return género;
    }

    public static void requirements(String nombre, String email, char género){
        if(género=='m' || género=='f'){
            byte cont=0;
            for(int i=0;i<email.length();i++){
                if(email.charAt(i)=='@'){
                    cont++;
                }
            }
            if(cont!=1){
                throw new IllegalArgumentException("En el email no existe @ o existe más de una");
            }
        }
        else{
            throw new IllegalArgumentException("En el género no se inserto 'm' o 'f'");
        }
    }

    @Override
    public String toString() {
        return nombre + " (" + género + "): " + email ;
    }
}