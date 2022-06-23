using DataStructure.Graph;

namespace Search.Test.DepthFirstSearch;

public class DepthFirstSearchTests
{
    [Fact]
    public void DepthFirstSearch_ValidEdge_MustReturnSuccess()
    {
        //Arrange
        var graph = new AdjacencyListWeightless(8);
        graph.AddEdge(1, 2).AddEdge(1, 3).AddEdge(2, 3).AddEdge(2, 4).AddEdge(4, 5).AddEdge(5, 7);
        var search = new Search.DepthFirstSearch.DepthFirstSearch(graph);

        //Act
        var result = search.Dfs(1);

        //Assert
        Assert.Equal("123457", result);
    }
}