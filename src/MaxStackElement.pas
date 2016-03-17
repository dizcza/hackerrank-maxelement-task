(* Enter your code here. Read input from STDIN. Print output to STDOUT *)
program Solution;

var
    stack : array of longint;
    N, val, pointer, i, currMax : longint;
    query : byte;

begin
    readln(N);
    setlength(stack, N);
    pointer := 0;
    for i := 0 to N-1 do
    begin
        read(query);
        if query = 1 then 
        begin
            read(val);
            if pointer = 0 then
                stack[pointer] := val
            else 
            begin
                currMax := stack[pointer-1];
                if val > currMax then 
                    stack[pointer] := val
                else
                    stack[pointer] := currMax;
            end;
            Inc(pointer);
        end
        else if query = 2 then
            Dec(pointer)
        else 
            writeln(stack[pointer-1]);
    end;
end.
