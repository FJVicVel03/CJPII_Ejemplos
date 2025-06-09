import javax.swing.*;
//Importar scanner
import java.util.Scanner;

public class Operacion {
    int numero1;
    int numero2;
    int suma;
    int resta;
    int multiplicacion;
    int division;


    public void pedirNumeros()
    {
        //Pedir al usuario los datos
        Scanner sc = new Scanner(System.in);
        System.out.println("Digite el primer numero: ");
        numero1 = sc.nextInt();
        System.out.println("Digite el segundo numero: ");
        numero2 = sc.nextInt();
    }

    public void Sumar()
    {
        suma = numero1 + numero2;
    }
    public void Restar()
    {
        resta = numero1 - numero2;

    }
    public void Multiplicacion()
    {
        multiplicacion = numero1 * numero2;
    }
    public void Division()
    {
        division = numero1 / numero2;
    }

    public void mostrarResultado()
    {
        System.out.println("La suma es: " + suma);
        System.out.println("La resta es: " + resta);
        System.out.println("La multiplicacion es: " + multiplicacion);
        System.out.println("La division es: " + division);
    }
}
