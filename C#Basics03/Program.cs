namespace C_Basics03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region (Q1) Accessing the second element using index 1

            //double[] Prices = { 25.5, 40.0, 33.75 };
            //Console.WriteLine($"The second price : {Prices[1]}");


            #endregion

            #region (Q2) Accessing an element in a 2D array

            //int[,] ShelfCopies =
            //{
            //   { 3, 5 },
            //   { 1, 4 }
            //};

            //Console.WriteLine($"Number of copies : {ShelfCopies[1, 0]}");


            #endregion

            #region(Q3) Calling a method with no parameters

            //PrintWelcomeMessage();

            #endregion

            #region (Q4) Calling a method with a string parameter

            //Console.WriteLine("Enter the book title: ");
            //string? Title= Console.ReadLine();

            //PrintBookTitle(Title);

            #endregion

            #region(Q5) Calling AddBounsPages method to see if Pages value changed or not (Passing by value => Value type)
            //bool flag = false;
            //int Pages = 0;
            //do
            //{
            //    Console.WriteLine("Enter the number of pages: ");
            //    flag = int.TryParse(Console.ReadLine(), out Pages);

            //} while (!flag);

            //Console.WriteLine($"Pages: {Pages}");
            //AddBonusPages(Pages);
            //Console.WriteLine($"pages afterward: {Pages}");

            /*
             * The original Pages variable doesn't change because int is a value type
             * and the method receives a copy of the value (passed by value).
             * The copy becomes 450 inside the method, but the original remains 400.
             */

            #endregion

            #region (Q6) Calling ApplyDiscount method to see if value index zero changed or not (Passing by value => Reference type)

            //double[] prices = { 25.5, 40.0 };
            //ApplyDiscount(prices);
            //Console.WriteLine(prices[0]);

            /*
            * The array is a reference type, so the method receives a copy of the reference
            * that points to the same array.
            * Therefore, changing prices[0] inside the method changes the original array.
            */

            #endregion

            #region (Q7) Calling AddBounsPagesByRef method to see if Pages value changed or not (Passing by Ref => Value type)

            //bool flag = false;
            //int Pages = 0;
            //do
            //{
            //    Console.WriteLine("Enter the number of pages: ");
            //    flag = int.TryParse(Console.ReadLine(), out Pages);

            //} while (!flag);

            //Console.WriteLine($"Pages: {Pages}");
            //AddBonusPagesByRef(ref Pages);
            //Console.WriteLine($"pages afterward: {Pages}");

            /*
             * The value of Pages changed because it was passed by reference.
             * The method directly modified the original variable, so its value became 450.
             */

            #endregion

            #region (Q8) Calling ReplaceArray method to see if it replace array prices1 with array prices or not (Passing by Ref => Reference type)

            double[] Prices1 = { 25.5, 40.0 };
            ReplaceArray(ref Prices1);
            Console.WriteLine($"Prices lenght afterward: {Prices1.Length}");

            #endregion



        }

        //Q3
        /// <summary>
        /// this method print welcome message only
        /// </summary>
        static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }

        //Q4
        /// <summary>
        /// Prints the title of a book to the console.
        /// </summary>
        /// <param name="title">The title of the book.</param>
        static void PrintBookTitle(string? title)
        {
            Console.WriteLine("Book title:" + title);
        }

        //Q5
        /// <summary>
        /// Adds 50 bonus pages to the given number of pages.
        /// </summary>
        /// <param name="pages">The number of pages to add the bonus to.</param>
        static void AddBonusPages(int pages)
        {
            pages += 50;

        }

        //Q6
        /// <summary>
        /// Applies a 5-unit discount to the first price in the array.
        /// </summary>
        /// <param name="prices">An array containing the prices.</param>
        static void ApplyDiscount(double[] prices)
        {
            prices[0] -= 5;
        }

        //Q7
        /// <summary>
        /// Adds 50 bonus pages to the original number of pages.
        /// </summary>
        /// <param name="pages">The number of pages passed by reference.</param>
        static void AddBonusPagesByRef(ref int pages)
        {
            pages += 50;
        }

        //Q8
        /// <summary>
        /// Replaces the original price array with a new array of prices.
        /// </summary>
        /// <param name="prices">A reference to the price array to be replaced.</param>
        static void ReplaceArray(ref double[] prices)
        {
            prices = new double[] { 10.0, 12.5, 15.0 };

        }





    }
}
