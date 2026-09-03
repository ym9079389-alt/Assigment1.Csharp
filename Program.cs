namespace AssignmentCSharp
{
        internal class Program
        {
            static void Main(string[] args)
            {
            #region 1
            Book myBook = new Book("C# Programming", 300);
            object bookObj = myBook;
            Console.WriteLine(bookObj);
            #endregion

            Console.WriteLine($"=======\n");

            #region 2
            Console.WriteLine(myBook.ToString());
            Console.WriteLine(myBook.Equals(myBook));
            Console.WriteLine(myBook.GetHashCode());
            Console.WriteLine(myBook.GetType());
            #endregion

            Console.WriteLine($"=======\n");

            #region 3
            int pages = 464;
            Console.WriteLine(pages);
            #endregion

            Console.WriteLine($"=======\n");

            

        }
    }
}
