package com.FDGB.x00014419;

public class Main {
    public static void main(String[] args){
        Laptop compu1 = new Laptop(true, false);
        Laptop compu2 = new Laptop();
        Recipiente recipiente1 = new Recipiente();
        Recipiente recipiente2 = new Recipiente("Nuevo",10,100);
        compu1.encenderComputadora();
        compu2.encenderComputadora();
        compu1.jugarCSGO();
        recipiente1.llenar(10000);
        recipiente1.romper();
        recipiente2.llenar(50);
    }
}