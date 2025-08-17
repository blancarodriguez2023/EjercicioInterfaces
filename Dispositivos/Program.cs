using System;
using Dispositivos;

class Program
{
    static void Main(string[] args)
    {
       
             Telefono iphone = new Telefono
        {
            Marca = "Apple",
            Modelo = "iPhone 14 Pro Max",
            EstaEncendido = false
        };

           Laptop dell = new Laptop
        {
            Marca = "Dell",
            Modelo = "XPS 15",
            EstaEncendido = false,
            NivelBateria = 78
        };

      
         Console.WriteLine("=== ESTADO INICIAL ===");
        iphone.MostrarEstado();
        dell.MostrarEstado();
        Console.WriteLine();

        
          Console.WriteLine("=== ENCENDER DISPOSITIVOS ===");
        iphone.Encender();
        dell.Encender();
        iphone.MostrarEstado();
        dell.MostrarEstado();
        Console.WriteLine();

        Console.WriteLine("=== APAGAR DISPOSITIVOS ===");
        iphone.Apagar();
        dell.Apagar();
        iphone.MostrarEstado();
        dell.MostrarEstado();
        Console.WriteLine();
    }
}