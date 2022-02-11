using System;

namespace Ch3_7_1_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Great Stories", 550, 234.56);
            Book book2 = new Book("Good Tastes", 350, 543.21);
            Book book3 = book1 + book2 ;
            Console.WriteLine("Book3 Title : " + book3.Title);
            Console.WriteLine("Book3 Pages : " + book3.NumPages);
            Console.WriteLine("Book3 Price : " + book3.Price.ToString("#0.00"));
        }
    }
    class Book
    {
        public String Title { get; set; }
        public int NumPages { get; set; }
        public double Price { get; set; }

        public Book(string Title,int NumPages,double Price)
        {
            this.Title = Title;
            this.NumPages = NumPages;
            this.Price = Price;
        }
        public Book() { }
        public static Book operator +(Book frist, Book second)
        {
            Book tmp = new Book();
            tmp.Title = frist.Title +" and "+ second.Title;
            tmp.NumPages = frist.NumPages + second.NumPages;
            //double newPrice;
            if (frist.Price > second.Price)
            {
                tmp.Price = frist.Price + 12.34;
            }
            else
            {
                tmp.Price = second.Price + 12.34;
            }
            return tmp;
        }

    }


}
