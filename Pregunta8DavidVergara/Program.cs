using System;
using System.Net.NetworkInformation;

interface IPais
{
    void ColorBandera(); // interface method (does not have a body)
    void Tamaño();
    void Idiomas();
}

class Ecuador : IPais
{
    public void ColorBandera()
    {
        // The body of animalSound() is provided here
        Console.WriteLine("El color de la bandera de Ecuador es : Amarillo , Azul , y Rojo");
    }
    public void Tamaño()
    {
        Console.WriteLine("El Tamaño es:283,561 km²");
    }

    public void Idiomas()
    {
        Console.WriteLine("El idioma es: Español");
    }
}
class Andorra : IPais
{
    public void ColorBandera()
    {
        // The body of animalSound() is provided here
        Console.WriteLine("El color es : Azul,Amarillo , Rojo");
    }
    public void Tamaño()
    {
        Console.WriteLine("El Tamaño de Andorra es:468 km²");
    }

    public void Idiomas()
    {
        Console.WriteLine("El idioma es: el catalán, el español, el francés y el portugués");
    }
}
class Brasil : IPais
{
    public void ColorBandera()
    {
        // The body of animalSound() is provided here
        Console.WriteLine("El color es : Verde , Amarillo , Azul");
    }
    public void Tamaño()
    {
        Console.WriteLine("El Tamaño de brasil es:8.51 millones km²");
    }

    public void Idiomas()
    {
        Console.WriteLine("El idioma de brasil es:el portugués");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Ecuador myEcuador = new Ecuador();  // Create a Pig object
        myEcuador.ColorBandera();
        Andorra myAndorra = new Andorra();  // Create a Pig object
        myAndorra.Tamaño();
        Brasil myBrasil = new Brasil();  // Create a Pig object
        myBrasil.Idiomas();


    }
}