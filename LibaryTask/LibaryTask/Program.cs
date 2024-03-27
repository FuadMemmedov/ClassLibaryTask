namespace LibaryTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Ferqliler",8,"Tarix",1);
            Book book1 = new Book("Heyvanistan", 6,"Dram",2);
            Book book2 = new Book("Kimyager", 7,  "Roman",3);
            Book book3= new Book("Semerqend", 5,"Dram",4);

            book.ShowInfo();
            book1.ShowInfo();


            Libary libary = new Libary();
            libary.AddBook(book);
            libary.AddBook(book1);
            libary.AddBook(book2);
            libary.AddBook(book3);

            libary.GetFilteredBooks(2, 7);
            libary.GetFilteredBooks("Dram");
            libary.ShowAllBooks();
        }
    }
}
