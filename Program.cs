// See https://aka.ms/new-console-template for more information
using System;
using System.Runtime.Intrinsics.Arm;
int seguir;
float resultado = 0;
do
{

    System.Console.WriteLine("Valor 1: ");
    int a = int.Parse(Console.ReadLine());
    System.Console.WriteLine("Valor 2: ");
    int b = int.Parse(Console.ReadLine());

    System.Console.WriteLine("1- Suma: ");
    System.Console.WriteLine("2- Resta: ");
    System.Console.WriteLine("3- Multiplicacion: ");
    System.Console.WriteLine("4- Division: ");
    System.Console.WriteLine("Opcion: ");
    int Opcion = int.Parse(Console.ReadLine());

    switch (Opcion)
    {
        case 1: resultado = a + b;
            break;
        case 2: resultado = a - b;
            break;
        case 3: resultado = a * b;
            break;
        case 4: if(b == 0){
                    System.Console.WriteLine("La division no se puede realizar");
                } else {
                    resultado = (float)a / b;
                }

            break;
        default: System.Console.WriteLine("Opcion ingresada no valida");
            break;
    }

    System.Console.WriteLine($"Resultado: {resultado}");

    System.Console.WriteLine("Seguir ingresando? 1=Si, 0=No");
    seguir = int.Parse(Console.ReadLine());
} while (seguir == 1);