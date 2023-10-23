#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

int solution(int a, int b, int c) {
      int answer = 0;
        // a, b, c가 다 똑같을 경우
       if(a==b&&b==c){
            answer = (a+b+c)*(a*a+b*b+c*c)*(a*a*a+b*b*b+c*c*c);
        }
        // a=b b=c a=c 중 한개만 똑같을 경우
        else if(a==b&&b!=c||a==c&&c!=b||a!=b&&b==c){
            answer = (a+b+c)*(a*a+b*b+c*c);
        }
        // 아닐경우
        else{
            answer = a+b+c;
        }
        return answer;
}