public class Solution 
{
    // https://leetcode.com/problems/two-sum/
    public Tuple<int, int> TwoSum(int[] numbers, int target)
    {
        var dic = new Dictionary<int, int>();
        for (var i = 0; i < numbers.Length; i++)
        {
            if (dic.ContainsKey(target - numbers[i]))
            {
                var v1 = dic[target - numbers[i]];;
                return Tuple.Create(v1 + 1, i + 1);
            }
            if (!dic.ContainsKey(numbers[i]))
                dic.Add(numbers[i], i);
        }
        return null;
    }
}
