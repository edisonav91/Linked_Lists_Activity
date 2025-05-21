namespace DoubleList;

public class DoublyLinkendList<T> where T : IComparable<T>
{
    private DoubleNode<T>? _head;
    private DoubleNode<T>? _tail;

    public DoublyLinkendList()
    {
        _tail = null;
        _head = null;
    }

    public void Adicionar(T data)
    {
        var newNode = new DoubleNode<T>(data);

        if (_head == null || data.CompareTo(_head.Data) <= 0)
        {
            newNode.Next = _head;
            if (_head != null) _head.Prev = newNode;
            _head = newNode;
            if (_tail == null) _tail = newNode;
            return;
        }

        var current = _head;
        while (current.Next != null && data.CompareTo(current.Next.Data) > 0)
        {
            current = current.Next;
        }

        newNode.Next = current.Next;
        newNode.Prev = current;
        if (current.Next != null) current.Next.Prev = newNode;
        current.Next = newNode;
        if (newNode.Next == null) _tail = newNode;
    }


    public void MostrarAdelante()
    {
        var actual = _head;
        int posicion = 1;

        while (actual != null)
        {
            var anterior = actual.Prev != null ? actual.Prev.Data.ToString() : "null";
            var siguiente = actual.Next != null ? actual.Next.Data.ToString() : "null";

            Console.WriteLine($"[{posicion}] Prev: {anterior} | Actual: {actual.Data} | Next: {siguiente}");

            actual = actual.Next;
            posicion++;
        }

        if (_head == null)
        {
            Console.WriteLine("La lista está vacía.");
        }
    }

    public void MostrarAtras()
    {
        var actual = _tail;
        int posicion = 1;

        while (actual != null)
        {
            var anterior = actual.Prev != null ? actual.Prev.Data.ToString() : "null";
            var siguiente = actual.Next != null ? actual.Next.Data.ToString() : "null";

            Console.WriteLine($"[{posicion}] Prev: {anterior} | Actual: {actual.Data} | Next: {siguiente}");

            actual = actual.Prev;
            posicion++;
        }

        if (_tail == null)
        {
            Console.WriteLine("La lista está vacía.");
        }
    }

    public void OrdenarDescendente()
    {
        var datos = new List<T>();
        var actual = _head;

        while (actual != null)
        {
            datos.Add(actual.Data);
            actual = actual.Next;
        }

        datos.Sort((a, b) => b.CompareTo(a));

        _head = _tail = null;

        foreach (var item in datos)
        {
            var nuevo = new DoubleNode<T>(item);
            if (_head == null)
            {
                _head = _tail = nuevo;
            }
            else
            {
                _tail.Next = nuevo;
                nuevo.Prev = _tail;
                _tail = nuevo;
            }
        }

        actual = _head;
        while (actual != null)
        {
            Console.Write($"{actual.Data}");
            if (actual.Next != null) Console.Write(", ");
            actual = actual.Next;
        }
        Console.WriteLine();
    }

    public void Modas()
    {
        var actual = _head;
        var conteo = new Dictionary<T, int>();

        while (actual != null)
        {
            if (conteo.ContainsKey(actual.Data))
                conteo[actual.Data]++;
            else
                conteo[actual.Data] = 1;

            actual = actual.Next;
        }

        if (conteo.Count == 0)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }

        int max = conteo.Values.Max();

        foreach (var item in conteo)
        {
            if (item.Value == max)
                Console.Write(item.Key + " ");
        }

        Console.WriteLine();
    }

    public void Grafico()
    {
        var conteo = new Dictionary<T, int>();
        var actual = _head;

        while (actual != null)
        {
            if (conteo.ContainsKey(actual.Data))
                conteo[actual.Data]++;
            else
                conteo[actual.Data] = 1;

            actual = actual.Next;
        }

        foreach (var par in conteo)
        {
            Console.Write($"{par.Key} ");
            for (int i = 0; i < par.Value; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        if (conteo.Count == 0)
        {
            Console.WriteLine("La lista está vacía.");
        }
    }

    public bool Existe(T valor)
    {
        var actual = _head;

        while (actual != null)
        {
            if (actual.Data.Equals(valor))
                return true;

            actual = actual.Next;
        }

        return false;
    }

    public void EliminarUno(T valor)
    {
        var actual = _head;

        while (actual != null)
        {
            if (actual.Data.Equals(valor))
            {
                if (actual == _head) _head = actual.Next;
                if (actual == _tail) _tail = actual.Prev;
                if (actual.Prev != null) actual.Prev.Next = actual.Next;
                if (actual.Next != null) actual.Next.Prev = actual.Prev;
                Console.WriteLine("Elemento eliminado.");
                return;
            }

            actual = actual.Next;
        }

        Console.WriteLine("Elemento no encontrado.");
    }

    public void EliminarTodos(T valor)
    {
        var actual = _head;
        bool encontrado = false;

        while (actual != null)
        {
            var siguiente = actual.Next;

            if (actual.Data.Equals(valor))
            {
                if (actual == _head) _head = actual.Next;
                if (actual == _tail) _tail = actual.Prev;
                if (actual.Prev != null) actual.Prev.Next = actual.Next;
                if (actual.Next != null) actual.Next.Prev = actual.Prev;
                encontrado = true;
            }

            actual = siguiente;
        }

        Console.WriteLine(encontrado ? "Elementos eliminados." : "Elemento no encontrado.");
    }

}

