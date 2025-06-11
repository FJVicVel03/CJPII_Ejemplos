package Clases;
import javax.swing.JOptionPane;


public class Main {
    public static void main(String[] args) {
        int n1;
        int n2;

        n1 = Integer.parseInt(JOptionPane.showInputDialog("Ingrese numero 1: "));
        n2 = Integer.parseInt(JOptionPane.showInputDialog("Ingrese numero 2: "));

        Operacion op = new Operacion();


        System.out.println("La suma es:" + op.Suma(n1,n2));
        System.out.println("La resta es:" + op.Restar(n1,n2));
        System.out.println("La multiplicacion es:" + op.Multiplicacion(n1,n2));
        System.out.println("La division es:" + op.Division(n1,n2));

    }
}
