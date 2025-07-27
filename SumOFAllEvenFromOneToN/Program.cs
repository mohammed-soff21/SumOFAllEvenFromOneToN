namespace SumOFAllEvenFromOneToN
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Declaring variables
            char cUserChoice = ' ';
            int nUserInput = 0;
            while (true)
            {
                // Welcome message
                WelcomeApp("sum of all even number from 1 to the user input included the user input");
                // ask the user to enter a number
                if(!IsNumber("a number",out nUserInput))
                    return;
                Print($"The sum of all even numbers from 1 to {nUserInput} is: {SumEven(nUserInput)}");
                // To read user choice to continue in the app again and validate the user input
                if (!IsChar("y to continue in the application else enter n", out cUserChoice))
                    return;
                // Convert the character to lower 
                cUserChoice = Char.ToLower(cUserChoice);
                // To check the user input in the right format (y,n)
                if (!IsInRightFormat(cUserChoice))
                    return;
                // To check if the user want to continue or not
                if (!WantToContinue(cUserChoice))
                    return;
            }

        }


        #region Methods 

        // This region contains the main methods used in the application
        #region main-methods

        // 1) this method to welcome user in the beginning of the application
        static void WelcomeApp(String welcomeMessage)
        {
            Console.Clear();
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine($"  Welcome to {welcomeMessage} Application!");
            Console.WriteLine("  This app is designed to make your life easier.");
            Console.WriteLine("  Let's get started!");
            Console.WriteLine("  Developed by: Mohammed Salem");
            Console.WriteLine("*********************************************************************************");
        }

        // 2) this method to print message in a beatiful form
        static void Print(String message)
        {
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine(message);
            Console.WriteLine("---------------------------------------------------------------------------------");
        }

        // 3) this method to read and validate character from the user
        static bool IsChar(string field, out char cInput)
        {
            Console.Write($"Please, enter {field}: ");
            if (!char.TryParse(Console.ReadLine(), out cInput))
            {
                Print("Please, enter a valid character");
                return false;
            }
            return true;
        }

        // 4) this method to check that the user entered (y,n) only
        static bool IsInRightFormat(char input)
        {
            if (input == 'y' || input == 'n')
                return true;
            Print("Please, enter (y) to continue in the application again else enter (n)");
            return false;
        }

        // 5) this method to check the user choice if he wants to continue in the app or not
        static bool WantToContinue(char input)
        {
            if (input == 'y')
                return true;
            Print("The program ended : see you soon again");
            return false;
        }

        // 6) this method to read and validate int number from the user
        static bool IsNumber(string field, out int nValue)
        {
            Console.Write($"Please, enter {field}: ");
            if (!int.TryParse(Console.ReadLine(), out nValue))
            {
                Print("Please, enter a valid number");
                return false;
            }
            return true;
        }

        // 7) this method to check if the number is even or not
        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        // 8) this method to calculate the sum of all even numbers from 1 to n
        static long SumEven(int number)
        {
            long nSum = 0;
            int nCounter = 1;
            while (nCounter <= number)
            {
                if(IsEven(nCounter))
                {
                    nSum += nCounter;
                    nCounter++;
                    continue;
                }
                nCounter++;    
            }
            return nSum;
        }
        #endregion


        #endregion

    }
}