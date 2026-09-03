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

                
            }
        }
}
