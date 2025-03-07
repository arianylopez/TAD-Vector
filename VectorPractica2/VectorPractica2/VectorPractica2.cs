class Vector
{
    private int[] elementos;
    private int size;

    public Vector(int longitud)
    {
        elementos = new int[longitud];
        size = 0;
    }

    public void InsertarValor(int valor, int posicion, int index = 0)
    {
        if (size == elementos.Length)
        {
            int[] nuevoArr = new int[elementos.Length * 2];
            for (int i = 0; i < size; i++)
            {
                nuevoArr[i] = elementos[i];
            }
            elementos = nuevoArr;
        }

        if (index == posicion)
        {
            for (int i = size; i > posicion; i--)
            {
                elementos[i] = elementos[i - 1];
            }
            elementos[posicion] = valor;
            size++;
        }
        else
        {
            InsertarValor(valor, posicion, index + 1);
        }
    }

    public void EliminarElemento(int posicion, int index = 0)
    {
        if (index == posicion)
        {
            for (int i = posicion; i < size - 1; i++)
            {
                elementos[i] = elementos[i + 1];
            }
            size--;
        }
        else
        {
            EliminarElemento(posicion, index + 1);
        }
    }

    public bool CompararVectores(Vector nuevoVec)
    {
        if (size != nuevoVec.size)
        {
            return false;
        }

        for (int i = 0; i < size; i++)
        {
            if (elementos[i] != nuevoVec.elementos[i])
            {
                return false;
            }
        }
        return true;
    }

    public Vector Union(Vector nuevoVec)
    {
        Vector uniones = new Vector(size + nuevoVec.size);

        for (int i = 0; i < size; i++)
        {
            if (!uniones.contieneAux(elementos[i]))
            {
                uniones.InsertarValor(elementos[i], uniones.size, 0);
            }
        }

        for (int i = 0; i < nuevoVec.size; i++)
        {
            if (!uniones.contieneAux(nuevoVec.elementos[i]))
            {
                uniones.InsertarValor(nuevoVec.elementos[i], uniones.size, 0);
            }
        }

        return uniones;
    }

    public bool Subconjunto(Vector nuevoVec)
    {
        for (int i = 0; i < nuevoVec.size; i++)
        {
            if (!contieneAux(nuevoVec.elementos[i]))
            {
                return false;
            }
        }
        return true;
    }

    public void EliminarDuplicados()
    {
        for (int i = 0; i < size; i++)
        {
            for (int j = i + 1; j < size; j++)
            {
                if (elementos[i] == elementos[j])
                {
                    EliminarElemento(j, 0);
                    j--;
                }
            }
        }
    }

    private bool contieneAux(int valor)
    {
        for (int i = 0; i < size; i++)
        {
            if (elementos[i] == valor)
            {
                return true;
            }
        }
        return false;
    }

    public void Mostrar()
    {
        for (int i = 0; i < size; i++)
        {
            Console.Write(elementos[i]);
            if (i < size - 1)
            {
                Console.Write(", ");
            }
        }
    }
}