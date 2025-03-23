namespace FilterSDK;

public static class StringArrayFilterExtensions
{

    public static string[] FilterOutWordsWithLengthLessThan(this string[] words, int length)
    {
        return words.Where(w => w.Length >= length).ToArray();
    }

    public static string[] FilterOutWordsWithoutCharacter(this string[] words, char mustIncludeChar)
    {
        return words.Where(w => w.ToLower().Contains(char.ToLower(mustIncludeChar))).ToArray();
    }

    public static string[] FilterOutWordsWithMiddleVowl(this string[] words)
    {
        const string vowels = "aeiou";
        
        var result = new List<string>();

        foreach (var w in words)
        {
            if (w.Length % 2 == 1)
            {
                if (!vowels.Contains(w[int.Parse(((w.Length / 2) - 0.5).ToString())])) result.Add(w);
            }
            else
            {
                if (!vowels.Contains(w[int.Parse(((w.Length / 2)- 1).ToString())]) &&
                    !vowels.Contains(w[int.Parse((w.Length / 2).ToString())]))  result.Add(w);
            }
        }

        return result.ToArray();

    }

}
