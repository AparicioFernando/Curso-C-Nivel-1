// 5. Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuáles son mayores a 100.


System.Console.WriteLine("Ingrese el primer número: ");
int num1=int.Parse(Console.ReadLine());
System.Console.WriteLine("Ingrese el segundo número: ");
int num2=int.Parse(Console.ReadLine());
System.Console.WriteLine("Ingrese el tercer número: ");
int num3=int.Parse(Console.ReadLine());
System.Console.WriteLine("Ingrese el cuarto número: ");
int num4=int.Parse(Console.ReadLine());

int contador=0;

if (num1>100){
    System.Console.Write(num1+", ");
    contador++;
}
if (num2>100){
    System.Console.Write(num2+", ");
    contador++;
}
if (num3>100){
    System.Console.Write(num3+", ");
    contador++;
}
if (num4>100){
    System.Console.Write(num4+", ");
    contador++;
}
if (contador!=0)
    System.Console.WriteLine("son mayor a 100");
else
    System.Console.WriteLine("No hay números mayores a 100");