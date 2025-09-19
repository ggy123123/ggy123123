#include <vector>
#define MAX_VOL 10
using namespace std;

void dfs(const vector<int> weights, const vector<int> vals, bool visit[], int currWeight, vector<int> seq){
    for(int i; i<4; i++){
        if(!visit[i]){
            if(currWeight+weights[i] > MAX_VOL)
                continue;
            visit[i] = true;
            seq.push_back(i);
            dfs(weights,vals, visit[],(currWeight+weights),seq);
            s
        }
    }
}