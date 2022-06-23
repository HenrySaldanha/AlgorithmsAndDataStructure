using DataStructure.Graph;

namespace Search.Test.BreadthFirstSearch
{
    public class BreadthFirstSearchTests
    {
        [Fact]
        public void BreadthFirstSearch_ValidEdge_MustReturnSuccess()
        {
            //Arrange
            var graph = new AdjacencyListWeightless(7);
            graph.AddEdge(6, 4).AddEdge(4, 5).AddEdge(4, 3).AddEdge(5, 2).AddEdge(4, 5).AddEdge(3, 2).AddEdge(5, 1).AddEdge(2, 1);
            var search = new Search.BreadthFirstSearch.BreadthFirstSearch(graph);
            
            //Act
            search.Bfs(6);

            //Assert
            Assert.Equal(3, search.Level[1]);
            Assert.Equal(0, search.Level[6]);
            Assert.Equal(2, search.Level[5]);
            Assert.Equal(1, search.Level[4]);
        }
    }
}
