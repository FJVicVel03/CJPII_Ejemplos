package Clases;

public class Main {
    public static void main(String[] args) {
        Persona p1 = new Persona("Jonatan", 17);

        System.out.println("Nombre: " + p1.getNombre());
        System.out.println("Edad: " + p1.getEdad());

        //Usar los setters para modificar datos

        p1.setNombre("Erick");
        p1.setEdad(16);
        System.out.println("Nombre: " + p1.getNombre());
        System.out.println("Edad: " + p1.getEdad());

        //Datos invalidos

        p1.setNombre("");
        p1.setEdad(-5);
        //System.out.println("Nombre: " + p1.getNombre());
        //System.out.println("Edad: " + p1.getEdad());
    }
}
