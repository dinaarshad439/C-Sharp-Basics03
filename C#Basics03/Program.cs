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

            PrintWelcomeMessage();

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


    }
}
