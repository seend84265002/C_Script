using System;

namespace Ch3_7_1_8
{
    class Book
    {
        private string title;
        private int Numpages { get; set; }
        private double Price { get; set; }
        public String Title
        {
            get { return this.title; }
            set { this.title = value; }
        }
        public void AdvertisngMessage()
        {
            Console.WriteLine("Buy it Now : {0}", this.Title);
            Console.WriteLine("Total Pages : {0}", this.Numpages);
            Console.WriteLine("With Price : {0}", this.Price);
        }
        static void Main(string[] args)
        {
            Book myBook = new Book();
            Book yourBook = new Book();
            myBook.Title = "The Winner";
            myBook.Numpages = 365;
            myBook.Price = 1020;

            yourBook.Title = "The Time is Money";
            yourBook.Numpages = 764;
            yourBook.Price = 2020;

            myBook.AdvertisngMessage();
            Console.WriteLine();
            yourBook.AdvertisngMessage();
            Console.ReadLine();

        }
    }
}
