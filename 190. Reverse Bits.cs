public class Solution {
    public uint reverseBits(uint n) {
         var array = Convert.ToString(n, 2).PadLeft(32, '0').ToArray();
                Array.Reverse(array);
                string binary = new string(array);
                UInt32 number = Convert.ToUInt32(binary, 2);
                return number;
                
        
    }
}