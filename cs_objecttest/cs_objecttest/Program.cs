using System;

namespace cs_objecttest
{

    class Testclass
    {
        public int a, b;
    };


    class Program
    {
        static void Testfunc(int[] a2, Testclass b2)
        {
            a2[0] = 5;
            a2[1] = 6;
            b2.a = 5;
            b2.b = 6;
        }

        static void Testfunc2(int[] a2,Testclass b2)
        {
            a2 = new int[] { 7, 8 };
            b2 = new Testclass();
            b2.a = 7;
            b2.b = 8;
        }
        static void Testfunc3(ref int[] a2, ref Testclass b2)
        {
            a2 = new int[] { 9, 0 };
            b2 = new Testclass();
            b2.a = 9;
            b2.b = 0;
        }

        static void Main(string[] args)
        {
            int[] a = new int[2];
            Testclass b = new Testclass();
            a[0] = 1;
            a[1] = 2;
            b.a = 1;
            b.b = 2;
            Console.WriteLine("{0}{1}{2}{3}", a[0] , a[1] , b.a, b.b );


            int[] a2 = new int[2];
            Testclass b2 = new Testclass();
            a2 = a;        
            b2 = b;
            a2[0] = 3;
            a2[1] = 4;
            b2.a = 3;
            b2.b = 4;
            Console.WriteLine("{0}{1}{2}{3}", a[0], a[1], b.a, b.b);

            Testfunc(a, b);
            Console.WriteLine("{0}{1}{2}{3}", a[0], a[1], b.a, b.b);

            Testfunc2(a,b);
            Console.WriteLine("{0}{1}{2}{3}", a[0], a[1], b.a, b.b);

            Testfunc3(ref a,ref  b);
            Console.WriteLine("{0}{1}{2}{3}", a[0], a[1], b.a, b.b);
        }
    }
}
