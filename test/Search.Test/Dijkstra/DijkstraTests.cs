using System.Linq;
using Search.Dijkstra;
using Xunit;

namespace Search.Test.Dijkstra
{
    public class DijkstraTests
    {
        [Fact]
        public void SearchShortestPathFromSource_MustReturnSuccess()
        {
            //Arrange
            var nodeA = new GraphNode("A");
            var nodeB = new GraphNode("B");
            var nodeC = new GraphNode("C");
            var nodeD = new GraphNode("D");
            var nodeE = new GraphNode("E");
            var nodeF = new GraphNode("F");

            nodeA.AddDestination(nodeB, 10).AddDestination(nodeC, 15);
            nodeB.AddDestination(nodeD, 12).AddDestination(nodeF, 15);
            nodeC.AddDestination(nodeE, 10);
            nodeD.AddDestination(nodeE, 2).AddDestination(nodeF, 1);
            nodeF.AddDestination(nodeE, 5);

            var graph = new Graph();
            graph.AddNode(nodeA).AddNode(nodeB).AddNode(nodeC).AddNode(nodeD).AddNode(nodeE).AddNode(nodeF);

            //Act
            var response = graph.SearchShortestPathFromSource(nodeA);

            //Assert
            Assert.NotNull(response);
            Assert.Equal(0, response.Nodes.First(c => c.Name == "A").Distance);
            Assert.Equal(10, response.Nodes.First(c => c.Name == "B").Distance);
            Assert.Equal(15, response.Nodes.First(c => c.Name == "C").Distance);
            Assert.Equal(22, response.Nodes.First(c => c.Name == "D").Distance);
            Assert.Equal(24, response.Nodes.First(c => c.Name == "E").Distance);
            Assert.Equal(23, response.Nodes.First(c => c.Name == "F").Distance);
        }
    }
}