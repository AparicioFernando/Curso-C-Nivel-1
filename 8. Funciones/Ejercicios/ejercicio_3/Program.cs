/*
3. Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero si no lo es. Hacer un programa para ingresar números. 
El lote corta cuando se ingresa un número cero. Informar el promedio teniendo en cuenta sólo los números primos.
*/

int contadorPrimo=0, contadorTotal=0; 
float promedio;

System.Console.WriteLine("Ingrese un número: ");
int num=int.Parse(Console.ReadLine());


while (num !=0)
{
    contadorTotal++;
    int numero=primo(num);
    if (numero==1)
        contadorPrimo++;

    System.Console.WriteLine("Ingrese un número");
    num=int.Parse(Console.ReadLine());

}

promedio=contadorPrimo*100/contadorTotal;

System.Console.WriteLine("El promedio de números primos ingresados es: "+promedio);


int primo (int a)
{
    int c=0;
    for (int i = 1; i <= a; i++)
    {
        if (a%i==0)
            c++;
    }
    if(c==2)  
        return 1;        
    else
        return 0;
}