#include <iostream>
#include <fstream>
#include <iostream>
using namespace std;

void main(){
	//��������� ����
	int kolvo = 0; //���������� ���������
	int ch; //������������ ������ ���������
	int buf; //����� ��� ������
	bool nextBuf = false;
	std::ifstream in("data.txt");
	while((ch = in.get()) != EOF) {   //���������� ����
		//std::cout << char(ch); //����� ������ ��������� �� �������
		//std::cout << ch; //-48 ��������
		
		if(nextBuf){
			buf = ch - 48; // ��� ����� �� 10 �� ����� �� �����
			nextBuf = false; // ��� ����� �� 10 ����� ��������, � ������ ������ ������ ��� ������ )
			kolvo += buf - 1;
		}
		if(char(ch) == ',')  kolvo++;
		if(char(ch) == '('){  
			nextBuf = true;
		}
	}
	in.close();

	//������� ���������� � ���������� ��������� �������
	std::cout << "Povtorenii = " << kolvo << std::endl;

	system("pause");
}