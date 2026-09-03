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

            #region 4
            try
            {
                int n = 10;
                int x = 0;
                int res = n / x;
                Console.WriteLine(res);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.WriteLine("Done");
            }
            #endregion

            Console.WriteLine($"=======\n");

            #region 5
            int intPages = 300;
            double doublePages = intPages;
            Console.WriteLine(doublePages);
            #endregion

            Console.WriteLine($"=======\n");

            #region 6
            double dprice = 49.99;
            int iprice = (int)dprice;
            Console.WriteLine(iprice);
            #endregion

            Console.WriteLine($"=======\n");

            #region 7
            string pagesText = "464"; //[cite: 1]
            int convertedPages = Convert.ToInt32(pagesText);
            Console.WriteLine(convertedPages);
            #endregion

            

        }
    }
}
