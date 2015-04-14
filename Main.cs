class Algo_BT_Main
{
    static void Main(string[] args)
    {
        var root = Algo_BT_GenerateBST.GenerateBST(new int[] { 12, 5, 3, 9, 10, 33, 20, 13, 28 });
        var root2 = Algo_BT_GenerateBST.GenerateBST(new int[] { 12, 5, 3, 9, 10, 33, 20, 13, 19 });
        var root3 = GenerateBT();

        Console.WriteLine(string.Format("max depth: {0}", Algo_BT_MaxDepth.GetMaxDepth(root)));
        //Console.WriteLine(string.Format("min value: {0}", Algo_BT_MinValue.GetMinValue(root)));
        //Algo_BT_PrintPaths.PrintPaths(root);
        //Algo_BT_Mirror.Mirror(root);
        //Algo_BT_DoubleTree.DoubleTree(root);
        //Console.WriteLine(string.Format("is same: {0}", Algo_BT_SameTree.IsSameTree(root, root2)));
        //Console.WriteLine(string.Format("Number of possible trees: {0}", Algo_BT_CountTrees.CountTrees(15)));
        //Console.WriteLine(string.Format("is BST: {0}", Algo_BT_IsBST.IsBST(root3)));

         Console.ReadKey();
    }       

    static Node GenerateBT()
    {
        Node root = new Node(5);
        root.Left = new Node(3);
        root.Right = new Node(8);

        root.Left.Left = new Node(2);
        root.Left.Right = new Node(6);

        return root;
    }
}

class Node
{
    public int Data;
    public Node Left;
    public Node Right;

    public Node(int i)
    {
        Data = i;
        Left = null;
        Right = null;
    }
}
