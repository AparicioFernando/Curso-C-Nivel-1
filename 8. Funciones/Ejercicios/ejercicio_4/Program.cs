/*
4. Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero” que reciba un número por valor y una variable por referencia. 
Que analice el número y escriba variable recibida por referencia con:

a. 1 si el número es positivo.
b. -1 si el número es negativo.
c. 0 si el número es cero.
*/

System.Console.WriteLine("Ingrese un número a analizar: ");
int n1=int.Parse(Console.ReadLine());

int estado=0;

positivoNegativoCero (n1, ref estado);

System.Console.WriteLine("El estado del valor "+n1+" es: "+estado);


void positivoNegativoCero(int a, ref int b)
{
    if (a<0){
        b=-1;
    }
    else if (a==0){
        b=0;
    }
    else{
        b=1;
    }
         
}