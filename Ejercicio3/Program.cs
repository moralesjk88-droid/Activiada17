// See https://aka.ms/new-console-template for more information
int estudiante;
bool esNumero;

do
{
    Console.Clear();
    Console.WriteLine("Ingrese la cantidad de estudiantes");
    esNumero=int.TryParse(Console.ReadLine(), out estudiante);
    if (!esNumero)
    {
        Console.WriteLine("ERROR: NUMERO NO VALIDO");
        Console.ReadKey();
    }
    else if (estudiante<=0)
    {
        Console.WriteLine("Debe ser posiva");
    }
    else
    {
        Console.WriteLine("Cantidad guardada");
    }



}
while (!esNumero||estudiante<=0);





