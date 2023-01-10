// 1. Hacer un programa que solicite 10 números enteros y los guarde en un vector. Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.

int[] numeros= new int[10];
int mayor=0, posicion=0;

for (int x = 0; x < 10; x++)
{
    System.Console.WriteLine("Ingrese un número: ");
    numeros[x]=int.Parse(Console.ReadLine());
}

for (int y = 0; y < 10; y++)
{
    if(y==0){
        mayor=numeros[0];
        posicion=y+1;
    }
    else{
        if(numeros[y]>mayor){
            mayor=numeros[y];
            posicion=y+1;
        }
    }
}
System.Console.WriteLine("El número ingresado mayor es: "+ mayor + " y se ubica en la posicio: " + posicion);