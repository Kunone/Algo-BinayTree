/// <summary>
/// tried two methods:
/// 1. top down to create nodes. Have to use ref keyword so to remember root.
/// 2. bottom up to create a node and attach to parent.
/// </summary>
class Algo_BT_GenerateBST
{
    public static Node GenerateBST(int[] items)
    {
        Node root = null;
        foreach (var i in items)
        {
            //Insert(ref root, i);
            root = Insert(root, i);
        }
        return root;
    }

    static void Insert(ref Node root, int i)
    {
        if (root == null)
        {
            root = new Node(i);
            return;
        }
        if (i <= root.Data) Insert(ref root.Left, i);
        if (i > root.Data) Insert(ref root.Right, i);
    }

    static Node Insert(Node n, int i)
    {
        if (n == null) return new Node(i);
        else
        {
            if (i <= n.Data) n.Left = Insert(n.Left, i);
            else n.Right = Insert(n.Right, i);
        }
        return n;
    }
}
