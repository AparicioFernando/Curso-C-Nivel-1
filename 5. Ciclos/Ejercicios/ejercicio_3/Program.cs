// 3. Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años.

int mayores=0;
int personas=0;

for (int i = 0; i < 5; i++)
{
    System.Console.WriteLine("Ingrese edad: ");
    int edad= int.Parse(Console.ReadLine());
    if (edad>18){
        personas++;
        mayores+=edad;
    }
}

if (personas!=0){
    float promedio=mayores/personas;
    System.Console.WriteLine("El promedio de edades mayores a 18 es: "+promedio);
}
else
    System.Console.WriteLine("No hay edades mayores a 18");

