#include "MyForm.h"
#include <Windows.h>
#include <string>
#using <System.dll>
#using <System.Windows.Forms.dll>
#using <System.Drawing.dll>
using namespace System;
using namespace System::Windows::Forms;
using namespace System::Threading;
using namespace System::IO;
public ref class Task7Form : public Form
{
private:
	Button^ btnCalculate;
	RichTextBox^ rtbResult;
	array <int>^ numbers;
	String^ Rus(const char* text)
	{
		int len = MultiByteToWideChar(CP_UTF8, 0, text, -1, NULL, 0);
		wchar_t* wstr = new wchar_t[len];
		MultiByteToWideChar(CP_UTF8, 0, text, -1, wstr, len);
		String^ result = gcnew String(wstr);
		delete[] wstr;
		return result;
	}
public:
	Task7Form()
	{
		this->Text = Rus("Multithreaded computation");
		this->Size = System::Drawing::Size(500, 400);
		this->StartPosition = FormStartPosition::CenterScreen;
		btnCalculate = gcnew

	}
}
int globalmax = INT_MAX;
int globalmin = INT_MIN;
int globalavg = 0;
std::vector<int> numbers;
void FindMax()
{
	int localMax = numbers[0];
	for (int num : numbers)
	{
		if (num > localMax)
		{
			localMax = num;
		}
	}
	globalmax = localMax;
}
void FindMin()
{
	int localMin = numbers[0];
	for (int num : numbers)
	{
		if (num < localMin)
		{
			localMin = num;
		}
	}
	globalmin = localMin;
}
void FindAvg()
{
	long long sum = 0;
	for (int num : numbers)
	{
		sum += num;
	}
	globalavg = (double)sum / numbers.size();
}
void WhiteToFile()
{
	std::ofstream file("result.txt");
	if (file.is_open())
	{
		file << "Generate\n";
		for (int mun : numbers)
		{
			file << mun << " ";
		}
		file << "\n\nResult\n";
		file << "Max: " << globalmax << "\n";
		file << "min: " << globalmin << "\n";
		file << "Average: " << globalavg << "\n";
		file.close();
		cout << "Successfully" << endl;
	}
	else
	{
		cout << "Error notepad opening" << endl;
	}
}
int main()
{
	srand(time(NULL));
	cout << "Generate 10000 numbers..." << endl;
	for (int i = 0; i <= 10000; i++)
	{
		numbers.push_back(rand() % 1000 + 1);
	}
	cout << "Launch threads calculations..." << endl;
	std::thread t1(FindMax);
	std::thread t2(FindMin);
	std::thread t3(FindAvg);
	t1.join();
	t2.join();
	t3.join();
	cout << "Max: " << globalmax << endl;
	cout << "Min: " << globalmin << endl;
	cout << "Average: " << globalavg << endl;
	cout << "Launth thread in the file..." << endl;
	std::thread t4(WhiteToFile);
	t4.join();
	return 0;
}
