// 2. Hacer un programa que solicite el ingreso de 10 números y que muestre el mayor de ellos por pantalla. Solo se debe emitir UN valor por pantalla.

int mayor=0;


for (int x=0; x<10;x++){
    System.Console.WriteLine("Ingrese un número: ");
    int numero=int.Parse(Console.ReadLine());
    if (x==0){
        mayor=numero;
    }
    else{
        if (numero>mayor){
            mayor=numero;
        }
    }
}

System.Console.WriteLine("El número mayor es: "+mayor);
