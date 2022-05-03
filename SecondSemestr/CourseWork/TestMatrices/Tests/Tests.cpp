// Tests.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
#include <iostream>
#include <fstream>
#include <string>
#include <vector>
#include <limits>
#include <ctime>

using namespace std;

int main()
{
	int const length = 31;
	int a[length]; // массив для генерации чисел

	int const d = 10;

	int adj_matrix[d][d];


	int n = 50;


	for (int i = 1; i <= n; i++)
	{
		std::ofstream fout; // объект класса ofstream
		fout.open(std::to_string(i) + "test.txt"); // открываем файл. если такого нет, создается. расположение файла 
		srand(time(0) + i);
		for (int k = 0; k < 50; k++)
		{
			for (int u = 0; u < d; u++)
			{
				for (int v = 0; v < d; v++)
				{
					adj_matrix[u][v] = -1;
				}
			}

			for (int u = 0; u < d; u++)
			{
				for (int v = 0; v < d; v++)
				{
					if (adj_matrix[u][v] == -1)
					{
						
						adj_matrix[u][v] = rand() % 10;
						adj_matrix[v][u] = adj_matrix[u][v];
					
					}


				}
			}

			for (int i = 0; i < d; i++)
			{
				adj_matrix[i][i] = 0;
			}


			for (int u = 0; u < d; u++)
			{
				for (int v = 0; v < d; v++)
				{
					fout << adj_matrix[u][v]<<" ";
				}
				fout << "\n";
			}
			fout << "#";
			fout << "\n";
			
			for (int u = 0; u < d; u++)
			{
				for (int v = 0; v < d; v++)
				{
					adj_matrix[u][v] = -1;
				}
			}
		}
		fout.close();
	}
}