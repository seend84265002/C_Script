using System;

namespace Ch9_P54
{
    class Program
    {
        static void Main(string[] args)
        {
            int cnt = 10;
            cnt = student.NumOfStudent();
            Console.WriteLine(cnt);
        }
    }

    public class student
    {
        private string Name;
        private static int Count=999;
        public static int NumOfStudent() {
            NothingToDo();
            return Count; }      //static 方法要用static 屬性 ，static一開始就可以使用了 所以他的屬性也要用static處理
        public static void NothingToDo()
        {
            ;
        }
    } 
}
