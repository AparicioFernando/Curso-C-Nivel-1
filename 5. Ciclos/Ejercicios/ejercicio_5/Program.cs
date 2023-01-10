// 5. Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo de los números pares y el mínimo de los números impares.

int max_par=0;
int min_impar=0;
int bandera_par=0;
int bandera_impar=0;

for (int x = 0; x < 5; x++)
{
    System.Console.WriteLine("Ingrese un número: ");
    int n=int.Parse(Console.ReadLine());

    if (n%2==0)
    {    
      if (bandera_par==0){
            max_par=n;
            bandera_par=1;
        }
      else{
            if(n>max_par){
                max_par=n;
            }
        }
    }
    else
    {
        if(bandera_impar==0){
            min_impar=n;
            bandera_impar=1;
        }
        else{
            if(n<min_impar){
                min_impar=n;
            }
        }     
    }
}

System.Console.WriteLine("El máximo número par es: "+max_par+"\nEl mínimo número impar es: "+min_impar);