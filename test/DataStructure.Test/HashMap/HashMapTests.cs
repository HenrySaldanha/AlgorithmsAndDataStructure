using DataStructure.HashMap;

namespace DataStructure.Test.HashMap;

public class HashMapTests
{
    [Fact]
    public void Add_ValidKeyAndValue_MustAdd()
    {
        //Arrange
        var hashMap = new HashMap<int, string>();

        //Act
        hashMap
            .Add(new HashMapNode<int, string>(1, "A"))
            .Add(new HashMapNode<int, string>(3, "R"))
            .Add(new HashMapNode<int, string>(4, "B"))
            .Add(new HashMapNode<int, string>(15, "C"));

        //Assert
        Assert.Equal(4, hashMap.Size);
    }

    [Fact]
    public void Add_RepeatedKeyAndValue_DontAdd()
    {
        //Arrange
        var hashMap = new HashMap<int, string>();

        //Act
        hashMap
            .Add(new HashMapNode<int, string>(1, "A"))
            .Add(new HashMapNode<int, string>(1, "R"));

        //Assert
        Assert.Equal(1, hashMap.Size);
    }

    [Fact]
    public void Add_FifteenValidItems_MustAdd()
    {
        //Arrange
        var hashMap = new HashMap<int, string>();

        //Act
        hashMap
            .Add(new HashMapNode<int, string>(1, "A"))
            .Add(new HashMapNode<int, string>(3, "R"))
            .Add(new HashMapNode<int, string>(4, "B"))
            .Add(new HashMapNode<int, string>(15, "C"))
            .Add(new HashMapNode<int, string>(33, "N"))
            .Add(new HashMapNode<int, string>(66, "CA"))
            .Add(new HashMapNode<int, string>(123, "FG"))
            .Add(new HashMapNode<int, string>(3455, "TR"))
            .Add(new HashMapNode<int, string>(-5, "NN"))
            .Add(new HashMapNode<int, string>(2, "KK"))
            .Add(new HashMapNode<int, string>(-7123, "TT"))
            .Add(new HashMapNode<int, string>(-4, "UT"))
            .Add(new HashMapNode<int, string>(123411, "EW"))
            .Add(new HashMapNode<int, string>(4234, "XP"))
            .Add(new HashMapNode<int, string>(-986, "QQ"));

        //Assert
        Assert.Equal(15, hashMap.Size);
    }

    [Fact]
    public void Add_NullKey_DontAdd()
    {
        //Arrange
        var hashMap = new HashMap<int?, string?>();

        //Act
        hashMap
            .Add(new HashMapNode<int?, string?>(1, "A"))
            .Add(null)
            .Add(new HashMapNode<int?, string?>(null, "B"))
            .Add(new HashMapNode<int?, string?>(15, null));

        //Assert
        Assert.Equal(1, hashMap.Size);
    }

    [Fact]
    public void Get_NullKey_ReturnNull()
    {
        //Arrange
        var hashMap = new HashMap<int?, string>();
        var node = new HashMapNode<int?, string>(1, "A");
        hashMap.Add(node);

        //Act
        var result = hashMap.Get(null);

        //Assert
        Assert.Null(result);
    }

    [Fact]
    public void Get_NullHashMap_ReturnNull()
    {
        //Arrange
        var hashMap = new HashMap<int, string>();

        //Act
        var result = hashMap.Get(1);

        //Assert
        Assert.Null(result);
    }

    [Fact]
    public void Get_NodeExists_ReturnNode()
    {
        //Arrange
        var hashMap = new HashMap<int, string>();
        var nodeA = new HashMapNode<int, string>(1, "A");
        var nodeB = new HashMapNode<int, string>(2, "B");
        var nodeC = new HashMapNode<int, string>(3, "C");
        hashMap.Add(nodeA).Add(nodeB).Add(nodeC);

        //Act
        var result = hashMap.Get(1);

        //Assert
        Assert.Equal(nodeA, result);
    }

    [Fact]
    public void Get_NodeDontExists_ReturnNull()
    {
        //Arrange
        var hashMap = new HashMap<int, string>();
        var nodeA = new HashMapNode<int, string>(1, "A");
        var nodeB = new HashMapNode<int, string>(2, "B");
        var nodeC = new HashMapNode<int, string>(3, "C");
        hashMap.Add(nodeA).Add(nodeB).Add(nodeC);

        //Act
        var result = hashMap.Get(10);

        //Assert
        Assert.Null(result);
    }

    [Fact]
    public void Remove_KeyDontExists_DontRemove()
    {
        //Arrange
        var hashMap = new HashMap<int, string>();
        var nodeA = new HashMapNode<int, string>(1, "A");
        var nodeB = new HashMapNode<int, string>(2, "B");
        var nodeC = new HashMapNode<int, string>(3, "C");
        hashMap.Add(nodeA).Add(nodeB).Add(nodeC);

        //Act
        hashMap.Remove(10);

        //Assert
        Assert.Equal(3, hashMap.Size);
    }

    [Fact]
    public void Remove_KeyExists_Remove()
    {
        //Arrange
        var hashMap = new HashMap<int, string>();
        var nodeA = new HashMapNode<int, string>(1, "A");
        var nodeB = new HashMapNode<int, string>(2, "B");
        var nodeC = new HashMapNode<int, string>(3, "C");
        hashMap.Add(nodeA).Add(nodeB).Add(nodeC);

        //Act
        hashMap.Remove(2);

        //Assert
        Assert.Equal(2, hashMap.Size);
    }
}
