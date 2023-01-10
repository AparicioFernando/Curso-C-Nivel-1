/*
1.Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos. Luego hacer un programa que pida el precio de un 
artículo y la cantidad vendida y muestre por pantalla el monto total a pagar. Usar la función.
*/

System.Console.WriteLine("Ingrese precio del artículo");
int precio=int.Parse(Console.ReadLine());
System.Console.WriteLine("Ingrese cantidad vendida");
int cantidad=int.Parse(Console.ReadLine());

int monto=producto(precio,cantidad);
System.Console.WriteLine("El monto total a pagar es: $"+monto);


int producto(int a, int b)
{
    int r=a*b;
    return r;
}