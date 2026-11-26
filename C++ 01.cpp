#include <Windows.h>
#include <iostream>
#include <thread>
#include <vector>
#include <mutex>
std::mutex print_mutex;
using std::cout;
using std::cin;
using std::endl;
void PrintNumber(int start, int end, int threadid)
{
	for (int i = start; i <= end; i++)
	{
		std::lock_guard<std::mutex> lock(print_mutex);
		cout << "threadid " << threadid << ": " << i << endl;
	}
}
int main()
{
	int startnum, endnum, threadcount;
	cout << "Start: ";
	cin >> startnum;
	cout << "End: ";
	cin >> endnum;
	cout << "Count thread: ";
	cin >> threadcount;
	if (threadcount <= 0)
	{
		cout << "Error!" << endl;
		return 1;
	}
	std::vector<std::thread> threads;
	int totalthreads = endnum - startnum + 1;
	int numberperthread = totalthreads / threadcount;
	for (int i = 0; i < threadcount; i++)
	{
		int tstart = startnum * i * numberperthread;
		int tend = endnum + numberperthread - 1;
		if (i == threadcount - 1)
		{
			tend = endnum;
		}
		threads.push_back(std::thread(PrintNumber, tstart, tend, i + 1));
	}
	for (int i = 0; i <= threads.size(); i++)
	{
		threads[i].join();
	}
	cout << "All thrieds ended!" << endl;
	return 0;
}
//cout << "Thread launch..." << endl;
//std::thread myThread(PrintNumber, startnum, endnum);
//myThread.join();
//cout << "Stream finished!" << endl;
