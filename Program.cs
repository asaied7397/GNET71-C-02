namespace CSharpBasicsSession02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // #region Question 01 
            // Book firstBook = new Book
            // {
            //     Title = "The Hobbit",
            //     Pages = 464
            // };
            // Console.WriteLine("Question 01:");
            // Console.WriteLine(firstBook.ToString());
            // #endregion

            // #region Question 02
            // Book secondBook = new Book
            // {
            //     Title = "Clean Code",
            //     Pages = 464
            // };
            // Console.WriteLine("Question 02:");
            // Console.WriteLine($"ToString(): {secondBook.ToString()}");
            // Console.WriteLine($"Equals itself: {secondBook.Equals(secondBook)}");
            // Console.WriteLine($"GetHashCode(): {secondBook.GetHashCode()}");
            // Console.WriteLine($"GetType(): {secondBook.GetType()}");
            // #endregion

            // #region Question 03
            // * Incorrect code:
            // * int pages = "464";
            // * This is a compile-time error because a string cannot be
            // * assigned directly to an int variable.
            // #endregion

            // #region Question 04
            // try
            // {
            //     int firstNumber = 10;
            //     int secondNumber = 0;
            //     int result = firstNumber / secondNumber;
            //     Console.WriteLine(result);
            // }
            // catch (DivideByZeroException)
            // {
            //     Console.WriteLine("Cannot divide by zero");
            // }
            // finally
            // {
            //     Console.WriteLine("Done");
            // }
            // #endregion

            // #region Question 05
            // int pages = 300;
            // double pagesAsDouble = pages; // Implicit conversion from int to double
            // Console.WriteLine($"Pages as double: {pagesAsDouble}");
            // #endregion

            // #region Question 06
            // double price = 19.99;
            // int priceAsInt = (int)price; // Explicit conversion from double to int
            // Console.WriteLine($"Price as int: {priceAsInt}");
            // #endregion

            // #region Question 07
            // string pagesText = "464";
            // int pagesAsInt = Convert.ToInt32(pagesText); // Convert string to int
            // Console.WriteLine($"Pages as int: {pagesAsInt}");
            // #endregion
        }

    }

}
