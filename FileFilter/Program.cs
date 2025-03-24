using FilterSDK;

var result = new List<string>();

using (var fStream = new FileStream(".\\Resources\\new 24.txt", FileMode.Open, FileAccess.Read))
{
    using (var file = new StreamReader(fStream, System.Text.Encoding.UTF8))
    {
        string lineOfText = string.Empty;
        while ((lineOfText = file.ReadLine()) != null)
        {
            var lineResult = lineOfText.Split(" ");

            lineResult = lineResult.FilterOutWordsWithLengthLessThan(3)
                           .FilterOutWordsWithCharacter('t')
                           .FilterOutWordsWithMiddleVowel();

            result.AddRange(lineResult);

        }
    }
}



//var input ="an elephant is an animal but a tree isn't, neither is a washingmachine";

//var result = input.Split(" ");

//result = result.FilterOutWordsWithLengthLessThan(3)
//               .FilterOutWordsWithCharacter('t')
//               .FilterOutWordsWithMiddleVowel();

Console.WriteLine(string.Join(", ", result));
Console.ReadLine();

