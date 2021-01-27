using System;

namespace WindowsFormsTask2Lab6BiblWorm
{
    internal class Book
    {
        private string author;
        private string title;
        private string publishHouse;
        private int page;
        private int year;
        private int invNumber;
        private bool existence;

        public Book(string author, string title, string publishHouse, int page, int year, int invNumber, bool existence)
        {
            this.author = author;
            this.title = title;
            this.publishHouse = publishHouse;
            this.page = page;
            this.year = year;
            this.invNumber = invNumber;
            this.existence = existence;
        }

        internal void PriceBook(int periodUse)
        {
            throw new NotImplementedException();
        }
    }
}