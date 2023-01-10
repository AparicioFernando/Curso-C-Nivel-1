// 4. Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla el menor de ellos.

System.Console.WriteLine("Ingrese el primer número: ");
int num1=int.Parse(Console.ReadLine());

System.Console.WriteLine("Ingrese el segundo número: ");
int num2=int.Parse(Console.ReadLine());

System.Console.WriteLine("Ingrese el tercer número: ");
int num3=int.Parse(Console.ReadLine());

System.Console.WriteLine("Ingrese el cuarto número: ");
int num4=int.Parse(Console.ReadLine());

int menor;

// if (num1<num2){
//     if (num1<num3){
//         if (num1<num4)
//             System.Console.WriteLine("El primer número es el menor de todos");
//         else
//             System.Console.WriteLine("El cuarto número es el menor de todos");
//     }
// }
// else if (num2<num3){
//     if (num2<num4)
//         System.Console.WriteLine("El segundo número es el menor");
//     else
//         System.Console.WriteLine("El cuarto número es el menor de todos");
// }
// else if (num3<num4)
//     System.Console.WriteLine("El tercer número es el menor");
// else
//     System.Console.WriteLine("El cuarto número es el menor");

if (num1<num2)
    menor=num1;
else
    menor=num2;
if (num3<menor)
    menor=num3;
else
    menor=num4;

System.Console.WriteLine("El menor es: "+ menor);


Console.ReadKey();