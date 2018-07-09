#include <iostream>
#include <fstream>
#include <iostream>
using namespace std;

void main(){
	//Считываем файл
	int kolvo = 0; //количество повторных
	int ch; //посимвольное чтение документа
	int buf; //буфер для скобок
	bool nextBuf = false;
	std::ifstream in("data.txt");
	while((ch = in.get()) != EOF) {   //объяснение ниже
		//std::cout << char(ch); //Вывод нашего документа на консоль
		//std::cout << ch; //-48 вычитать
		
		if(nextBuf){
			buf = ch - 48; // для чисел до 10 он будет не нужен
			nextBuf = false; // Для чисел до 10 сразу обнулять, в другом случае только при поиске )
			kolvo += buf - 1;
		}
		if(char(ch) == ',')  kolvo++;
		if(char(ch) == '('){  
			nextBuf = true;
		}
	}
	in.close();

	//Выводим информацию о количестве повторных наклеек
	std::cout << "Povtorenii = " << kolvo << std::endl;

	system("pause");
}