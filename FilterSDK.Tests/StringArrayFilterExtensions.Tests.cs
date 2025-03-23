namespace FilterSDK.Tests;

public class StringArrayFilterExtensionsTests
{
    [Theory]
    [InlineData(3, new string[] { "elephant", "animal", "but", "tree", "isn't" } )]
    [InlineData(4, new string[] { "elephant", "animal", "tree", "isn't" })]
    [InlineData(5, new string[] { "elephant", "animal", "isn't" })]
    public void lengthTest(int minLength, string[] expectedoutput)
    {
        //arrange
        var input = new string[] { "an", "elephant", "is", "an", "animal", "but", "a", "tree", "isn't" };

        //execute???
        var result = input.FilterOutWordsWithLengthLessThan(minLength);

        //assert
        Assert.Equal(expectedoutput.Length, result.Length);
        for (int i = 0; i < expectedoutput.Length; i++) 
            Assert.Equal(expectedoutput[i], result[i]);

    }

    [Theory]
    [InlineData('p', new string[] { "an", "is", "an", "animal", "but", "a", "tree", "isn't" })]
    [InlineData('a', new string[] { "is", "but", "tree", "isn't" })]
    [InlineData('\'', new string[] { "an", "elephant", "is", "an", "animal", "but", "a", "tree" })]
    public void excludedCharacterTest(char excludeWordsWithCharacter, string[] expectedoutput)
    {
        //arrange
        var input = new string[] { "an", "elephant", "is", "an", "animal", "but", "a", "tree", "isn't" };

        //execute???
        var result = input.FilterOutWordsWithCharacter(excludeWordsWithCharacter);

        //assert
        Assert.Equal(expectedoutput.Length, result.Length);
        for (int i = 0; i < expectedoutput.Length; i++)
            Assert.Equal(expectedoutput[i], result[i]);

    }

    [Fact]
    public void excludeMiddleVowlTest()
    {
        //arrange
        var input = new string[] { "an", "elephant", "is", "an", "animal", "but", "a", "tree", "isn't" };
        var expectedoutput = new string[] { "elephant", "isn't" };

        //execute???
        var result = input.FilterOutWordsWithMiddleVowel();

        //assert
        Assert.Equal(expectedoutput.Length, result.Length);
        for (int i = 0; i < expectedoutput.Length; i++)
            Assert.Equal(expectedoutput[i], result[i]);

    }


}