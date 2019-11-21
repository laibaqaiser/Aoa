#include<fstream>
#include<string>
#include <unordered_map>
using namespace std;
int main() {

	ifstream file;
	file.open("aoa.txt");



	string a;
	cout << "enter  the string";
	cin >> a;
	unordered_map<char, int> freq;
	for (int i = file.begin();i != file.end();i++)
		for (char ch : file) {
			freq[ch]++;
		}

	for (char ch : "aoa.txt") {
		cout << ch << "             ";
		cout << freq.at(ch) << endl;
	}
	system("pause");
	return 0;
}
