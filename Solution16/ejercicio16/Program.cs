class Program
{
    static void Main()
    {
        // Solicitar al usuario que ingrese un conjunto de palabras separadas por espacios
        Console.WriteLine("Ingrese un conjunto de palabras separadas por espacios:");
        string input = Console.ReadLine();
        HashSet<string> words = new HashSet<string>(input.Split(' '));

        // Obtener el conjunto de palabras palíndromas ordenadas de menor a mayor
        HashSet<string> palindromes = GetPalindromes(words);

        // Mostrar el conjunto de palabras palíndromas ordenadas de menor a mayor
        Console.WriteLine("Conjunto de palabras palíndromas ordenadas de menor a mayor:");
        foreach (string word in palindromes)
        {
            Console.Write(word + " ");
        }
        Console.WriteLine();
    }

    static bool IsPalindrome(string word)
    {
        int left = 0;
        int right = word.Length - 1;
        while (left < right)
        {
            if (word[left] != word[right])
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }

    static HashSet<string> GetPalindromes(HashSet<string> words)
    {
        HashSet<string> palindromes = new HashSet<string>();

        foreach (string word in words)
        {
            if (IsPalindrome(word))
            {
                palindromes.Add(word);
            }
        }

        // Ordenar los palíndromos de menor a mayor
        List<string> sortedPalindromes = palindromes.ToList();
        sortedPalindromes.Sort();
        palindromes = new HashSet<string>(sortedPalindromes);

        return palindromes;
    }
}