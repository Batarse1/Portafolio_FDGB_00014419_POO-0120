package com.FDGB.x00014419;

public class Laptop {
    private boolean encendido;
    private boolean jugarCSGO;

    public Laptop(boolean encendido, boolean jugarCsgo) {
        this.encendido = encendido;
        this.jugarCSGO = jugarCsgo;
    }

    public Laptop() {
        this.encendido = false;
        this.jugarCSGO = false;
    }

    public void encenderComputadora(){
        if(encendido==true){
            System.out.println("La computadora ya se encontraba encendida");
        }
        else{
            System.out.println("La computadora se acaba de encender...");
        }
    }

    public void jugarCSGO(){
        if(encendido==true){
            jugarCSGO=true;
            System.out.println("Jugando CSGO...");
        }
        else{
            System.out.println("No se puede jugar CSGO porque no esta encendida la computadora");
        }
    }

    public void setEncendido(boolean encendido) {
        this.encendido = encendido;
    }

    public void setJugarCSGO(boolean jugarCSGO) {
        this.jugarCSGO = jugarCSGO;
    }

    public boolean getEncendido() {
        return encendido;
    }

    public boolean getJugarCSGO() {
        return jugarCSGO;
    }
}
