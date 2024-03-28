using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibaryTask
{
    internal class Book:Product
    {
        public string Genre;

        public Book(string name,double price,string genre,int no):base(name,price,no)
        {
            Genre = genre;
               
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Name: {this.Name}\n Price: {this.Price}\n  Genre: {this.Genre} No: {this.No}");
          
        }

    }
}
