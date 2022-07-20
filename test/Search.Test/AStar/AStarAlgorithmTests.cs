using Search.AStar;

namespace Search.Test.AStar;
public class AStarAlgorithmTests
{
    [Fact]
    public void AStar_MustBeFindTheShortPath()
    {
        //Arrange
        var a = new Vertex(366);
        var b = new Vertex(0);
        var c = new Vertex(160);
        var d = new Vertex(242);
        var e = new Vertex(161);
        var f = new Vertex(218);
        var g = new Vertex(77);
        var h = new Vertex(151);
        var i = new Vertex(226);
        var j = new Vertex(244);
        var k = new Vertex(241);
        var l = new Vertex(234);
        var m = new Vertex(380);
        var n = new Vertex(98);
        var o = new Vertex(193);
        var p = new Vertex(253);
        var q = new Vertex(329);
        var r = new Vertex(80);
        var s = new Vertex(199);
        var t = new Vertex(374);

        a.AddEdge(t, 75, false, "a <-> t");
        a.AddEdge(p, 140, false, "a <-> p");
        a.AddEdge(q, 118, false, "a <-> q");
        t.AddEdge(m, 71, false, "t <-> m");
        m.AddEdge(p, 151, false, "m <-> p");
        q.AddEdge(j, 111, false, "q <-> j");
        j.AddEdge(k, 70, false, "j <-> k");
        k.AddEdge(d, 75, false, "k <-> d");
        d.AddEdge(c, 120, false, "d <-> c");
        p.AddEdge(f, 99, false, "p <-> f");
        p.AddEdge(o, 80, false, "p <-> o");
        f.AddEdge(b, 211, false, "f <-> b");
        o.AddEdge(c, 146, false, "o <-> c");
        o.AddEdge(n, 97, false, "o <-> n");
        c.AddEdge(n, 138, false, "c <-> n");
        n.AddEdge(b, 101, false, "n <-> b");
        b.AddEdge(r, 85, false, "b <-> r");
        b.AddEdge(g, 90, false, "b <-> g");
        r.AddEdge(h, 98, false, "r <-> h");
        r.AddEdge(s, 142, false, "r <-> s");
        h.AddEdge(e, 86, false, "h <-> e");
        s.AddEdge(i, 92, false, "s <-> i");
        i.AddEdge(l, 87, false, "i <-> l");

        //Act
        var result = a.FindPath(b).ToList();

        //Assert
        Assert.Equal(418, result.Last().Key);
        Assert.Equal("a <-> p", result[1].Name);
        Assert.Equal("p <-> o", result[2].Name);
        Assert.Equal("o <-> n", result[3].Name);
        Assert.Equal("n <-> b", result[4].Name);
    }
}