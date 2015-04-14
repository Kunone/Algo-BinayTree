/// <summary>
/// tried 3 methods:
/// 1: bottom up +1
/// 2: top down by ref
/// 3: top down by class
/// </summary>
class Algo_BT_Size
{
    // Method 1
    public static int Size(Node root)
    {
        if (root == null) return 0;
        return (Size(root.Left) + Size(root.Right) + 1);
    }

    // Method 2
    public static int SizeByRef(Node root)
    {
        var size = 0;
        Size(root, ref size);
        return size;
    }
    static void Size(Node root, ref int s)
    {
        if (root == null) return;
        s++;
        Size(root.Left, ref s);
        Size(root.Right, ref s);
    }

    // Method 3
    public static int SizeByClass(Node root)
    {
        var t = new Test();
        Size(root, t);

        return t.size;
    }
    static void Size(Node root, Test t)
    {
        if (root == null) return;
        t.size++;
        Size(root.Left, t);
        Size(root.Right, t);
    }
    class Test
    {
        public int size = 0;
    }
}
