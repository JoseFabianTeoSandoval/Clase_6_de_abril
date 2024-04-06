using Clase_6_de_abril.Clases;

Carro Carrito = new Carro("Toyota", 2024, "Rojo");
Carro Carro2 = new Carro("Nissan", 2020, "Azul");

Carrito.Color = "Rojo";
Carrito.Owner = "Juan";
Carrito.MAXVELOCIDAD = 200;

Console.WriteLine($"El Carro es un {Carrito.Marca} ");
Console.WriteLine($"El Carro es un {Carro2.Marca} ");

Console.WriteLine(Carrito.Acelerar() + "/Kph");
Console.WriteLine(Carrito.Acelerar() + "/Kph");
Console.WriteLine(Carrito.Acelerar() + "/Kph");


