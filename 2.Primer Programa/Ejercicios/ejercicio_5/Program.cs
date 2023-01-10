// 5. Hacer un programa para ingresar por teclado las tres notas de exámenes de un alumno y luego calcule y emita por pantalla el promedio final.

System.Console.WriteLine("Ingrese la primera nota: ");
float nota1= float.Parse(Console.ReadLine());

System.Console.WriteLine("Ingrese la segunda nota: ");
float nota2= float.Parse(Console.ReadLine());

System.Console.WriteLine("Ingrese la tercera nota: ");
float nota3= float.Parse(Console.ReadLine());

float suma=nota1+nota2+nota3;

float promedio=suma/3;


System.Console.WriteLine("El promedio final es de: "+ promedio.ToString("0.00"));