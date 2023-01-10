// 4. Hacer un programa que solicite UN número y luego calcule y emita un cartel aclaratorio si el mismo es primo o no es primo.  Nota: un numero es primo cuando es divisible únicamente por 1 y por sí mismo.

System.Console.WriteLine("Ingrese un número: ");
int n= int.Parse(Console.ReadLine());

int c=0;

for (int i = 1; i <= n; i++)
{
    if ( n%i==0)
    {
        c++;
    }
}

if (c==2)
{
    System.Console.WriteLine("El número "+n+" es primo");
    c=0;
}
else
{
    System.Console.WriteLine("El número "+n+" no es primo");
    c=0;
}
