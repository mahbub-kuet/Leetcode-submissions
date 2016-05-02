public class Solution {
    public string IntToRoman(int num) {
        
        string[] thou={"","M","MM","MMM"};
        string[] hun={"","C","CC","CCC","CD","D","DC","DCC","DCCC","CM"};
        string[] ten={"","X","XX","XXX","XL","L","LX","LXX","LXXX","XC"};
        string[] first={"","I","II","III","IV","V","VI","VII","VIII","IX"};
        string roman="";
        
        roman += thou[(int)(num/1000)%10];
        roman += hun[(int)(num/100)%10];
        roman += ten[(int)(num/10)%10];
        roman += first[num%10];
        
        return roman;
    }
}