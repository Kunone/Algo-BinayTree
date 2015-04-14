/// <summary>
/// tried 2 methods:
/// 1: use int[] to store each node data, print all once it got to leaf
/// 2: use stack to store routered data, but need to pop the last inputted data when roll back. (it is reference type so can remember)
/// </summary>
/// <param name="root"></param>
class Algo_BT_PrintPaths
{
    public static void PrintPaths(Node root)
    {
        PrintPaths(root, new int[10], 0);
        //PrintPaths(root, new Stack<int>());
    }

    static void PrintPaths(Node root, int[] paths, int pathLen)
    {
        if (root == null) return;
        paths[pathLen++] = root.Data;

        if (root.Left == null && root.Right == null)
        {
            for (var i = 0; i < pathLen; i++)
                Console.Write(paths[i] + " ");

            Console.WriteLine();
            return;
        }

        PrintPaths(root.Left, paths, pathLen);
        PrintPaths(root.Right, paths, pathLen);
    }

    static void PrintPaths(Node root, Stack<int> paths)
    {
        if (root == null) return;
        paths.Push(root.Data);

        if (root.Left == null && root.Right == null)
        {
            foreach (var i in paths.Reverse())
                Console.Write(i + " ");
            Console.WriteLine();
            paths.Pop();
            return;
        }

        PrintPaths(root.Left, paths);
        PrintPaths(root.Right, paths);
        paths.Pop();
    }

}
