public class Solution {
    public int[] PlusOne(int[] digits) {
        int carry=1;
        List<int> result= new List<int>();
        int temp=0;
        int i;
        for(i=digits.Length-1;i>=0;i--)
        {
            temp=(digits[i]+carry)%10;
            carry= (digits[i]+carry)/10;
            result.Insert(0,temp); 
        }
        if(carry==1)
        {
            result.Insert(0,carry); 
        }
        
        return result.ToArray();
    }
}