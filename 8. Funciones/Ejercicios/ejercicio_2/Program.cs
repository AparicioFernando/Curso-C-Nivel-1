/*
2. Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es. Hacer un programa para ingresar 20 números y 
mostrar por pantalla cuántos son pares.
*/



int contador=0;
for (int x = 0; x < 20; x++)
{
    System.Console.WriteLine("Ingrese un número: ");
    int numero=int.Parse(Console.ReadLine());
    int n=par(numero);
    if (n==1)
        contador++;
}
System.Console.WriteLine("Usted ingreso "+contador+" números pares");


 int par(int a)
{
    if (a%2==0)
        return 1;
     else
        return 2;
}
