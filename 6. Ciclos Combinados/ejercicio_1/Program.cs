// 1. Hacer un programa para ingresar 10 números. El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos.




int primo=0;

for (int i = 0; i < 10; i++)
{
    System.Console.WriteLine("Ingrese un número: ");
    int n=int.Parse(Console.ReadLine());

    int c=0;

    for (int x = 1; x <= n; x++)
    {
        if(n % x == 0)
            c++;        
    }

    if (c==2)
    {
        primo++;
        c=0;
    }
    else
    {
        c=0;
    }
      
}

System.Console.WriteLine("Usted ingreso "+primo+" números primos");