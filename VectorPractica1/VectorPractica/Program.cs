class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingresar la longitud del vector: ");
        int longitud = int.Parse(Console.ReadLine());
        Vector vector = new Vector(longitud);
;
        for (int i = 0; i < vector.ObtenerLongitud(); i++)
        {
            Console.Write($"Elemento {i + 1}: ");
            int newvalor = int.Parse(Console.ReadLine());
            vector.PonerElemento(i, newvalor);
        }

        Console.WriteLine("\nVector original:");
        vector.MostrarVector();

        Console.WriteLine("\nSelector ModificarLongitud");
        Console.Write("Ingresar la nueva longitud: ");
        int nuevalong = int.Parse(Console.ReadLine());
        vector.ModificarLongitud(nuevalong);
        Console.WriteLine("Vector después de la modificacion:");
        vector.MostrarVector();

        Console.WriteLine("\nSelector PonerElemento");
        Console.Write("Ingresar la posición donde poner el elemento: ", vector.ObtenerLongitud() - 1);
        int posicion = int.Parse(Console.ReadLine());
        Console.Write("Ingresar el valor: ");
        int valor = int.Parse(Console.ReadLine());
        vector.PonerElemento(posicion, valor);
        Console.WriteLine("Vector después de poner el elemento:");
        vector.MostrarVector();

        Console.WriteLine("\nSelector ObtenerElemento");
        Console.Write("Ingresar la posición del elemento que desea obtener: ", vector.ObtenerLongitud() - 1);
        posicion = int.Parse(Console.ReadLine());
        Console.WriteLine($"Elemento en la posición {posicion}: {vector.ObtenerElemento(posicion)}");

        Console.WriteLine("\nAlgoritmo SelectionSort:");
        vector.SelectionSort();
        vector.MostrarVector();

        Console.WriteLine("\nAlgoritmo InsertionSort:");
        vector.InsertionSort();
        vector.MostrarVector();

        Console.WriteLine("\nAlgoritmo MergeSort:");
        vector.MergeSort();
        vector.MostrarVector();
    }
}