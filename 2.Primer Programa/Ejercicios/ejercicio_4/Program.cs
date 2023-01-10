// 4. Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 más una comisión del 5% sobre el total facturado por cada empleado. Hacer un programa para ingresar el total facturado por un empleado y que luego calcule y emita por pantalla el sueldo total a cobrar por el mismo.

const int fijo=15000;

System.Console.WriteLine("Ingrese total facturado por el empleado: ");
double total_facturado=double.Parse(Console.ReadLine());

double sueldo=fijo+(total_facturado*0.05);

System.Console.WriteLine("El sueldo total a cobrar es de : $"+sueldo);