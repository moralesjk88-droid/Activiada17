// See https://aka.ms/new-console-template for more information
int num;
bool esNumero;

do
{
    Console.Clear();
    Console.WriteLine("Ingrese un numero");
    esNumero = int.TryParse(Console.ReadLine(), out num);
    if (!esNumero)
    {
        Console.WriteLine("Debe ingresar un numero");
    }

}
while (!esNumero);

if (num%2==0)
{
    Console.WriteLine("Es par");
    }
else
{
    Console.WriteLine("Es impar");
}
