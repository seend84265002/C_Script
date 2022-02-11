using System;

namespace Ch12__P23_Lamde
{
    class Program
    {
        delegate int mydelegate(int x);//委派 int型態 回傳int 數值
        delegate void MyEmptyDelegate();
        static void Main(string[] args)
        {
            mydelegate a = delegate (int x) { return x * x; };
            Console.WriteLine("The Value is = " + a(7));

            mydelegate b = (int x) => x * x;           //Lamde => 代表 return
            Console.WriteLine("The Value is = " + b(5));

            mydelegate c = x => x * x;           //Lamde => 代表 return  只有一個函數可以再簡化
            Console.WriteLine("The Value is = " + c(4));

            MyEmptyDelegate d = () => Console.WriteLine("Today is Friday");
            d();

            mydelegate e = x =>
            {
                int y = x * x;
                return y;
            };
            Console.WriteLine("The Value is:" + e(3));

            mydelegate f = (int x) =>
            {
                int y = x * x;
                return y;
            };
            Console.WriteLine("The Value is:" + f(9));

            MyEmptyDelegate g = Hi;
            g();
            Console.WriteLine("-----------------------");
            g += Bye;
            g();
            Console.WriteLine("-----------------------");
            g -= Bye;
            g();

        }

        static void Hi() { Console.WriteLine("HI"); }
        static void Bye() { Console.WriteLine("Bye"); }
    }
}
