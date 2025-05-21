using DoubleList;

var lista = new DoublyLinkendList<string>();

    string opcion;

    do
    {
        Console.WriteLine("1. Adicionar");
        Console.WriteLine("2. Mostrar hacia adelante");
        Console.WriteLine("3. Mostrar hacia atrás");
        Console.WriteLine("4. Ordenar descendentemente");
        Console.WriteLine("5. Mostrar moda(s)");
        Console.WriteLine("6. Mostrar gráfico");
        Console.WriteLine("7. Verificar existencia");
        Console.WriteLine("8. Eliminar una ocurrencia");
        Console.WriteLine("9. Eliminar todas las ocurrencias");
        Console.WriteLine("0. Salir");
        Console.Write("Seleccione una opción: ");
        opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":
                Console.Write("Ingrese el dato a adicionar: ");
                var dato = Console.ReadLine();
                lista.Adicionar(dato);
                break;

            case "2":
                Console.WriteLine("Lista hacia adelante:");
                lista.MostrarAdelante();
                break;

            case "3":
                Console.WriteLine("Lista hacia atrás:");
                lista.MostrarAtras();
                break;

            case "4":
                lista.OrdenarDescendente();
                Console.WriteLine("Lista ordenada descendentemente.");
                break;

            case "5":
                lista.Modas();
                Console.WriteLine("Mostrar la(s) Moda(s)");
                break;

            case "6":
                lista.Grafico();
                Console.WriteLine("Mostrar Grafico.");

                break;

            case "7":
            Console.Write("Ingrese el valor a buscar: ");
            var buscar = Console.ReadLine();

            if (lista.Existe(buscar))
                Console.WriteLine("El valor existe en la lista.");
            else
                Console.WriteLine("El valor NO existe en la lista.");

            break;

            case "8":
                Console.Write("Eliminar una Ocurrencia: ");
                var uno = Console.ReadLine();
                lista.EliminarUno(uno);
                break;

            case "9":
                Console.Write("Eliminar todas las ocurrencias: ");
                var todos = Console.ReadLine();
                lista.EliminarTodos(todos);
                break;

            case "0":
                Console.WriteLine("Saliendo...");
                break;

            default:
                Console.WriteLine("Opción no válida.");
                break;
        }

    } while (opcion != "0");

