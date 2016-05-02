public class Solution {
    public int SearchInsert(int[] A, int target) {
        int index = Array.BinarySearch(A, target);           
            if (index>=0)
            {
                return index;
            }
            else
            {
                index = Math.Abs(index)-1;
                return index;
            }
        
    }
}