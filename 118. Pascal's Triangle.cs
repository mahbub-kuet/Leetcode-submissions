public class Solution {
   public IList<IList<int>> Generate(int numRows) {
    IList<IList<int>> result = new List<IList<int>>();
    for(int i = 1; i <= numRows; i++){
        IList<int> singleLine = new List<int>();
        for(int j = 1; j <= i; j++)
            singleLine.Add(j == 1 || j == i ? 1 : result[i - 2][j - 2] + result[i - 2][j - 1]);
        result.Add(singleLine);
    }
    return result;
   }
}