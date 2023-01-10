// Bloque IF: condicionales

 System.Console.WriteLine("Ingrese su edad: ");
 int edad=int.Parse(Console.ReadLine());

//  if (edad>20){    
//     if (edad>30)
//         System.Console.WriteLine("30 off");    
//     else
//         System.Console.WriteLine("21 off");    
//  }
// else
//     System.Console.WriteLine("10 off");

if (edad>30)
    System.Console.WriteLine("30 off");
else if(edad>20)
    System.Console.WriteLine("21 off");
else if (edad==18) 
    System.Console.WriteLine("10 off");
else
    System.Console.WriteLine("5 off");
    
Console.ReadKey();