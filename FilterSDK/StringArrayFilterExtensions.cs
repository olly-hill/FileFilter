namespace FilterSDK;

public static class StringArrayFilterExtensions
{

    public static string[] FilterOutWordsWithLengthLessThan(this string[] words, int length)
    {
        return words.Where(w => w.Length >= length).ToArray();
    }

    public static string[] FilterOutWordsWithCharacter(this string[] words, char mustIncludeChar)
    {
        return words.Where(w => !w.ToLower().Contains(char.ToLower(mustIncludeChar))).ToArray();
    }

    public static string[] FilterOutWordsWithMiddleVowel(this string[] words)
    {
        HashSet<char> vowels = new() { 'a', 'e', 'i', 'o', 'u' };
        var result = new List<string>();

        foreach (var word in words)
        {
            int len = word.Length;
            if (len > 0)
            {
                if (len % 2 == 1)  // Odd length
                {
                    int mid = len / 2;
                    if (!vowels.Contains(word[mid]))
                        result.Add(word);
                }
                else  // Even length
                {
                    int mid1 = (len / 2) - 1, mid2 = len / 2;
                    if (!vowels.Contains(word[mid1]) && !vowels.Contains(word[mid2]))
                        result.Add(word);
                }
            }
        }

        return result.ToArray();
    }

}
