//Etapa 4
int cantidadProducto = 0;
decimal total = 0;
string opcion;
const decimal descuentoDelDiez = 0.1m;
const decimal descuentoDelCinco = 0.05m;
do
{
    Console.WriteLine("¿Que desea hacer?");
    Console.WriteLine("1. Ingresar un producto");
    Console.WriteLine("2.Cerrar la ventana");
    Console.Write("Ingrese una opción: ");

    opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            Console.Write("Ingrese el nombre de un producto: ");
            string NombreProducto = Console.ReadLine();
            Console.Write("Escribe el precio del producto: ");
            string PrecioProducto = Console.ReadLine();
            Decimal precio = Convert.ToDecimal(PrecioProducto);

            Console.WriteLine($"El precio de {NombreProducto} es: {precio}");

            total += precio;
            cantidadProducto++;


            break;
        case "2":
            Console.WriteLine("Cerrando la ventana...");
            break;
        default:
            Console.WriteLine("No reconocido.");
            break;
    }
} while (opcion != "2");
Console.WriteLine($"Cantidad de productos: {cantidadProducto}");
if (total > 50000)
{
    Console.WriteLine($"Subtotal: {total}");
    Console.WriteLine($"Descuento: {total * descuentoDelDiez}");
    total -= total * descuentoDelDiez;
    Console.WriteLine($"Total de la venta: {total}");

}
else if (total > 20000)
{
    Console.WriteLine($"Subtotal: {total}");
    decimal descuento = total * descuentoDelCinco;
    Console.WriteLine($"Descuento: {descuento}");
    total -= total * descuentoDelCinco;
    Console.WriteLine($"Total de la venta: {total}");
}
else
{
    Console.WriteLine($"Total de la venta: {total}");
}
Console.ReadKey();