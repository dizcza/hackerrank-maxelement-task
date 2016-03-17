using System;

class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int N, val, currMax, pointer = 0;
        char query;
        N = Convert.ToInt32(Console.ReadLine());
        int[] stack = new int[N];
        for (int i = 0; i < N; ++i) {
            string line = Console.ReadLine();
            query = line[0];
            if (query == '1') {
                val = Convert.ToInt32(line.Substring(2));
                if (pointer == 0) {
                    stack[pointer++] = val;
                }
                else {
                    currMax = stack[pointer-1];
                    stack[pointer++] = (val > currMax) ? val : currMax;
                }
            }
            else if (query == '2') {
                --pointer;
            }
            else {
                Console.WriteLine(stack[pointer-1]);
            }
        }
    }
}
