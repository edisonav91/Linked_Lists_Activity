using DoubleList;

internal class Program
{
    private static void Main(string[] args)
    {
        var list = new DoublyLinkedList<string>();
        var opc = "0";

        do
        {
            opc = Menu();
            switch (opc)
            {
                case "1":
                    Console.Write("Enter the data to insert at the beginning: ");
                    var dataAtBeginning = Console.ReadLine();
                    if (dataAtBeginning != null)
                    {
                        list.InsertAtBeginning(dataAtBeginning);
                    }
                    break;

                case "2":
                    Console.Write("Enter the data to insert at the end: ");
                    var dataAtEnd = Console.ReadLine();
                    if (dataAtEnd != null)
                    {
                        list.InsertAtEnd(dataAtEnd);
                    }
                    break;

                case "3":
                    Console.WriteLine(list.GetForward());
                    break;

                case "4":
                    Console.WriteLine(list.GetBack.ward());
                    break;

                case "5":
                    Console.Write("Enter the data to remove: ");
                    var remove = Console.ReadLine();
                    if (remove != null)
                    {
                        list.Remove(remove);
                        Console.WriteLine("Item removed.");
                    }
                    break;
            }
        }
        while (opc != "0");

        string Menu()
        {
            Console.WriteLine("1. Adicionar.");
            Console.WriteLine("2. Mostrar hacia adelante.");
            Console.WriteLine("3. Mostrar hacia atrás.");
            Console.WriteLine("4. Ordenar decentemente.");
            Console.WriteLine("5. Mostrar la(s) moda(s).");
            Console.WriteLine("6. Mostrar gráfico.");
            Console.WriteLine("7. Existe.");
            Console.WriteLine("8. Eliminar una ocurrencia.");
            Console.WriteLine("9. Eliminar todas las ocurrencias.");
            Console.WriteLine("0. Salir.");
            Console.Write("Seleccione una opción: ");
            return Console.ReadLine() ?? "0";
        }

    }
}