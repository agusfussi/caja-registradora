string NombreSuper = "SuSuper";
Console.Write("Ingrese el nombre del cajero: ");
string NombreCajero = Console.ReadLine();
Console.WriteLine($"Bienvenido {NombreCajero}, a {NombreSuper}.");
Console.ReadKey();

Console.Write("Ingrese el nombre de un producto: ");
string NombreProducto = Console.ReadLine();
Console.Write("Escribe el precio del producto: ");
string PrecioProducto = Console.ReadLine();
Decimal precio = Convert.ToDecimal(PrecioProducto);

Console.WriteLine($"El precio de {NombreProducto} es: {precio}");
Console.ReadKey();