class Algo_BT_Mirror
{
    public static void Mirror(Node root)
    {
        if (root == null) return;
        if(root.Left!=null || root.Right!=null)
            ExchangeLeftRight(root);

        Mirror(root.Left);
        Mirror(root.Right);
    }
    static void ExchangeLeftRight(Node root)
    {
        var temp = root.Right;
        root.Right =root.Left;
        root.Left = temp;
    }

    public static void Mirror2(Node root)
    {
        if(root!=null)
        {
            Mirror2(root.Left);
            Mirror2(root.Right);
            ExchangeLeftRight(root);
        }
    }
}
