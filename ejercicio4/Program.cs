// See https://aka.ms/new-console-template for more information
int año;
bool esNumero;
int actual=DateTime.Now.Year;

do
{
    Console.WriteLine("Ingrese año de nacimiento");
    esNumero=int.TryParse(Console.ReadLine(), out año);

    if (!esNumero)
    {
        Console.WriteLine("Debe ingresar un numero");
    Console.ReadKey();
    }
    else if (año<1900||año>actual)
    {
        Console.WriteLine("Año fuera de rengo");
   Console.ReadKey();
    }
    else
    {
        Console.WriteLine("Año valido");
        Console.ReadKey();
    }

}
while (!esNumero||año<1900||año>actual);


