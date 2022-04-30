using DataStructure.Graph;
using Xunit;

namespace DataStructure.Test.Graph
{
    public class AdjacencyListWeightlessTests
    {
        [Fact]
        public void AddEdge_ValidEdge_MustAdd()
        {
            //Arrange
            var graph = new AdjacencyListWeightless(8);

            //Act
            graph
                .AddEdge(1, 2)
                .AddEdge(1, 3)
                .AddEdge(2, 3)
                .AddEdge(2, 4)
                .AddEdge(4, 5);

            //Assert
            Assert.Contains(graph.Graph[1], c => c == 2);
            Assert.Contains(graph.Graph[1], c => c == 3);
            Assert.Contains(graph.Graph[2], c => c == 3);
            Assert.Contains(graph.Graph[2], c => c == 4);
            Assert.Contains(graph.Graph[4], c => c == 5);
        }

        [Fact]
        public void DepthFirstSearch_ValidEdge_MustReturnSuccess()
        {
            //Arrange
            var graph = new AdjacencyListWeightless(8);
            graph.AddEdge(1, 2).AddEdge(1, 3).AddEdge(2, 3).AddEdge(2, 4).AddEdge(4, 5).AddEdge(5, 7);

            //Act
            var result = graph.DepthFirstSearch(1);

            //Assert
            Assert.Equal("123457", result);
        }

        [Fact]
        public void BreadthFirstSearch_ValidEdge_MustReturnSuccess()
        {
            //Arrange
            var graph = new AdjacencyListWeightless(7);
            graph.AddEdge(6, 4).AddEdge(4, 5).AddEdge(4, 3).AddEdge(5, 2).AddEdge(4, 5).AddEdge(3, 2).AddEdge(5, 1).AddEdge(2, 1);

            //Act
            graph.BreadthFirstSearch(6);

            //Assert
            Assert.Equal(3, graph.Level[1]);
            Assert.Equal(0, graph.Level[6]);
            Assert.Equal(2, graph.Level[5]);
            Assert.Equal(1, graph.Level[4]);
        }
    }
}
