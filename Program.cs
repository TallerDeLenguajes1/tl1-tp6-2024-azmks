// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Hello, World!");

int a;
int b;

a = 10;
b = a;

Console.WriteLine("Valor de a: "+a);
Console.WriteLine("Valor de b: "+b);

// EJERCICIO 1 

int num = Console.Read();

Console.WriteLine("Valor de num: "+num);

if (num != 0)
    num = 1 / num;

Console.WriteLine("Valor de num: "+num);