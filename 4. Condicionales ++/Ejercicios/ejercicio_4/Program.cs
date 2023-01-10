// 4. Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si la suma de los dos primeros es mayor al producto del segundo con el tercero

System.Console.WriteLine("Imgrese un número: ");
int a=int.Parse(Console.ReadLine());
System.Console.WriteLine("Imgrese un número: ");
int b=int.Parse(Console.ReadLine());
System.Console.WriteLine("Imgrese un número: ");
int c=int.Parse(Console.ReadLine());

int suma= a+b;
int producto=b*c;

if(suma>producto){
    System.Console.WriteLine("La suma de primer número con el segundo es mayor al producto del segundo número con el tercero");
}
else{
    System.Console.WriteLine("La suma de primer número con el segundo es menor al producto del segundo número con el tercero");

}
