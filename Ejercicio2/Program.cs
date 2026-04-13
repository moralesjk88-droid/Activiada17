// See https://aka.ms/new-console-template for more information

double precio;
bool calcular;
do
{
    Console.Clear();
    Console.WriteLine("Ingrese el precio");
    calcular=double.TryParse(Console.ReadLine(), out precio);
    if (!calcular)
    {
        Console.WriteLine("ERROR DE PRECIO");
        Console.ReadKey();
    }
    
    else
    {
        if (precio<=0)
        {
            Console.WriteLine("Precio no valido");
            Console.ReadKey();
        }
        else
        {
          Console.WriteLine("Precio guardado"); 
            Console.ReadKey();
        }
        
    }


}
while (!calcular||precio<0);
