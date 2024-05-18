class Program
{
    static void Main()
    {
        // Solicitar al usuario que ingrese un conjunto de números separados por espacios
        Console.WriteLine("Ingrese un conjunto de números separados por espacios:");
        string input = Console.ReadLine();
        HashSet<int> numbers = new HashSet<int>(input.Split(' ').Select(int.Parse));

        // Obtener el conjunto de números ordenados de menor a mayor
        HashSet<int> sortedNumbers = GetSortedNumbers(numbers);

        // Mostrar el conjunto de números ordenados
        Console.WriteLine("Conjunto de números ordenados de menor a mayor:");
        foreach (int number in sortedNumbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }

    static HashSet<int> GetSortedNumbers(HashSet<int> numbers)
    {
        // Convertir el conjunto de números en una lista y ordenarla
        List<int> sortedList = numbers.ToList();
        sortedList.Sort();

        // Crear un nuevo conjunto a partir de la lista ordenada
        HashSet<int> sortedNumbers = new HashSet<int>(sortedList);

        return sortedNumbers;
    }
}