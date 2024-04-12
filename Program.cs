using Clase_6_de_abril.Clases;

Carro Carrito = new Carro("Toyota", 2024, "Rojo");
Carrito.Color = "Rojo";
Carrito.Owner = "Juan";
Carrito.MAXVELOCIDAD = 200;

{
    bool continuar = true;

    while (continuar)
    {
        Console.WriteLine("Selecciona una opcion:");
        Console.WriteLine("1. Encender el carro");
        Console.WriteLine("2. Apagar el carro");
        Console.WriteLine("3. Acelerar");
        Console.WriteLine("3. Desacelerar");
        Console.WriteLine("5. Frenar");
        Console.WriteLine("6. Salir");
        string opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":

                break;
            case "2":

                break;
            case "3":

                break;
            case "4":

                break;
            case "5":

                break;
            case "6":
                continuar = false;
                break;
            default:
                Console.WriteLine("Opción no valida.");
                break;
        }
    }
}



//Console.WriteLine("presione 1 para encender");

//Console.WriteLine($"El Carro es un {Carrito.Marca} ");
//Console.WriteLine($"El Carro es un {Carro2.Marca} ");

//Console.WriteLine(Carrito.Acelerar() + "/Kph");
//Console.WriteLine(Carrito.Acelerar() + "/Kph");
//Console.WriteLine(Carrito.Acelerar() + "/Kph");


