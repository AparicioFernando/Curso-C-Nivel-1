// 2. Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. Se pide determinar e informar:

//      El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
//      Informar cuántos grupos están formados por todos números ordenados de mayor a menor.



int n, conNumeros, conImpar, grupoImparesMaximo=0, min, contadorOrdenados=0;
double porcentajeImpares, porcentajeMaximo=-1;
bool banderaOrdenado;

for (int x = 0; x<5; x++)
{
    System.Console.WriteLine("Ingrese número: ");
    n=int.Parse(Console.ReadLine());

    conNumeros=0;
    conImpar=0;
    banderaOrdenado=true;
    min=n;
    while (n!=0)
    {
        conNumeros++;
        if(n%2!=0)
            conImpar++;

        if (n<=min)
            min=n;
        else
            banderaOrdenado=false;

        System.Console.WriteLine("Ingrese número: ");
        n=int.Parse(Console.ReadLine());           
    }
    porcentajeImpares=conImpar*100/conNumeros;
    if (porcentajeImpares>porcentajeMaximo)
    {
        porcentajeMaximo=porcentajeImpares;
        grupoImparesMaximo=x+1;
    }
    if (banderaOrdenado)
        contadorOrdenados++;  
}

Console.WriteLine("El grupo con mayor porcentaje de impares es: "+grupoImparesMaximo);
Console.WriteLine("La cantidad de grupos con números ordenados es: "+contadorOrdenados);
