// Защита OpenCV
// 1. Что значит строка unsigned long milliseconds_since_epoch = chrono::system_clock::now().time_since_epoch() / chrono::milliseconds(1); - расчет времени совершения события(нажатия лкм или пкм)
// 2. Какие существуют потоки для работы с файлами - ifstream: для чтения с файла; ofstream: для записи в файл; fstream: совмещает запись и чтение
// 3. Дополнить код, для считывание из файла координат - done
// 4. Доюавить перевод пиксельных координат в географические - done
// 5. Изменить команду, чтобы реагировало на правое нажатие мыши - done

#include <stdio.h>
#include <iostream>
#include <fstream>
#include <chrono>
#include <ctime>
#include "opencv2/core.hpp"
#include "opencv2/features2d.hpp"
#include "opencv2/highgui.hpp"
#include "opencv2/imgproc.hpp"
#include "opencv2/imgproc.hpp"
#include "opencv2/imgcodecs.hpp"
#include "opencv2/highgui.hpp"
#include <string>
#include <cstring>

using namespace cv;
using namespace std;

void my_mouse_callback(int event, int x, int y, int flags, void* param);
int reading(string Filename, string imagename, double wl, double hl, double wr, double hr);
void file();

int main(int argc, char** argv)
{
	// устанвливаем русскую локаль для консоли
	setlocale(LC_ALL, "Russian");
	//file();

	const char* imagename = "town.png";
	const char* traectory_file = "test1.txt";
	double wl = 55.639799;
	double hl = 37.828428;
	double wr = 55.622020;
	double hr = 37.873735;
	/*reading("test1.txt", "town.png", wl, hl, wr, hr);*/
	cout << "Выберите какое действие вы хотите выполнить: считать или записать?" << endl;
	int userAnswer = 0;
	cin >> userAnswer;
	cout << userAnswer;
	if (userAnswer == 1) {
		reading("test1.txt", "town.png", wl, hl, wr, hr);
	}
	else if (userAnswer == 2)
	{
		Mat image = imread("town.png");

		namedWindow("modernGoogle");
		setMouseCallback("modernGoogle", my_mouse_callback, &image);
		while (true) {
			imshow("modernGoogle", image);
			waitKey(30);
		}
		
	}
	else {
		return(0);
	}
	
}

	void my_mouse_callback(int event, int x, int y, int flags, void* param)
	{
		if (event == EVENT_RBUTTONDOWN)//LBUTTONDOWN для нажатия ЛКМ
		{
			Mat* plmage = (Mat*)param;
			Mat image = *plmage;
			/*x = xm;
			y = ym;
			imshow("route", img);
			waitKey(tt - t);
			t = tt;*/

			circle(image, Point(x, y), 5, Scalar(255, 0, 0), FILLED, 8, 0);
			std::ofstream file;
			file.open("test1.txt", ios_base::app);
			unsigned long milliseconds_since_epoch = chrono::system_clock::now().time_since_epoch() / chrono::milliseconds(1);
			file << milliseconds_since_epoch << " " <<  x << " " <<   y << endl;
			file.close();
		}
	


		//std::string line;

		//std::ifstream in("test1.txt"); // окрываем файл для чтения
		//if (in.is_open())
		//{
		//	while (getline(in, line))
		//	{
		//		std::cout << line << std::endl;
		//	}
		//}
		//in.close();     // закрываем файл

	  /*  std::cout << "End of program" << std::endl;*/
	}

	int reading(string Filename, string imagename, double wl, double hl, double wr, double hr)
	{



		string File = Filename;
		int x, y, xm, ym;
		unsigned long t, tt;
		long double shirota, dolgota;

		ifstream f(File);
		if (!(f.is_open()))  cout << "Ошибка открытия файла" << File;
		else
		{
			Mat img = imread(imagename);
			cout << "Размер изображения: " << endl;
			cout << "Ширина: " << img.size().width << endl;
			cout << "Высота: " << img.size().height << endl;
			//вычисляем коэффициент масштабирования
			long double koef_mashtabW, koef_mashtabH;
			koef_mashtabW = (wl - wr) / img.size().width;
			koef_mashtabH = (hr - hl) / img.size().height;
			//cout << koef_mashtabW << koef_mashtabH << endl;

			f >> t >> x >> y;

			cout << "Ваш путь пролегает по следующему  маршруту: " << endl;
			while (!f.eof())
			{
				f >> tt >> xm >> ym;

				//cout << "Метка времени: " << t << " x: " << x << " y: " << y << endl;
				shirota = koef_mashtabW * (img.size().width - x) + wr;
				dolgota = koef_mashtabH * (img.size().height - y) + hl;
				cout << "Метка времени: " << t << " широта: " << shirota << " долгота: " << dolgota << endl;

				circle(img, Point(x, y), 5, Scalar(0, 0, 255), FILLED, 8, 0);
				x = xm;
				y = ym;
				imshow("route", img);
				waitKey(tt - t);
				t = tt;
			}
		}return 0;
	}
void file()
{
	ofstream file;
	file.open("test.txt", ios_base::app);
	unsigned long milliseconds_since_epoch = chrono::system_clock::now().time_since_epoch() / chrono::milliseconds(1);
	file << milliseconds_since_epoch << endl;
	file.close();

}


