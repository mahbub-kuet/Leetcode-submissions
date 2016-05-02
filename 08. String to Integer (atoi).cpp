class Solution {
public:
    int myAtoi(string str) {
        string t; 
        t=str;
        if(t=="") 
        t="0"; 
        stringstream s; 
        int i;
        s<<t; s>>i; 
        return i;
    }
};