/*
3. Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos). El programa deberá generar una cadena donde todas las ocurrencias del primer 
carácter dado hayan sido reemplazadas por el segundo. Mostrar el resultado en pantalla. Ejemplo:
CADENA FUENTE: “La mar estaba serena"
CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
CADENA RESULTADO: “Li mir estibi sereni"
*/


// char[] frase=new char[30];
// char letraActual;
// char letraNueva;
// char letra;
// letra= char.Parse(Console.ReadLine());
// int indice=0;


// System.Console.WriteLine("Ingrese una letra: ");
// letra=char.Parse(Console.ReadLine());

// while(letra != '0' && indice<30)
// {
//     frase[indice]=letra;    //En frase, en el índice que yo cree voy asignar esa letra


//     System.Console.WriteLine("Ingrese otra letra: ");
//     letra=char.Parse(Console.ReadLine());

//     indice++;

// }
// frase[indice]='\0';
// System.Console.WriteLine("La frase completa es: ");
// indice=0;
// while (frase[indice]!=0)
// {
//     System.Console.Write(frase[indice]);
//     indice++;
// }

// System.Console.WriteLine("Ingrese letra a remplazar: ");
// letraActual=char.Parse(Console.ReadLine());
// System.Console.WriteLine("Ingrese letra nueva: ");
// letraNueva=char.Parse(Console.ReadLine());
// indice=0;

// while (frase[indice]!='\0')
// {
//     if(frase[indice]==letraActual)
//     {
//         frase[indice]=letraNueva;
//     }    
//     indice++;
// }

// System.Console.WriteLine("La frase nueva es: ");
// indice=0;

// while (frase[indice]!='\0')
// {
//     System.Console.Write(frase[indice]);
//     indice++;
// }

string frase;
char letraActual;
char letraNueva;

System.Console.WriteLine("Ingrese la frase: ");
frase=Console.ReadLine();
System.Console.WriteLine("Ingrese la letra a remplazar: ");
letraActual=char.Parse(Console.ReadLine());
System.Console.WriteLine("Ingrese la letra nueva");
letraNueva=char.Parse(Console.ReadLine());

frase=frase.Replace(letraActual, letraNueva);

System.Console.WriteLine("La cade nueva es: ");
System.Console.WriteLine(frase);