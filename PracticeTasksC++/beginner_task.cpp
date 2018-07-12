#include <iostream>
#include <string>
#include "beginner_task.h"

using namespace std;

void beginner_task_1(){
	//Задание:
	/*
		Составить программу, которая будет считывать введённое пятизначное число. После чего, каждую цифру этого числа необходимо вывести в новой строке.
	*/

	//Буду проверять ввели ли число, если ввели число, то проверю, ввели ли пятизначное число.
	//Если введено пятизначное число, то буду каждый разряд выводить на экран

	string stringNumber; //Строка для ввод текста
	std::cout << "Введите целое пятизначное число: ";
	getline (cin, stringNumber); //Принимаем ввод с клавиатуры
	
	bool ThisIsNumber = true;
	int Number = 0; // ввыеденое число
	for(int i = 0; i < stringNumber.size(); i++){
		if((int) stringNumber[0] < 48 || (int) stringNumber[0] > 57) ThisIsNumber = false;
		Number = Number * 10 + ((int) stringNumber[i] - 48);
	}

	if(ThisIsNumber){
		if (Number >= 10000){
			//Вывод числав на экран
			for(int i = 0; i < 5; i++){
				std::cout << (i+1) << " цифра равна " << (Number/(int)(pow(10.0f, 4-i)))%10 << std::endl;
			}
		}
		else{
			std::cout << "Вы ввели не пятизначное число!\n";
		}
	}
	else std::cout << "Вы ввели не число!\n";
};
