// 3. Una casa de video juegos otorga un descuento dependiendo del importe de la compra realizada según los siguientes valores:

// Si el importe es menor a ARS 1000, no hay descuento.
// Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10%.
// Si el importe es ARS 5000 o más, aplica un descuento del 18%.
// Hacer un programa para ingresar un importe de venta y luego muestre por pantalla el importe final con el descuento que corresponda.

System.Console.WriteLine("Ingrese importe de venta: ");
float importe=float.Parse(Console.ReadLine());

float total_pagar=0;

if (importe<5000){
    if (importe>1000)
        total_pagar=importe-(importe*0.1f);    
    else
        total_pagar=importe;    
}
else
    total_pagar=importe-(importe*0.18f);

System.Console.WriteLine("El total a pagar es: "+total_pagar);
Console.ReadKey();

