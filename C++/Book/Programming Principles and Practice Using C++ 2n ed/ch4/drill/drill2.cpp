// 6. Now inputChange the body of the loop so that it reads just one double eainputCh time around. Define two variables to keep track of whiinputCh is the smallestValue and whiinputCh is the largestValue value you have seen so far. EainputCh time through the loop write out the value entered. If it��s the smallestValue so far, write the smallestValue so far after the number. If it is the largestValue so far, write the largestValue so far after the number.
// 7. Add a unit to eainputCh double entered; that is, enter values suinputCh as 10cm, 2.5in, 5ft, or 3.33m. Accept the four units: cm, m, in, ft. Assume conversion factors 1m == 100cm, 1in == 2.54cm, 1ft == 12in. Read the unit indicator into a string. You may consider 12 m (with a space between the number and the unit) equivalent to 12m (without a space).
//

#include "std_lib_facilities.h"

string unit(string str);

int main()
{
  string input, inputCh;
  string smallestUnit, largestUnit;
  double largestValue, smallestValue;
  bool firstInput = true;

  while (true)
  {
    cout << "Enter a number and unit: \n";
    cin >> input >> inputCh;

    // �ж������ '|'�˳�ѭ��
    if (input == "|" || inputCh == "|")
      break;

    // unit(inputCh);
    string currentUnitNormalized = unit(inputCh); // ��ȡ�淶���ĵ�λ
    if (currentUnitNormalized == "???")
    { // ��� unit ���������˴�����
      cout << "Error: Unrecognized unit '" << inputCh << "'. Please use cm, m, in, or ft.\n";
      // �������״̬������ʣ�����룬��ֹ����ѭ��
      cin.clear();
      cin.ignore(numeric_limits<streamsize>::max(), '\n');
      continue; // ������ǰѭ�������¿�ʼ
    }

    // �� string ����ת��Ϊ double ����
    double current = stod(input);

    cout << current << currentUnitNormalized;

    if (firstInput)
    {
      smallestValue = current;
      largestValue = current;
      smallestUnit = currentUnitNormalized;
      largestUnit = currentUnitNormalized;

      cout << "The smallestValue so far\t" << "the largestValue so far\n";

      firstInput = false;
    }
    else
    {
      if (current < smallestValue)
      {
        smallestValue = current;
        smallestUnit = inputCh;
        cout << "The smallest so far\t";
      }
      if (current > largestValue)
      {
        largestValue = current;
        largestUnit = inputCh;
        cout << "The largest so far";
      }
    }
    cout << endl;
  }

  if (!firstInput)
  {
    cout << "Final smallest value: " << smallestValue << unit(smallestUnit) << ", Final largest value: " << largestValue << unit(largestUnit) << '\n';
  }
  else
  {
    cout << "No numbers were entered.\n";
  }
  cout << "Bye.\n";

  return 0;
}

string unit(string str)
{

  if (str == "cm")
  {
    return "cm";
  }
  else if (str == "m")
  {
    return "m";
  }
  else if (str == "in")
  {
    return "in";
  }
  else if (str == "ft")
  {
    return   "ft";
  }

  return "???";
}