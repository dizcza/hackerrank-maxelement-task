import java.util.Scanner;

public class Solution {


    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        Scanner sc = new Scanner(System.in);
        int N = sc.nextInt();
        int[] stack = new int[N];
        int pointer = 0;

        for (int lineId = 0; lineId < N; ++lineId) {
            char type = sc.next().charAt(0);
            if (type == '1') {
                int val = sc.nextInt();
                if (pointer == 0) {
                    stack[pointer++] = val;
                }
                else {
                    int currMax = stack[pointer-1];
                    stack[pointer++] = (val > currMax) ? val : currMax;
                }
            }
            else if (type == '2') {
                --pointer;
            }
            else {
                System.out.println(stack[pointer-1]);
            }
        }
    }
}