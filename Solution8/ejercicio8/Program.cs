class Program
{
    static void Main()
    {
        // Solicitar al usuario que ingrese un conjunto de palabras
        Console.WriteLine("Ingrese un conjunto de palabras separadas por espacios:");
        string input = Console.ReadLine();
        HashSet<string> words = new HashSet<string>(input.Split(' '));

        // Obtener las palabras que son palíndromos
        HashSet<string> palindromes = GetPalindromes(words);

        // Mostrar las palabras que son palíndromos
        Console.WriteLine("Palabras que son palíndromos:");
        foreach (string word in palindromes)
        {
            Console.WriteLine(word);
        }
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

        return palindromes;
    }

    static bool IsPalindrome(string word)
    {
        int length = word.Length;
        for (int i = 0; i < length / 2; i++)
        {
            if (word[i] != word[length - i - 1])
            {
                return false;
            }
        }
        return true;
    }
}