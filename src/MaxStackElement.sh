read N
stack=()
pointer=0

for (( i=0; i<$N; i++ )) do
    read line
    query=${line:0:1}
    if [ $query -eq 1 ] ; then
        len=${#line}
        val=${line:2:$len}
        if [ $pointer -eq 0 ] ; then
            stack[$pointer]=$val
        else 
            currMax=${stack[(($pointer-1))]}
            if [ $val -gt $currMax ] ; then
                stack[$pointer]=$val
            else
                stack[$pointer]=$currMax
            fi
        fi
        ((++pointer))
    elif [ $query -eq 2 ] ; then
        ((--pointer))
    else
        echo ${stack[(($pointer-1))]}
    fi
done

