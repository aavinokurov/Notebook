using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notebook
{
    class Program
    {

        /// <summary>
        /// Notebook (array of workers)
        /// </summary>
        static Worker[] workers = new Worker[3];

        static void Main(string[] args)
        {
            Console.WriteLine($"{"First worker: ",66}"); // Entering data for the first worker
            workers[0] = WriteNote();
            Console.Clear();

            Console.WriteLine($"{"Second worker: ", 66}"); // Entering data for the second worker
            workers[1] = WriteNote();
            Console.Clear();

            Console.WriteLine($"{"Third worker: ", 66}"); // Entering data for the third worker
            workers[2] = WriteNote();
            Console.Clear();

            Console.WriteLine($"{"First worker: ", 66}"); // Data output for the first worker
            Console.WriteLine("Name: " + workers[0].Name + "\n" +
                              "Age: "  + workers[0].Age  + "\n" +
                              "Height: " + workers[0].Height + "\n" +
                              "Russian language scores: " + workers[0].RusLanScore + "\n" +
                              "History scores: " + workers[0].HistoryScore + "\n" +
                              "Math scores: " + workers[0].MathScore + "\n" +
                              "Average score: " + workers[0].AverageScore.ToString("#.##"));
            Console.WriteLine(); // Splitting the output to the console

            Console.WriteLine($"{"Second worker: ",66}"); // Data output for the second worker
            Console.WriteLine("Name: {0} \nAge: {1} \nHeight: {2} \nRussian language scores: {3} \nHistory scores: {4} \nMath scores: {5} \nAverage score: {6}",
                              workers[1].Name,
                              workers[1].Age,
                              workers[1].Height,
                              workers[1].RusLanScore,
                              workers[1].HistoryScore,
                              workers[1].MathScore,
                              workers[1].AverageScore.ToString("#.##"));
            Console.WriteLine(); // Splitting the output to the console

            Console.WriteLine($"{"Third worker: ",66}"); // Data output for the third worker
            Console.WriteLine($"Name: {workers[2].Name} \nAge: {workers[2].Age} \nHeight: {workers[2].Height} \nRussian language scores: {workers[2].RusLanScore} \nHistory scores: {workers[2].HistoryScore} \nMath scores: {workers[2].MathScore} \nAverage score: {workers[2].AverageScore:#.##}");
        }

        /// <summary>
        /// Write worker in notebook
        /// </summary>
        static Worker WriteNote()
        {
            // Reading the name from the console
            Console.WriteLine("Enter your name: "); // Write variable
            string name = Console.ReadLine(); // Reading the variable from the console
            while (string.IsNullOrEmpty(name)) // Checking the variable for correctness
            {
                Console.WriteLine("Enter your name correctly!");  // Please enter the variable correctly
                name = Console.ReadLine(); // Reading the variable from the console
            }

            // Reading the age from the console
            Console.WriteLine("Enter your age: "); // Write variable
            int age = Convert.ToInt32(Console.ReadLine()); // Reading the variable from the console
            while (age <= 18 || age >= 80) // Checking the variable for correctness
            {
                Console.WriteLine("Enter your age correctly!");  // Please enter the variable correctly
                age = Convert.ToInt32(Console.ReadLine()); // Reading the variable from the console
            }

            // Reading the height from the console
            Console.WriteLine("Enter your height[cm]: "); // Write variable
            double height = Convert.ToDouble(Console.ReadLine()); // Reading the variable from the console
            while (height <= 80 || height >= 300) // Checking the variable for correctness
            {
                Console.WriteLine("Enter your height correctly!");  // Please enter the variable correctly
                height = Convert.ToDouble(Console.ReadLine()); // Reading the variable from the console
            }

            // Reading the Russian language scores from the console
            Console.WriteLine("Enter your Russian language scores: "); // Write variable
            int rusLanScore = Convert.ToInt32(Console.ReadLine()); // Reading the variable from the console
            while (rusLanScore < 0 || rusLanScore > 100) // Checking the variable for correctness
            {
                Console.WriteLine("Enter your Russian language scores correctly!");  // Please enter the variable correctly
                rusLanScore = Convert.ToInt32(Console.ReadLine()); // Reading the variable from the console
            }

            // Reading the history scores from the console
            Console.WriteLine("Enter your history scores: "); // Write variable
            int historyScore = Convert.ToInt32(Console.ReadLine()); // Reading the variable from the console
            while (historyScore < 0 || historyScore > 100) // Checking the variable for correctness
            {
                Console.WriteLine("Enter your history scores correctly!");  // Please enter the variable correctly
                historyScore = Convert.ToInt32(Console.ReadLine()); // Reading the variable from the console
            }

            // Reading the math scores from the console
            Console.WriteLine("Enter your math scores: "); // Write variable
            int mathScore = Convert.ToInt32(Console.ReadLine()); // Reading the variable from the console
            while (mathScore < 0 || mathScore > 100) // Checking the variable for correctness
            {
                Console.WriteLine("Enter your math scores correctly!");  // Please enter the variable correctly
                mathScore = Convert.ToInt32(Console.ReadLine()); // Reading the variable from the console
            }

            return new Worker(name, age, height, rusLanScore, historyScore, mathScore); // Create worker
        }
    }
}
