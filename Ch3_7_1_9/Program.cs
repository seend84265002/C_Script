using System;

namespace Ch3_7_1_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Book theBook = new Book();
            double price = 1020;
            theBook.setPriceandTax(1020);
            theBook.ShowBookInfo();
            Console.ReadLine();
        }
    }
    class Book
    {
        private double tax;
        private double price;
        public void setPriceandTax(double price)
        {
            const double TAX_rate = 0.07;
            this.price = price;
            tax = price * TAX_rate;
        }
        public void ShowBookInfo()
        {
            Console.WriteLine("The Price is : {0}", price);
            Console.WriteLine("The Tax is : {0}", tax);
        }
    }
}
