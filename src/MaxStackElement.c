#include <stdio.h>


int main() {
    /* Enter your code here. Read input from STDIN. Print output to STDOUT */
    int N, val, pointer = 0;
    char type;
    scanf("%d", &N);
    int stack[N];
    
    for (int i = 0; i < N; ++i) {
        scanf(" %c", &type);
        if (type == '1') {
            scanf("%d", &val);
            if (pointer == 0) {
                stack[pointer++] = val;
            }
            else {
                int currMax = stack[pointer - 1];
                stack[pointer++] = (val > currMax) ? val : currMax;
            }
        }
        else if (type == '2') {
            --pointer;
        }
        else {
            printf("%d\n", stack[pointer - 1]);
        }
        
    }
    
    return 0;
}
