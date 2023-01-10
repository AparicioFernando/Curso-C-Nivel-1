// 3. Una importante marca de computadoras permite elegir cierta configuración del equipo a comprar. Para ello existe la siguiente escala de precios:

// i5 (1)	i7 (2)	i9 (3)
// 8 RAM (1)	USD 800	USD 900	USD 1200
// 16 RAM (2)	USD 900	USD 1000	USD 1400
// 32 RAM (3)	USD 1000	USD 1400	USD 2000
// Además, el equipo viene con un disco que permite almacenar 500 GB de información y que se puede ampliar a 1 TB si así lo desea, lo cual tiene un costo  adicional de USD 300. Hacer un programa que solicite la opción de procesador, la opción de memoria  RAM, y si extiende el disco o no (ingresa 1 para extender y 0 para no extender) y calcule y emita por pantalla el monto de la máquina seleccionada.

System.Console.WriteLine("OPCIONES DE MICROPROCESADOR: \n 1. i5 \n 2. i7 \n 3. i9");
System.Console.WriteLine("Ingrese la opción de microprocesador: ");
string opcionMicro=Console.ReadLine();

System.Console.WriteLine("OPCIONES DE MEMORIA RAM: \n 1. 8GB \n 2. 16GB \n 3. 32GB");
System.Console.WriteLine("Ingrese la opción de memoria RAM: ");
string opcionMemoria=Console.ReadLine();

System.Console.WriteLine("OPCIONES DE EXTENSIÓN DE DISCO: \n 1. SI \n 0. NO");
System.Console.WriteLine("Ingrese la opción: ");
string opcionDisco=Console.ReadLine();

switch(opcionMicro){
    case "1":
        switch(opcionMemoria){
            case "1":
                if (opcionDisco=="1")
                    System.Console.WriteLine("El costo es de U$D 1100");                
                else 
                    System.Console.WriteLine("El costo es de U$D 800");
                break; 
            case "2":
                if (opcionDisco=="1")
                    System.Console.WriteLine("El costo es de U$D 1200");                
                else 
                    System.Console.WriteLine("El costo es de U$D 900");
                break;
            case "3":
                if (opcionDisco=="1")
                    System.Console.WriteLine("El costo es de U$D 1300");                
                else 
                    System.Console.WriteLine("El costo es de U$D 1000");
                break;           
        }
        break;

    case "2":
        switch(opcionMemoria){
            case "1":
                if (opcionDisco=="1")
                    System.Console.WriteLine("El costo es de U$D 1200");                
                else 
                    System.Console.WriteLine("El costo es de U$D 900");
                break; 
            case "2":
                if (opcionDisco=="1")
                    System.Console.WriteLine("El costo es de U$D 1300");                
                else 
                    System.Console.WriteLine("El costo es de U$D 1000");
                break;
            case "3":
                if (opcionDisco=="1")
                    System.Console.WriteLine("El costo es de U$D 1700");                
                else 
                    System.Console.WriteLine("El costo es de U$D 1400");
                break;           
        }
        break;
    
    case "3":
        switch(opcionMemoria){
            case "1":
                if (opcionDisco=="1")
                    System.Console.WriteLine("El costo es de U$D 1500");                
                else 
                    System.Console.WriteLine("El costo es de U$D 1200");
                break; 
            case "2":
                if (opcionDisco=="1")
                    System.Console.WriteLine("El costo es de U$D 1700");                
                else 
                    System.Console.WriteLine("El costo es de U$D 1400");
                break;
            case "3":
                if (opcionDisco=="1")
                    System.Console.WriteLine("El costo es de U$D 2300");                
                else 
                    System.Console.WriteLine("El costo es de U$D 2000");
                break;           
        }
        break;
            
}