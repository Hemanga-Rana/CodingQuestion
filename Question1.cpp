#include <bits/stdc++.h>
using namespace std;

void rearrangeItems(int array[], int n)
{
    int temp[n];
    int small = 0, large = n - 1;
    int flag = true;

    for (int i = 0; i < n; i++) {
        if (flag)
            temp[i] = array[large--];
        else
            temp[i] = array[small++];

        flag = !flag;
    }
    
    for (int i = 0; i < n; i++)
        array[i] = temp[i];
}
int main()
{
    int array[5];
    int n=5;
    for(int i =0; i<n; i++)
        cin>>array[i];
    rearrangeItems(array, n);
    for (int i = 0; i < n; i++)
        cout << array[i] << " ";
}