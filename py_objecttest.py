import copy
class Testclass():
    def __init__(self):
        self.a =0
        self.b =0


def Testfunc(a2,b2): 
    a2[0] = 5
    a2[1] = 6
    b2.a = 5
    b2.b = 6


def Testfunc2(a2,b2):
    a2[0] = 7
    a2[1] = 8
    b2.a = 7
    b2.b = 8


def main():
    b = Testclass
    a = [1,2]
    b.a = 1
    b.b = 2
    print( a[0],a[1],b.a , b.b)


    b2 = Testclass
    a2 = a
    b2 = b
    a2[0] = 3
    a2[1] = 4
    b2.a = 3
    b2.b = 4
    print( a[0],a[1],b.a , b.b)

    Testfunc(a, b)
    print( a[0],a[1],b.a , b.b)

    Testfunc2(copy.copy(a), copy.copy(b))
    print( a[0],a[1],b.a , b.b)

main()