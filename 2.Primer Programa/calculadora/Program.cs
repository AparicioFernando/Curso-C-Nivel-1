// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//paso 0: declarar variables
//  tipo de dato: int, float, char, bool
int n1, n2, r;


//paso 1: pedir valores
Console.WriteLine("Ingrese un número");
n1= int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese otro número");
n2= int.Parse(Console.ReadLine());

//paso 2: realizar cálculo

r=n1+n2;
//paso 3: emitir resultado

Console.WriteLine("El resultado es: "+ r);
