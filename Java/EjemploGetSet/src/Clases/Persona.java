package Clases;

public class Persona {
    private String nombre;
    private int edad;

    public Persona(String nombre, int edad)
    {
        this.nombre = nombre;
        this.edad = edad;
    }
    //Getters
    public String getNombre() {
        return nombre;
    }
    public int getEdad() {
        return edad;
    }
    //Setters
    public void setNombre(String nuevoNombre) {
        //validar que el nombre no esté vacío
        if(nuevoNombre != null && nuevoNombre != "")
        {
            this.nombre = nuevoNombre;
        }else {
            System.out.println("Nombre invalido");
        }

    }
    public void setEdad(int nuevaEdad) {
        if(nuevaEdad > 0)
        {
            this.edad = nuevaEdad;
        }else
        {
            System.out.println("Edad invalido");
        }
    }

}
