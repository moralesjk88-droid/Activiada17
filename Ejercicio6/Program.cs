// See https://aka.ms/new-console-template for more information
DateTime fecha;
bool esFecha;

do
{
    Console.Clear();
    Console.WriteLine("Ingrese una fecha");
    esFecha=DateTime.TryParse(Console.ReadLine(), out fecha);

    if (!esFecha)
    {
        Console.WriteLine("Fecha invalida");   
        Console.ReadKey();
    }


}
while (!esFecha);

Console.WriteLine("Fecha corta: " + fecha.ToShortDateString());
Console.ReadKey();