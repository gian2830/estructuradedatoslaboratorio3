class Program
{
    static void Main()
    {
        // Solicitar al usuario que ingrese un conjunto de números separados por espacios
        Console.WriteLine("Ingrese un conjunto de números separados por espacios:");
        string input = Console.ReadLine();
        HashSet<int> numbers = new HashSet<int>(input.Split(' ').Select(int.Parse));

        // Obtener el conjunto de números duplicados
        HashSet<int> duplicateNumbers = GetDuplicateNumbers(numbers);

        // Mostrar el conjunto de números duplicados
        Console.WriteLine("Conjunto de números duplicados:");
        foreach (int number in duplicateNumbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }

    static HashSet<int> GetDuplicateNumbers(HashSet<int> numbers)
    {
        HashSet<int> duplicateNumbers = new HashSet<int>();
        HashSet<int> uniqueNumbers = new HashSet<int>();

        foreach (int number in numbers)
        {
            // Si el número ya está en uniqueNumbers, significa que es un duplicado
            if (!uniqueNumbers.Add(number))
            {
                duplicateNumbers.Add(number);
            }
        }

        return duplicateNumbers;
    }
}