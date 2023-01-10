// 2. Hacer un programa que solicite 10  números enteros y los guarde en un vector. Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores que son mayores al promedio.

int[] numeros= new int [10];
int acumulador=0;


for (int x = 0; x < 10; x++)
{
    System.Console.WriteLine("ingrese un número: ");
    numeros[x]=int.Parse(Console.ReadLine());
    acumulador+=numeros[x];
}
float promedio=acumulador/10;
System.Console.WriteLine("El promedio es: "+promedio);

for (int y = 0; y < 10; y++)
{
    if(numeros[y]>promedio){
        System.Console.WriteLine("El número "+numeros[y]+ "es mayor al promedio");
    }        
}
