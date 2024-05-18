// See https://aka.ms/new-console-template for more information

using System.ComponentModel;

Console.WriteLine("Hello, World!");

int a;
int b;
a = 10;
b = a;

Console.WriteLine($"valor de a: {a}");
Console.WriteLine($"valor de b: {b}");

Console.WriteLine("Ingrese un valor: ");
int numero = int.Parse(Console.ReadLine());    
int invertido = 0;
while (numero != 0){
    int ultimo = numero % 10;
    invertido = invertido * 10 + ultimo;
    numero = numero / 10;
}

Console.WriteLine($"invertido: {invertido}");