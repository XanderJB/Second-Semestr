#define _CRT_SECURE_NO_WARNINGS
#include <opencv2/highgui/highgui.hpp>
#include <opencv2/imgproc/imgproc.hpp>
#include <iostream>
#include <stdio.h>
#include <stdlib.h>
#include <chrono>
#include <ctime>
#include <fstream>
#include <string>


using namespace cv;
using namespace std;

Mat img;
void my_mouse_callback(int event, int x, int y, int flags, void* param);

int main(int argc, char** argv)
{

	const char* traectory_file = "coordinat.txt";
	double wl = 55.639799;
	double hl = 37.828428;
	double wr = 55.622020;
	double hr = 37.873735;
	Mat image = imread("town.png");
	namedWindow("modernGoogle");
	Mat dst, im;


	setMouseCallback("modernGoogle", my_mouse_callback, &image);
	while (true) {
		imshow("modernGoogle", image);
		waitKey(30);
	}
	return(0);
}

void my_mouse_callback(int event, int x, int y, int flags, void* param)
{
	if (event == EVENT_LBUTTONDOWN)
	{
		Mat* plmage = (Mat*)param;
		Mat image = *plmage;
		circle(image, Point(x, y), 5, Scalar(255, 0, 0), FILLED, 8, 0);
		std::ofstream file;
		file.open("test1.txt", ios_base::app);
		unsigned long milliseconds_since_epoch = chrono::system_clock::now().time_since_epoch() / chrono::milliseconds(1);
		file << milliseconds_since_epoch << " = " << x << " " << y << endl;
		file.close();
	}

	std::string line;

	std::ifstream in("test1.txt"); // окрываем файл для чтения
	if (in.is_open())
	{
		while (getline(in, line))
		{
			std::cout << line << std::endl;
		}
	}
	in.close();     // закрываем файл

  /*  std::cout << "End of program" << std::endl;*/
}
