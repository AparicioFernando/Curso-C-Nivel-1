// 2. Un importante negocio de desinfectante líquido realiza descuentos dependiendo de la cantidad de litros vendidos según la siguiente escala:

// Si vende menos de 100 litros, no hay descuento.
// Si vende entre 101 y 300 litros, el descuento es del 10%.
// Si vende entre 301 y 500 litros, el descuento es del 15%.
// Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
// Hacer un programa que solicite el ingreso del importe total de la venta y la cantidad de litros vendidos y calcule y emita el importe con el descuento  aplicado..

System.Console.WriteLine("Ingrese el importe: ");
int importe=int.Parse(Console.ReadLine());
System.Console.WriteLine("Ingrese cantidad de litros vendidos: ");
int litros=int.Parse(Console.ReadLine());

float ImporteTotal;

if (litros<100)
    ImporteTotal=importe;
else if (litros>100 && litros<301)
    ImporteTotal=importe*0.9f;
else if (litros>300 && litros<501)
    ImporteTotal=importe*0.85f;
else
    ImporteTotal=importe*0.75f;

System.Console.WriteLine("El importe total de la compra es de: $"+ImporteTotal);