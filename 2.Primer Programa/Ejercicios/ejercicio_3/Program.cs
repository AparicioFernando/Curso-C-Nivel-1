// 3. Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades y la velocidad promedio de un vehículo. Calcular y emitir por pantalla el tiempo aproximado que demandará llegar de un punto a otro teniendo en cuenta los datos ingresados.


System.Console.WriteLine("Ingrese la distancia entre dos ciudades: ");
float distancia=float.Parse(Console.ReadLine());

System.Console.WriteLine("Ingrese la velocidad promedio del vehículo: ");
float velocidad=float.Parse(Console.ReadLine());

float tiempo=distancia/velocidad;

System.Console.WriteLine("El tiempo en recorrer esa distancia es de: "+tiempo);