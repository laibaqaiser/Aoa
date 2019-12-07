#include<iostream>
using namespace std;
void printParenthesis(int s[],int i,int j,int n)
{
if (i == j)
{ 
        cout <<"A"<<i; 
        return;
    }  
else
   {
      cout << "("; 
      printParenthesis(s,i, *((s+i*n)+j),n);
      printParenthesis(s,*((s+i*n)+j) + 1, j,n);
      cout << ")"; 
   }
}
int MatrixChain(int p[],int n)
{
	int m[n][n];
	int s[n][n];
	int i,j,k,l,q;
	for(int i=1;i<n;i++)
	{
		m[i][i]=0;
	}
	
	for(l=2;l<n;l++)
	{
		for(i=1;i<n-l+1;i++)
		{
			j=i+l-1;
			m[i][j]=INT_MAX;
			for(k=i;k<=j-1;k++)
			{
				q=m[i][k]+m[k+1][j]+p[i-1]*p[k]*p[j];
				if(q<m[i][j])
				{
					m[i][j]=q;
					s[i][j]=k;		
				}	
			}
		}
	}
	cout << "Optimal Parenthesization is : "; 
	printParenthesis(*s,1,n-1,n); 
	return m[1][n - 1]; 
}
int main()
{
	int n,i;
    cout<<"Enter number of matrices"<<endl;
    cin>>n;
    n++;
    int arr[n];
    cout<<"Enter dimensions"<<endl;
    for(i=0;i<n;i++)
    {
        cout<<"Enter d"<<i<<" :: ";
        cin>>arr[i];
    }
    cout << "\nMinimum number of multiplications is "<< MatrixChain(arr, n);
	return 0; 
   
}



