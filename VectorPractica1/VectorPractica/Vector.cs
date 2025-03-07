class Vector
{
    private const int MAX = 1000;
    private int[] elementos;
    private int longitud;

    public Vector(int n)
    {
        if (n > MAX || n <= 0)
            Console.WriteLine($"La longitud debe estar entre 1 y {MAX}.");
        longitud = n;
        elementos = new int[longitud];
    }

    public void ModificarLongitud(int nuevalong)
    {
        if (nuevalong > MAX)
        {
            Console.WriteLine($"La longitud no puede ser mayor a {MAX}.");
        }

        if (nuevalong > longitud)
        {
            int[] nuevoArr = new int[nuevalong];
            Array.Copy(elementos, nuevoArr, longitud);
            for (int i = longitud; i < nuevalong; i++)
            {
                Console.Write($"Elemento {i + 1}: ");
                nuevoArr[i] = int.Parse(Console.ReadLine());
            }
            elementos = nuevoArr;
        }
        else
        {
            Array.Resize(ref elementos, nuevalong);
        }
        longitud = nuevalong;
    }

    public int ObtenerLongitud()
    {
        return longitud;
    }

    public void PonerElemento(int posicion, int valor)
    {
        if (posicion < 0 || posicion >= longitud)
            Console.WriteLine("Índice fuera de rango.");
        elementos[posicion] = valor;
    }

    public int ObtenerElemento(int posicion)
    {
        if (posicion < 0 || posicion >= longitud)
            Console.WriteLine("Índice fuera de rango.");
        return elementos[posicion];
    }

    public void SelectionSort()
    {
        for (int i = 0; i < longitud - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < longitud; j++)
            {
                if (elementos[j] < elementos[minIndex])
                    minIndex = j;
            }
            (elementos[i], elementos[minIndex]) = (elementos[minIndex], elementos[i]);
        }
    }

    public void InsertionSort()
    {
        for (int i = 1; i < longitud; i++)
        {
            int clave = elementos[i];
            int j = i - 1;
            while (j >= 0 && elementos[j] > clave)
            {
                elementos[j + 1] = elementos[j];
                j--;
            }
            elementos[j + 1] = clave;
        }
    }

    public void MergeSort()
    {
        MergeSortAux(0, longitud - 1);
    }

    private void MergeSortAux(int izquierda, int derecha)
    {
        if (izquierda < derecha)
        {
            int medio = izquierda + (derecha - izquierda) / 2;
            MergeSortAux(izquierda, medio);
            MergeSortAux(medio + 1, derecha);
            Merge(izquierda, medio, derecha);
        }
    }
    
    private void Merge(int izquierda, int medio, int derecha)
    {
        int[] izquierdaArr = new int[medio - izquierda + 1];
        int[] derechaArr = new int[derecha - medio];

        Array.Copy(elementos, izquierda, izquierdaArr, 0, medio - izquierda + 1);
        Array.Copy(elementos, medio + 1, derechaArr, 0, derecha - medio);

        int i = 0, j = 0, k = izquierda;
        while (i < izquierdaArr.Length && j < derechaArr.Length)
        {
            if (izquierdaArr[i] <= derechaArr[j])
                elementos[k++] = izquierdaArr[i++];
            else
                elementos[k++] = derechaArr[j++];
        }
        while (i < izquierdaArr.Length)
            elementos[k++] = izquierdaArr[i++];
        while (j < derechaArr.Length)
            elementos[k++] = derechaArr[j++];
    }

    public void MostrarVector()
    {
        for (int i = 0; i < longitud; i++)
        {
            Console.Write(elementos[i] + " ");
        }
        Console.WriteLine();
    }
}