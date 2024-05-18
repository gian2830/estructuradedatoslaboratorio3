class Program
{
    static void Main()
    {
        // Solicitar al usuario que ingrese un conjunto de palabras
        Console.WriteLine("Ingrese un conjunto de palabras separadas por espacios:");
        string input = Console.ReadLine();
        HashSet<string> words = new HashSet<string>(input.Split(' '));

        // Solicitar al usuario que ingrese la longitud deseada
        Console.WriteLine("Ingrese la longitud de las palabras que desea filtrar:");
        if (int.TryParse(Console.ReadLine(), out int length))
        {
            // Obtener las palabras que tienen la longitud especificada
            HashSet<string> filteredWords = GetWordsOfLength(words, length);

            // Mostrar las palabras que tienen la longitud especificada
            Console.WriteLine($"Palabras que tienen una longitud de {length}:");
            foreach (string word in filteredWords)
            {
                Console.WriteLine(word);
            }
        }
        else
        {
            Console.WriteLine("La longitud ingresada no es válida.");
        }
    }

    static HashSet<string> GetWordsOfLength(HashSet<string> words, int length)
    {
        HashSet<string> filteredWords = new HashSet<string>();

        foreach (string word in words)
        {
            if (word.Length == length)
            {
                filteredWords.Add(word);
            }
        }

        return filteredWords;
    }
}