class Program
{
    static void Main()
    {
        // Solicitar al usuario que ingrese un conjunto de números separados por espacios
        Console.WriteLine("Ingrese un conjunto de números separados por espacios:");
        string input = Console.ReadLine();
        HashSet<int> numbers = new HashSet<int>(input.Split(' ').Select(int.Parse));

        // Obtener el conjunto de números que no están duplicados
        HashSet<int> uniqueNumbers = GetUniqueNumbers(numbers);

        // Mostrar el conjunto de números que no están duplicados
        Console.WriteLine("Conjunto de números que no están duplicados:");
        foreach (int number in uniqueNumbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }

    static HashSet<int> GetUniqueNumbers(HashSet<int> numbers)
    {
        Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

        // Contar la frecuencia de cada número
        foreach (int number in numbers)
        {
            if (!frequencyMap.ContainsKey(number))
            {
                frequencyMap[number] = 0;
            }
            frequencyMap[number]++;
        }

        // Crear un conjunto para almacenar los números que no están duplicados
        HashSet<int> uniqueNumbers = new HashSet<int>();

        // Agregar los números con una frecuencia de 1 al conjunto de salida
        foreach (var pair in frequencyMap)
        {
            if (pair.Value == 1)
            {
                uniqueNumbers.Add(pair.Key);
            }
        }

        return uniqueNumbers;
    }
}