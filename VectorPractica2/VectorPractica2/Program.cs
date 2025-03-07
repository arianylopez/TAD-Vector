class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingresar la longitud del vector 1: ");
        int longitud1 = int.Parse(Console.ReadLine());
        Vector vector1 = new Vector(longitud1);

        for (int i = 0; i < longitud1; i++)
        {
            Console.Write($"Elemento {i + 1}: ");
            int valor = int.Parse(Console.ReadLine());
            vector1.InsertarValor(valor, i, 0);
        }
        Console.WriteLine("Vector 1: ");
        vector1.Mostrar();

        Console.WriteLine("\nInsertar Elemento");
        Console.Write("Ingresar Posicion: ");
        int posicionInsertar = int.Parse(Console.ReadLine());
        Console.Write("Ingresar Valor: ");
        int valorInsertar = int.Parse(Console.ReadLine());
        vector1.InsertarValor(valorInsertar, posicionInsertar, 0);
        Console.WriteLine("Vector Modificado: ");
        vector1.Mostrar();

        Console.WriteLine("\nEliminar Elemento");
        Console.Write("Ingresar Posicion: ");
        int posicionEliminar = int.Parse(Console.ReadLine());
        vector1.EliminarElemento(posicionEliminar, 0);
        Console.WriteLine("Vector Modificado: ");
        vector1.Mostrar();

        Console.Write("\nIngresar longitud del vector 2: ");
        int longitud2 = int.Parse(Console.ReadLine());
        Vector vector2 = new Vector(longitud2);

        for (int i = 0; i < longitud2; i++)
        {
            Console.Write($"Elemento {i + 1}: ");
            int valor = int.Parse(Console.ReadLine());
            vector2.InsertarValor(valor, i, 0);
        }

        bool sonIguales = vector1.CompararVectores(vector2);
        Console.WriteLine("\nComparar Vectores");
        Console.WriteLine("¿Los vectores son iguales? " + sonIguales);

        Vector union = vector1.Union(vector2);
        Console.Write("\nUnion de los vectores: ");
        union.Mostrar();

        bool subconjunto1 = vector1.Subconjunto(vector2);
        bool subconjunto2 = vector2.Subconjunto(vector1);
        Console.WriteLine("\n¿El vector1 es subconjunto del vector2? " + subconjunto1);
        Console.WriteLine("\n¿El vector2 es subconjunto del vector1? " + subconjunto2);

        Console.WriteLine("\nEliminar Duplicados");
        Console.Write("Ingresar longitud para vector 3: ");
        int longitud3 = int.Parse(Console.ReadLine());
        Vector vector3 = new Vector(longitud3);

        for (int i = 0; i < longitud3; i++)
        {
            Console.Write($"Elemento {i + 1}: ");
            int valor = int.Parse(Console.ReadLine());
            vector3.InsertarValor(valor, i, 0);
        }

        vector3.EliminarDuplicados();
        Console.Write("\nVector sin duplicados: ");
        vector3.Mostrar();
    }
}