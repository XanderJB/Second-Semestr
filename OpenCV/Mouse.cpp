// Защита OpenCV
// 1. Что значит строка unsigned long milliseconds_since_epoch = chrono::system_clock::now().time_since_epoch() / chrono::milliseconds(1);
// 2. Какие существуют потоки для работы с файлами
// 3. Дополнить код, для считывание из файла координат
// 4. Доюавить перевод пиксельных координат в географические
// 5. Изменить команду, чтобы реагировало на правое нажатие мыши.

//пока что есть ошибки
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
	cout << "Размер изображения: " << endl;
	cout << "Ширина: " << endl;
	cout << "Высота: " << endl;

	long double koef_mashtabW, koef_mashtabH;
	koef_mashtabW = (wl - wr) / img.size().width;
	koef_mashtabH = (hr - hl) / img.size().height;

	cout << "Ваш путь пролегает по следующему маршруту: " << endl;
	while (!f.eof()) 
	{
		f >> tt >> xm >> ym;
		shirota = koef_mashtabW * (img.size().width - x) + wr;
		dolgota = koef_mashtabH * (img.size().height - y) + hl;
		cout << "Метка времени" << t << " широта: " << shirota << " долгота: " << dolgota << endl;


	}
	namedWindow("modernGoogle");
	setMouseCallback("modernGoogle", my_mouse_callback, &image);
	/*Mat dst, im;*/
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
		x = xm;
		y = ym;
		imshow("route", img);
		waitKey(tt - t);
		t = tt;
	}
		circle(image, Point(x, y), 5, Scalar(255, 0, 0), FILLED, 8, 0);
		std::ofstream file;
		file.open("test1.txt", ios_base::app);
		unsigned long milliseconds_since_epoch = chrono::system_clock::now().time_since_epoch() / chrono::milliseconds(1);
		file << " Meтка времени: " << milliseconds_since_epoch <<  " широта: " << x << " " << " долгота: " << y << endl;
		file.close();
	

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
