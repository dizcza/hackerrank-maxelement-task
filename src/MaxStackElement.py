# Enter your code here. Read input from STDIN. Print output to STDOUT
N = int(raw_input())
stack = []
for i in range(N):
    line = raw_input()
    query = line[0]
    if query == '1':
        val = int(line[2:])
        if len(stack) == 0:
            stack.append(val)
        else:
            currMax = stack[-1]
            stack.append(val if val > currMax else currMax)
    elif query == '2':
        stack.pop()
    else:
        print(stack[-1])
