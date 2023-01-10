// 3. Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero. El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista.


int n,con=0, numeroGrupo=0;

do 
{
    numeroGrupo++;
    System.Console.WriteLine("Ingrese un numero: ");
    n=int.Parse(Console.ReadLine());

    while (n>0)
    {
        con++;

        System.Console.WriteLine("Ingrese un numero: ");
        n=int.Parse(Console.ReadLine());
    }
    System.Console.WriteLine("La lista "+numeroGrupo+ " tiene: "+con+" números");

}while (n>=0);
