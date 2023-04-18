// See https://aka.ms/new-console-template for more information
Console.Write("Por favor, escriba su nombre ");
var nombre = Console.ReadLine();
int longitudNombre = nombre.Length;

var nombreInvertido = "";
for (int i = longitudNombre - 1; i >= 0; i--)
{
    nombreInvertido = nombreInvertido + nombre[i];
}
Console.WriteLine("Adiós " + nombreInvertido);
