using System;

namespace TPFinal_Aparicio
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero. A partir de dichos datos informar:

                a. El mayor de los números pares.
                b. La cantidad de números impares.
                c. El menor de los números primos.

            Nota: evaluar el uso de una función que analice si un número dado es primo o no y que devuelva true o false según corresponda.
            */

            int numero, mayorPar=0, contadorImpar=0, menorPrimo=0;
            bool banderaPar=false, esPrimo, banderaPrimo=false;


            System.Console.WriteLine("Ingrese número: ");
            numero=int.Parse(Console.ReadLine());

            while (numero!=0)
            {
                if(numero%2==0)         //Punto a
                {
                    if(banderaPar)
                    {
                        if (numero>mayorPar)
                            mayorPar=numero;
                    }
                    else
                    {
                        mayorPar=numero;
                        banderaPar=true;
                    }
                }
                else                    //Punto b
                    contadorImpar++;

                esPrimo= primo(numero); //Punto c
                if(esPrimo)
                {
                    if(banderaPrimo)
                    {
                        if (numero<menorPrimo)
                            menorPrimo=numero;
                    }
                    else
                    {
                        menorPrimo=numero;
                        banderaPrimo=true;
                    }
                }
                System.Console.WriteLine("Ingrese número: ");
                numero=int.Parse(Console.ReadLine());
            }

            System.Console.WriteLine("El mayor de los número pares es: "+mayorPar);             //punto a
            System.Console.WriteLine("La cantidad de números impares es: "+contadorImpar);      //punto b
            System.Console.WriteLine("El menor de los números primos es: "+menorPrimo);         //punto c
        }

        static bool primo (int n)
        {
            int c=0;
            for (int x = 1; x <= n; x++)
            {
                if (n%x==0)
                    c++;
            }
            if (c==2)
                return true;
            else
                return false;
        }
    }
}
