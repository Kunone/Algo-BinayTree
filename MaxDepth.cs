
/// <summary>
/// tried 3 methods:
/// method 1: i to count current depth, remeber the max one in currentMax (used ref so to remember during the recursion).
/// method 2: i to count current depth, so return the value when it reachs null, then compare left and right sub tree to pick a greater one.
/// method 3: bottom up +1 for each layer, then compare left and right.
/// </summary>  
class Algo_BT_MaxDepth
{
    public static int GetMaxDepth(Node root)
    {
        var maxDepth = 0;
        CountMaxDepth(root,  0, ref maxDepth);
        //maxDepth = CountMaxDepth(root, 0);
        //maxDepth = CountMaxDepth(root);
        return maxDepth;
    }

    static void CountMaxDepth(Node root,  int i, ref int currentMax)
    {
        if (root == null)
        {
            if (i > currentMax)
                currentMax = i;
            return;
        }
        i++;
        CountMaxDepth(root.Left,  i, ref currentMax);
        CountMaxDepth(root.Right,  i, ref currentMax);
    }

    static int CountMaxDepth(Node root, int currentDepth)
    {
        if (root == null)
            return currentDepth;

        currentDepth++;
        var leftDepth = CountMaxDepth(root.Left, currentDepth);
        var rightDepth = CountMaxDepth(root.Right, currentDepth);

        return Math.Max(leftDepth, rightDepth);
    }

    static int CountMaxDepth(Node root)
    {
        if (root == null) return 0;
        var leftDepth = CountMaxDepth(root.Left);
        var rightDepth = CountMaxDepth(root.Right);
        return Math.Max(leftDepth, rightDepth) + 1;
    }

}
