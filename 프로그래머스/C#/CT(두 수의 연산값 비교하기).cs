using System;

public class Solution {
    public int solution(int a, int b) {
        int answer = 0;
        String i = a.ToString()+b.ToString();
        int j = 2 * a * b;
        int k = Int32.Parse(i);
        if(k < j){
            answer = j;
        }
        else{
            answer = k;
        }
        return answer;
    }
}