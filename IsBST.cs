class Algo_BT_IsBST
{
    public static bool IsBST(Node root)
    {
        return IsBST(root, Int32.MinValue, Int32.MaxValue);
    }

    static bool IsBST(Node root, int min, int max)
    {
        if (root == null) return true;
        if (root.Data <= min || root.Data > max) return false;

        return IsBST(root.Left, min, root.Data) && IsBST(root.Right, root.Data, max);
    }
}
