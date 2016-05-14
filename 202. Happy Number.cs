public class Solution {
    public bool IsHappy(int n) {
        bool[] b= new bool[10];
        b[1]=b[7]=true;
        int temp1,temp2;
        while(true){
            if(n<10)
            return b[n];
            temp1=n;
            temp2=0;
            while(temp1!=0){
                temp2=temp2+(temp1%10)*(temp1%10);
                temp1=temp1/10;
            }
            n=temp2;
            
            
        }
        
    }
}