public class Solution {
    public string LongestCommonPrefix(string[] strs) {
         if (strs.Length == 0) {
        return "";   // Or maybe return null?
    }

    for (int prefixLen = 0; prefixLen < strs[0].Length; prefixLen++) {
        char c = strs[0][prefixLen];
        for (int i = 1; i < strs.Length; i++) {
            if ( prefixLen >= strs[i].Length ||
                 strs[i][prefixLen] != c ) {
                // Mismatch found
                return strs[i].Substring(0, prefixLen);
            }
        }
    }
    return strs[0];
    }
}