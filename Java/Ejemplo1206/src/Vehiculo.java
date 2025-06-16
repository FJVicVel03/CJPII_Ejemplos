public class Vehiculo {
    String marca;
    String modelo;
    int anio;
    String color;

    public Vehiculo(String marca, String modelo, int anio, String color) {
        this.marca = marca;
        this.modelo = modelo;
        this.anio = anio;
        this.color = color;
        System.out.println("Vehiculo creado: " + marca + " " + modelo + " " + anio + " " + color);
    }

    //Constructor sin saber el anio y el color
    public Vehiculo(String marca, String modelo) {
        this.marca = marca;
        this.modelo = modelo;
        this.anio = 2025;
        this.color = "Blanco";
        System.out.println("Vehiculo creado: " + marca + " " + modelo+ " " + anio + " " + color);
    }

    public void mostrarInformacion()
    {
        System.out.println("Marca: " + marca);
        System.out.println("Modelo: " + modelo);
        System.out.println("Anio: " + anio);
        System.out.println("Color: " + color);
    }
}
