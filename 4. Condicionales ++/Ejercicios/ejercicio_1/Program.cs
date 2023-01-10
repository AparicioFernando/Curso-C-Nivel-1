// 1. Hacer un programa que solicite el ingreso de dos números y luego calcular:

// La resta si el primero es mayor que el segundo.
// La suma si son iguales.
// El producto si el primero es menor.
// Se deberá emitir un cartel por pantalla con el resultado correspondiente.

System.Console.WriteLine("Ingrese un número: ");
int n1=int.Parse(Console.ReadLine());
System.Console.WriteLine("Ingrese otro número: ");
int n2=int.Parse(Console.ReadLine());

int r;

if (n1>n2){
    r=n1-n2;
    System.Console.WriteLine("La resta entre los número es: "+r);
}
else if (n1==n2){
    r=n1+n2;
    System.Console.WriteLine("La suma entre los número es: "+r);
}
else{
    r=n1*n2;
    System.Console.WriteLine("El producto entre los número es: "+r);
}