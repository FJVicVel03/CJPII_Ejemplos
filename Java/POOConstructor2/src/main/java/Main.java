public class Main {
    public static void main(String[] args) {
        //Crear el objeto de la case Auto
        Auto auto1 = new Auto("Toyota", "Corolla", 2020, "Rojo");
        auto1.mostrarDatos();

        //Crear otro objeto de la clase Auto usando el segundo constructor
        Auto auto2 = new Auto("Honda", "Civic");
        auto2.mostrarDatos();

        // Crear un tercer objeto de la clase Auto usando el primer constructor
        Auto auto3 = new Auto("Ford", "Focus", 2018, "Azul");
        auto3.mostrarDatos();
    }
}
