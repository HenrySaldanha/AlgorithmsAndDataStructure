namespace Problems.Test.HashTable;

public class GroupAnagramsTests
{
    [Fact]
    public void Solution_ValidInput_MustReturnCorrectAnswer()
    {
        //Arrange
        var solution = new GroupAnagrams();

        //Act
        var response = solution.Solution(new string[] { "eat", "tea", "tan", "ate", "nat", "bat" });

        //Assert
        Assert.Contains(response[0], c => c == "eat");
        Assert.Contains(response[0], c => c == "tea");
        Assert.Contains(response[0], c => c == "ate");
        Assert.Contains(response[1], c => c == "tan");
        Assert.Contains(response[1], c => c == "nat");
        Assert.Contains(response[2], c => c == "bat");
    }
}