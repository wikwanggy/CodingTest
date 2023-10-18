using System;

public class Solution {
    public int solution(int a, int b) {
        int answer = 0;
        String i = a.ToString()+b.ToString();
        String j = b.ToString()+a.ToString();
        int ab = Int32.Parse(i);
        int ba = Int32.Parse(j);
        
        if(ab < ba){
            answer = ba;
        }else{
            answer = ab;
        }
        return answer;
    }
}