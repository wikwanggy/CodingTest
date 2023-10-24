class Solution {
    public int solution(String ineq, String eq, int n, int m) {
        int answer = 0;
        if(ineq.equals(">")){ // ineq가 >면
            if(eq.equals("=")){ // eq가 = 면
                return n >=m ? 1 : 0; // 만약 n이 m보다 크거나 같으면 1 아니면 0을 반환
            }
            else if(eq.equals("!")){ // eq가 ! 면
                return n > m ? 1 : 0; // 만약 n이 m보다 크면 1 아니면 0 반환
            }
        }
        else if(ineq.equals("<")){ // ineq가 < 면
            if (eq.equals("=")) { // eq가 = 면
                return n <= m ? 1 : 0; // 만약 m이 n보다 크거나 같으면 1 아니면 0을 반환
            }
            else if(eq.equals("!")){
              return n < m ? 1 : 0;  //만약 m이 n보다 크면 1 아니면 0을 반환
            }
        }
        return answer;
    }
}