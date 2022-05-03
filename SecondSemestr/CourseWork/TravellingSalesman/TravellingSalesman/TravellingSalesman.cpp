
#include <iostream>
#include <fstream>
#include <string>
#include <vector>

using namespace std;

const int inf = 1E9, NMAX = 16;
int n, i, j, k, m, temp, ans, d[NMAX][NMAX], t[1 << NMAX][NMAX];
bool get(int nmb, int x)
{
    return (x & (1 << nmb)) != 0;
}
int main()
{
    string line;
    ifstream in("D:\\test.txt");


    string buffer = "";
    vector<string> commands;

    int const n = 3;

    /*if (in.is_open())
    {
        while (getline(in, line))
        {
            for (int i = 0; i < line.size(); i++)
            {
                if (line[i] != ' ')
                {
                    buffer += line[i];
                }
                else
                {
                    commands.push_back(buffer);
                    buffer = "";
                }
            }
        }
    }*/

        
        for (i = 0; i < n; ++i)
            for (j = 0; j < n; ++j)
            {
                in >> d[i][j];
            }

    for (i = 0; i < n; ++i)
        for (j = 0; j < n; ++j)cout << d[i][j]<<" ";

    cout << endl;

        t[1][0] = 0; m = 1 << n;

    for (i = 1; i < m; i += 2)
        for (j = (i == 1) ? 1 : 0; j < n; ++j)
        {
            t[i][j] = inf;
            if (j > 0 && get(j, i))
            {
                temp = i ^ (1 << j);
                for (k = 0; k < n; ++k)
                    if (get(k, i) && d[k][j] > 0) t[i][j] = min(t[i][j], t[temp][k] + d[k][j]);
            }
        }
    for (j = 1, ans = inf; j < n; ++j)
        if (d[j][0] > 0) ans = min(ans, t[m - 1][j] + d[j][0]);
    if (ans == inf) cout << -1; else cout << ans;
}
