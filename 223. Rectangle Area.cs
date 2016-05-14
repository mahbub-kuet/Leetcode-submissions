public class Solution {
    public int ComputeArea(int A, int B, int C, int D, int E, int F, int G, int H) {
        //int a = -3, b = 0, c = 3, d = 4, e = 0, f = -1, g = 9, h = 2;
            int area1 = Math.Abs(A - C)*Math.Abs(B-D);
            int area2 = Math.Abs(E-G) * Math.Abs(F-H);
            int area3 = 0;
            int x1=Math.Max(A,E);
            int y1 = Math.Max(B,F);
            int x2=Math.Min(C,G);
            int y2 = Math.Min(D,H);
            if(x1<x2 && y1<y2)
            {
                area3 = (x2 - x1) * (y2 - y1);
            }
            int area = area1 + area2 - area3;
            return area;
        
    }
}