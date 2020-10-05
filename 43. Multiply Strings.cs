// https://leetcode.com/problems/multiply-strings/submissions/

public class Solution {
    public string Multiply(string num1, string num2) {
        if (num1 == "0" || num2 == "0")
                return "0";
        
        var result = string.Empty;
            var trailingZeros = string.Empty;
            for (int i = num1.Length -1; i >= 0; i--)
            {
                int a = num1[i] - '0';
                int carry = 0;
                var temp = new StringBuilder();

                for (int j = num2.Length - 1; j >= 0; j--)
                {
                    int m = (num2[j] - '0') * a + carry;

                    if (j == 0)
                    {
                        temp.Insert(0, Convert.ToString(m));
                    }
                    else
                    {
                        carry = m / 10;
                        temp.Insert(0, Convert.ToString(m % 10));
                    }
                }

                temp.Append(trailingZeros);
                result = Concat(result, temp.ToString());
                trailingZeros += '0';
            }
            return result;
    }
    
    private string Concat(string s1, string s2)
        {
            var result = new StringBuilder();
            int carry = 0;

            while (s1.Length < s2.Length)
            {
                s1 = '0' + s1;
            }

            for (int i = s2.Length - 1; i >= 0; i--)
            {
                int sum = (s2[i] - '0') + (s1[i] - '0') + carry;

                if (i == 0)
                {
                    result.Insert(0, Convert.ToString(sum));
                }
                else
                {
                    carry = sum / 10;
                    result.Insert(0, Convert.ToString(sum % 10));
                }
                
            }

            return result.ToString();
        }
}