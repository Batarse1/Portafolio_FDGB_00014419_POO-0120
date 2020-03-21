package com.FDGB.x00014419;

public class Recipiente {
    private String estado;
    private int cantidad;
    private int limite;

    public Recipiente(String estado, int cantidad, int limite) {
        this.estado = estado;
        this.cantidad = cantidad;
        this.limite = limite;
    }

    public Recipiente() {
        this.estado = "Nuevo";
        this.cantidad = 0;
        this.limite = 1000;
    }

    public void llenar(int nueva_cantidad){
        if(nueva_cantidad+cantidad>limite){
            System.out.println("El recipiente no se puede llenar");
        }
        else{
            cantidad+=nueva_cantidad;
            System.out.println("El recipiente se ha llenado con la cantidad ingresada");
        }
    }

    public void romper(){
        if(estado.equals("Destrozado")){
            System.out.println("El recipiente ya se encontraba destrozado");
        }
        else{
            estado = "Destrozado";
            System.out.println("El recipiente se encuentra destrozado");
        }
    }

    public void setEstado(String estado) {
        this.estado = estado;
    }

    public void setCantidad(int cantidad) {
        this.cantidad = cantidad;
    }

    public void setLimite(int limite) {
        this.limite = limite;
    }

    public String getEstado() {
        return estado;
    }

    public int getCantidad() {
        return cantidad;
    }

    public int getLimite() {
        return limite;
    }
}
