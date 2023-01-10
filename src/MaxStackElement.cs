using System;

class Solution {
    
       private static List<int> getMax(List<string> op)
    {
        var ls =new List<int>();
        var ls1 =new List<int>();
        var lsM =new List<int>();
        int max=int.MinValue;
        for(int i=0;i<op.Count;i++)
        {
            string [] a =op[i].Split(' ');
            if(a[0]=="1")
            {
                int t=Convert.ToInt32(a[1]);
                ls1.Add(t);
                if( t>max)
                {
                 max=t;
                }
                lsM.Add(max);      
              
            }
            else if(a[0]=="2")
            { 
                ls1.RemoveAt(ls1.Count-1);
                lsM.RemoveAt(lsM.Count-1);
             if(lsM.Count>0)
             {
                 max=lsM[lsM.Count-1];
             }
             else
             {
                 max=int.MinValue;
             }
            }
            else
            {
                ls.Add(lsM[lsM.Count-1]);
            }
        }
        return ls;
    }
    
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
