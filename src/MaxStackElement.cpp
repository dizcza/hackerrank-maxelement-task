#include <iostream>

using namespace std;


int main() {
    /* Enter your code here. Read input from STDIN. Print output to STDOUT */
    int N, val, pointer = 0;
    char type;
    cin >> N;
    int stack[N];

    for (int i = 0; i < N; ++i) {
        cin >> type;
        if (type == '1') {
            cin >> val;
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
            cout << stack[pointer - 1] << endl;
        }

    }

    return 0;
}
