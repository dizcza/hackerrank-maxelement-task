import java.io.DataInputStream;
import java.io.IOException;

import static java.lang.System.in;

public class Solution {

    public static void main(String[] args) throws IOException  {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        DataInputStream reader = new DataInputStream(in);
        final int N = Integer.parseInt(reader.readLine());
        final int[] stack = new int[N];
        int pointer = 0;

        for (int lineId = 0; lineId < N; ++lineId) {
            String line = reader.readLine();
            char query = line.charAt(0);
            if (query == '1') {
                int val = Integer.parseInt(line.substring(2));
                if (pointer == 0) {
                    stack[pointer++] = val;
                }
                else {
                    int currMax = stack[pointer-1];
                    stack[pointer++] = (val > currMax) ? val : currMax;
                }
            }
            else if (query == '2') {
                pointer--;
            }
            else {
                System.out.println(stack[pointer-1]);
            }
        }

        reader.close();
    }
}
