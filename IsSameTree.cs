class Algo_BT_SameTree
{
    public static bool IsSameTree(Node tree1, Node tree2)
    {
        if (tree1 == null) return true;
        if (tree2 == null) return false;

        return IsSameTree(tree1.Left, tree2.Left) && IsSameTree(tree1.Right, tree2.Right) && tree1.Data == tree2.Data;
    }
}
