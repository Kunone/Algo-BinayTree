/// <summary>
///      2 
///     / \ 
///    1   3
/// is changed to... 
///                2 
///               / \ 
///              2   3 
///            /    / 
///           1   3 
///          / 
///        1
/// </summary>
class Algo_BT_DoubleTree
{
    public static void DoubleTree(Node root)
    {
        if (root == null) return;

        DoubleTree(root.Left);
        DoubleTree(root.Right);

        var doubleNode = new Node(root.Data);
        doubleNode.Left = root.Left;
        root.Left = doubleNode;
    }
}
