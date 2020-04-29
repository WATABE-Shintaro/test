#include <iostream>
using namespace std;

class Testclass {
public:
    int a, b;
};

void Testfunc(int a2[], Testclass b2) {
    a2[0] = 5;
    a2[1] = 6;
    b2.a = 5;
    b2.b = 6;
}

void Testfunc2(int a2[], Testclass& b2) {
    int a3[2];
    memcpy(a3, a2, sizeof(a2));
    a3[0] = 7;
    a3[1] = 8;
    b2.a = 7;
    b2.b = 8;
}

int main()
{
    int a[2];
    Testclass b;
    a[0] = 1;
    a[1] = 2;
    b.a = 1;
    b.b = 2;
    cout << a[0] << a[1] << b.a << b.b << endl;


    int a2[2];
    Testclass b2;
    //a2 = a;         エラー
    b2 = b;
    a2[0] = 3;
    a2[1] = 4;
    b2.a = 3;
    b2.b = 4;
    cout << a[0] << a[1] << b.a << b.b << endl;

    Testfunc(a, b);
    cout << a[0] << a[1] << b.a << b.b << endl;

    Testfunc2(a, b);
    cout << a[0] << a[1] << b.a << b.b << endl;
}

