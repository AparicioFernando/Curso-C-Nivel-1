﻿// 1. Hacer un programa para ingresar un número y luego se emita por pantalla un cartel aclaratorio si “Es mayor a 10” o “No es mayor a 10”.

System.Console.WriteLine("Ingrese un número: ");
int numero=int.Parse(Console.ReadLine());

if (numero>10){
    System.Console.WriteLine("Es mayor a 10");
}
else{
    System.Console.WriteLine("No es mayor a 10");
}

Console.ReadKey();