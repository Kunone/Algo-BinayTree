class Algo_BT_HasPathSum
{
    public static bool HasPathSum(Node root, int restValue)
    {
        if (root == null) return restValue == 0;

        restValue -= root.Data;

        //if (HasPathSum(root.Left, restValue)) return true;
        //if (HasPathSum(root.Right, restValue)) return true;
        //return false;
        return HasPathSum(root.Left, restValue) || HasPathSum(root.Right, restValue);
    }
}
