// 5. Hacer un programa para ingresar 4 números. Luego analizar e informar por pantalla si los mismos se encuentran ordenados de forma decreciente .

System.Console.WriteLine("Imgrese un número: ");
int a=int.Parse(Console.ReadLine());
System.Console.WriteLine("Imgrese un número: ");
int b=int.Parse(Console.ReadLine());
System.Console.WriteLine("Imgrese un número: ");
int c=int.Parse(Console.ReadLine());
System.Console.WriteLine("Imgrese un número: ");
int d=int.Parse(Console.ReadLine());

if (a>b && b>c && c>d)
    System.Console.WriteLine("Los numero fueron elegidos en orden decreciente");
else
    System.Console.WriteLine("Los números no fueron elegidos en orden decreciente");

Console.ReadKey();