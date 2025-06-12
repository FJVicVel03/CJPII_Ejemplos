public class Auto {
    String marca;
    String modelo;
    int anio;
    String color;


    //Constructor principal
    public Auto(String marca, String modelo, int anio, String color) {
        this.marca = marca;
        this.modelo = modelo;
        this.anio = anio;
        this.color = color;
        System.out.println("Se ha creado un auto nuevo: " + marca + " " + modelo + ", Año: " + anio + ", Color: " + color);
    }

    // Otro constructor (sobrecarga de constructores)
    // Este constructor toma solo la marca y el modelo
    public Auto(String marca, String modelo) {
        this.marca = marca;
        this.modelo = modelo;
        this.anio = 2025; // Valor por defecto
        this.color = "Blanco"; // Valor por defecto
        System.out.println("Se ha creado un auto nuevo: " + marca + " " + modelo + ", Año: " + anio + ", Color: " + color);
    }

    public void mostrarDatos()
    {
        System.out.println("Marca: " + marca);
        System.out.println("Modelo: " + modelo);
        System.out.println("Año: " + anio);
        System.out.println("Color: " + color);
    }

}
