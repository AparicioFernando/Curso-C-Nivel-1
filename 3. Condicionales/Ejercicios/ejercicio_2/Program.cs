// 2. Hacer un programa para ingresar un número y luego se emita un cartel por pantalla “Positivo” si el número es mayor a cero, “Negativo” si el número es menor a cero o “Cero” si el número es igual a cero.

System.Console.WriteLine("Ingrese un número: ");
int numero=int.Parse(Console.ReadLine());

if (numero==0)
    System.Console.WriteLine("Cero");
else if (numero>0)
    System.Console.WriteLine("Positivo");
else
    System.Console.WriteLine("Negativo");

Console.ReadKey();
