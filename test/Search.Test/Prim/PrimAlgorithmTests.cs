using Search.Prim;

namespace Search.Test.Prim;

public class PrimAlgorithmTests
{
    [Fact]
    public void GetMinimalSpanningTree_ValidGraph_MustReturnSuccess()
    {
        //Arrange
        var prim = new PrimAlgorithm();
        var graph = new int[,] {{ 0, 2, 0, 6, 0 },
                                    { 2, 0, 3, 8, 5 },
                                    { 0, 3, 0, 0, 7 },
                                    { 6, 8, 0, 0, 9 },
                                    { 0, 5, 7, 9, 0 }};

        //Act
        var result = prim.GetMinimalSpanningTree(graph);

        //Assert
        Assert.Equal(2, result[0, 1]);
        Assert.Equal(2, result[1, 0]);
        Assert.Equal(3, result[1, 2]);
        Assert.Equal(3, result[2, 1]);
        Assert.Equal(5, result[1, 4]);
        Assert.Equal(5, result[4, 1]);
        Assert.Equal(6, result[0, 3]);
        Assert.Equal(6, result[3, 0]);
    }
}