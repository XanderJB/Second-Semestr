#define _CRT_SECURE_NO_WARNINGS
#include <iostream>



using namespace std;
void my_mouse_callback(int event, int x, int y, int flags, void* param);
int main()
{
	if (event == EVENT_LBUTTONDOWN)
	{
		Mat* plmage = (Mat*)param;
		Mat image = *plmage;
		circle(image, Point(x, y), 5, Scalar(255, 0, 0), FILLED, 8, 0);
	}
}
Mat image = imread("")
{
	/*std::ofstream file;
	file.open("test.txt", ios_base::app);
	unsigned long milliseconds_since_epoch = chrono::system_clock::now().time_since_epoch() / chrono::milliseconds(1);
	file << milliseconds_since_epoch << endl;
	file.close();*/

}
