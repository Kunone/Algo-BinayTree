/// <summary>
/// To count how manu possible tree structures based on data 1...N
/// </summary>
class Algo_BT_CountTrees
{
    static Dictionary<int, int> cachedCount = new Dictionary<int, int>();

    public static int CountTrees(int numKeys)
    {
        if (numKeys <= 1) return 1;
        if (cachedCount.ContainsKey(numKeys))
            return cachedCount[numKeys];

        int sum = 0;
        for(var i=1; i<=numKeys;i++)
        {
            var left = CountTrees(i - 1);
            var right = CountTrees(numKeys - i);
            sum += left * right;
        }
        cachedCount.Add(numKeys, sum);
        return sum;
    }
}
