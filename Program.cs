
using System;
using System.Runtime.Intrinsics.Arm;
int seguir;
float resultado = 0;
int a = 0, b = 0;
float Valor = 0;
do
{
   
    System.Console.WriteLine("5- Valor absoluto: ");
    System.Console.WriteLine("6- Cuadrado: ");
    System.Console.WriteLine("7- Raiz cuadrada: ");
    System.Console.WriteLine("8- Seno: ");
    System.Console.WriteLine("9- Coseno: ");
    System.Console.WriteLine("10- Parte entera de un real: ");
    System.Console.WriteLine("11- Maximo de dos numeros: ");
    System.Console.WriteLine("12- Minimo de dos numeros: ");
    System.Console.WriteLine("Opcion: ");
    int Opcion = int.Parse(Console.ReadLine());

    if(Opcion >= 5 && Opcion <= 10){
        System.Console.WriteLine("Valor: ");
        Valor = float.Parse(Console.ReadLine());
    } else {
        System.Console.WriteLine("Valor 1:");
        a = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Valor 2:");
        b = int.Parse(Console.ReadLine());
    }

    switch (Opcion)
    {
        case 5: resultado = Math.Abs(Valor);
            break;
        case 6: resultado = (float)Math.Pow(Valor, 2);
            break;
        case 7: if(Valor >= 0){
                    resultado = (float)Math.Sqrt(Valor);
                } else {
                    System.Console.WriteLine("No se puede sacar raiz a numero negativo");
                }
            break;
        case 8: resultado = (float)Math.Sin(Valor);
            break;
        case 9: resultado = (float)Math.Cos(Valor);
            break;
        case 10: resultado = (int)Valor;
            break;
        case 11: resultado = Math.Max(a, b);
            break;
        case 12: resultado = Math.Min(a, b);
            break;
        default: System.Console.WriteLine("Opcion no valida");
            break;
    }


    System.Console.WriteLine($"Resultado: {resultado}");

    System.Console.WriteLine("Seguir ingresando? 1=Si, 0=No");
    seguir = int.Parse(Console.ReadLine());
} while (seguir == 1);