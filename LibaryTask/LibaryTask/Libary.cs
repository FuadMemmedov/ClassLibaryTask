using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibaryTask
{
    internal class Libary
    {
        Book[] Books = new Book[] {};
        

        public void AddBook(Book book)
        {
            Array.Resize(ref Books, Books.Length+1);
            Books[Books.Length-1] = book;
        } 
        public void GetFilteredBooks(string a)
        {

            int check = 0;
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Genre == a) 
                {
                    check = 1;
                    Console.WriteLine($"Name: {Books[i].Name}\n " +
                        $"Price: {Books[i].Price}\n " +
                        $"Count: {Books[i].Count}\n " +
                        $"Genre: {Books[i].Genre}");
                     
                }
                 
            }
            if (check == 0)
            {
                Console.WriteLine("Bu janrda kitab yoxdur");
            }


        }
        public void GetFilteredBooks(int minPrice,int maxPrice)
        {
            int check = 0;
            
            for(int i = 0;i < Books.Length;i++)
            {
                if(minPrice < Books[i].Price && maxPrice > Books[i].Price) 
                {
                    check = 1;
                    Console.WriteLine($"Name: {Books[i].Name}\n " +
                        $"Price: {Books[i].Price}\n " +
                        $"Count: {Books[i].Count}\n " +
                        $"Genre: {Books[i].Genre}");
                    
                   
                }
              
                
            }
            if (check == 0)
            {
                Console.WriteLine("Bu qiymet araliqinda kitab yoxdur");
            }

        }
        public void ShowAllBooks()
        {
            for( int i = 0; i < Books.Length ; i++)
            {
                Console.WriteLine($"Name: {Books[i].Name}\n " +
                       $"Price: {Books[i].Price}\n " +
                       $"Count: {Books[i].Count}\n " +
                       $"Genre: {Books[i].Genre}");


            }
        }
    }
}
