//Etapa 5
int cantidadProducto = 0;
decimal total = 0;
string opcion;
string opcionPago;
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
do
{
    Console.WriteLine("Medio de pago: ");
    Console.WriteLine("1 - Efectivo");
    Console.WriteLine("2 - Debito");
    Console.WriteLine("3 - Credito");
    Console.Write("Ingrese una opción: ");

    opcionPago = Console.ReadLine();
    switch (opcionPago)
    {
        case "1":
            Console.WriteLine("Pago en efectivo tiene un 10% de descuento");
            Console.WriteLine($"Descuento: {total * 0.1m}");
            total -= total * 0.1m;
            Console.WriteLine($"Total a pagar con descuento: {total}");
            break;
        case "2":
            Console.WriteLine($"Pago con tarjeta de debito es el mismo monto, Total: {total}");
            break;
        case "3":
            Console.WriteLine("Pago con tarjeta de credito tiene un 15% de recargo");
            Console.WriteLine($"Recargo: {total * 0.15m}");
            total += total * 0.15m;
            Console.WriteLine($"Total a pagar con recargo: {total}");
            break;
        default:
            Console.WriteLine("Opción no reconocida.");
            break;
    }
} while (opcionPago != "1" && opcionPago != "2" && opcionPago != "3");

Console.ReadKey();