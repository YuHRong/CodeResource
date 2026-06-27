// ��ȡ�û�����������������̺�������ӡ����Ļ��
#include<iostream>

using namespace std;

int main() {
 int divisor, dividend, quotient, remaimder;

 cout << "���뱻������ ";
 cin >> dividend;
 cout << "��������� ";
 cin >> divisor;

 quotient = dividend / divisor;
 remaimder = dividend % divisor;

 cout << endl << dividend << " ���� " << divisor << " ���� " << quotient << "\n�� " << remaimder << endl;

 return 0;
}