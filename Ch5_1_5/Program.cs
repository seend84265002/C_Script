using System;
using System.Collections;

namespace Ch5_1_5
{
    struct Person_Info {
        public string name;
        public byte gender; //1. Male  0.Female
        public Birth birth;
    }
    struct Birth
    {
        public int year;
        public byte month;
        public byte data;
    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList aList = new ArrayList();
            
            Person_Info p = new Person_Info();
            p.name = "Andy";
            p.gender = 1;
            p.birth.year = 1967; p.birth.month = 12;p.birth.data = 21;
            
            aList.Add(p);

            p.name = "Beddy";
            p.gender = 0;
            p.birth.year = 1993;p.birth.month = 4;p.birth.data = 18;
            aList.Add(p);

            ArrayListInfo(aList);
        }
        static void ArrayListInfo(ArrayList list)
        {
            foreach (var e in list)
            {
                Console.WriteLine("Name: " + ((Person_Info)e).name);
                Console.WriteLine("Gender: " + ((Person_Info)e).gender);
                Console.WriteLine("Year: " + ((Person_Info)e).birth.year);
                Console.WriteLine("Month: " + ((Person_Info)e).birth.month);
                Console.WriteLine("Data: " + ((Person_Info)e).birth.data);
                Console.WriteLine("__________________________________________________");
            }
        }

    }
}
