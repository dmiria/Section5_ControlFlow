using System;

namespace Section5_ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {

            multipleOfThree();
            sumOfNumbers();
            factorialMethod();
            randomGuess1();
            randomGuess2();
        }   
   
         /** Exercise 1
          * Write a program to count how many numbers between 1 and 100 are 
          * divisible by 3 with no remainder. Display the count on the console.
         **/
        public static void multipleOfThree()
        {
           
            var finalValue = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    finalValue++;
                }
            }
            Console.WriteLine("There are {0} numbers between 1 and 100 that are divisible by 3.", finalValue);

        }

        /** Exercise 2
             * Write a program and continuously ask the user to enter a number or 
             * "ok" to exit. Calculate the sum of all the previously entered numbers 
             * and display it on the console.
             * */
        public static void sumOfNumbers()
        {
            var totalValue = 0;
            while (true)
            {
                Console.Write("Enter a number or enter ok to end program:");
                var userInputSum = Console.ReadLine();
                //var totalValue = 0;


                if (userInputSum != "ok")
                {
                    totalValue += Convert.ToInt32(userInputSum);
                    //Console.WriteLine("The sum of previously entered values is {0}", totalValue);
                }
                else
                {
                    Console.WriteLine("The sum of previously entered values is {0}", totalValue);
                    break;

                }

            }
        }

        /** Exercise 3
        *  Write a program and ask the user to enter a number. Compute the factorial 
        *  of the number and print it on the console. For example, if the user enters 
        *  5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
      * */
        public static void factorialMethod()
        {
            Console.Write("Enter a number to calculate its factorial:");
            var userInputFact = Convert.ToInt32(Console.ReadLine());
            var finalFactorial = 1;
            for (int i = userInputFact; i > 0; i--)
            {
                finalFactorial *= i;

            }
            Console.WriteLine("{0}! = {1}", userInputFact, finalFactorial);
        }

        /**
            * Exercise 4: 1st Attempt
            * 
            * Write a program that picks a random number between 1 and 10. Give the user 4 
            * chances to guess the number. If the user guesses the number, display “You won"; 
            * otherwise, display “You lost". (To make sure the program is behaving correctly, 
            * you can display the secret number on the console first.)
            * */
        public static void randomGuess1()
        {
            var randomInt = new Random().Next(1, 11);
            Console.WriteLine("The random number is: {0}", randomInt);
            var counter = 0;
            while (true)
            {
                Console.Write("Guess the random number: ");
                var userRandomInput = Convert.ToInt32(Console.ReadLine());
                if (counter == 3)
                {
                    //Console.WriteLine("The counter is: " + counter);
                    Console.WriteLine("You Lost");
                    break;
                }
                else if (userRandomInput == randomInt)
                {
                    //Console.WriteLine("The counter is: " + counter);
                    Console.WriteLine("You won");
                    break;
                }
                else if (userRandomInput != randomInt)
                {
                    counter++;
                    //Console.WriteLine("The counter is: " + counter);
                }
            }  
        }

        /**
         * Exercise 4: 2nd Attempt
         * 
         * Write a program that picks a random number between 1 and 10. Give the user 4 
         * chances to guess the number. If the user guesses the number, display “You won"; 
         * otherwise, display “You lost". (To make sure the program is behaving correctly, 
         * you can display the secret number on the console first.)
         * */
        public static void randomGuess2()
        {           
            var randomInt2 = new Random().Next(1, 11); //I used 11 because 10 will be inclusive now.
            Console.WriteLine("The random number is: {0}", randomInt2);
            //var counter = 0;
            while (true)
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.Write("Guess the random number: ");
                    var userRandomInput2 = Convert.ToInt32(Console.ReadLine());
                    if (userRandomInput2 == randomInt2)
                    {
                        Console.WriteLine("You Won");
                        break;
                    }
                    else if (userRandomInput2 != randomInt2 && i == 3)
                    {
                        Console.WriteLine("You lost");
                        break;
                    }
                }
                break;
            }
        }

        /** Exercise 5
        * Write a program and ask the user to enter a series of numbers separated by 
        * comma. Find the maximum of the numbers and display it on the console. For 
        * example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
        **/
        public static void commaSeparateList()
        {
            Console.WriteLine("Enter a series of numbers separated by comma.");
            var userStrInput = Console.ReadLine();
            var userStrArr = userStrInput.Split(',');
            var maxVal = Convert.ToInt32(userStrArr[0]); //assumes the first value is max
            foreach (var val in userStrArr)
            {
                var intVal = Convert.ToInt32(val);
                if (intVal > maxVal)
                {
                    maxVal = intVal;
                }
            }
            Console.WriteLine("The maximum value is {0}", maxVal);
        }
    }

}

