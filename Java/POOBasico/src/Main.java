//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
    public static void main(String[] args) {
        Operacion op = new Operacion();

        op.pedirNumeros();
        op.Sumar();
        op.Restar();
        op.Multiplicacion();
        op.Division();
        op.mostrarResultado();

    }
}