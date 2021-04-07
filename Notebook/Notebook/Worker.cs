using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notebook
{
    /// <summary>
    /// A class for determining the worker, including name, 
    /// age, height, Russian language scores, history scores 
    /// and math scores.
    /// </summary>
    class Worker
    {
        /// <summary>
        /// Worker's name
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Worker's age
        /// </summary>
        public int Age { get; private set; }

        /// <summary>
        /// Worker's height
        /// </summary>
        public double Height { get; private set; }

        /// <summary>
        /// Worker's Russian language scores
        /// </summary>
        public int RusLanScore { get; private set; }

        /// <summary>
        /// Worker's history scores
        /// </summary>
        public int HistoryScore { get; private set; }

        /// <summary>
        /// Worker's math scores
        /// </summary>
        public int MathScore { get; private set; }

        /// <summary>
        /// Worker's average score
        /// </summary>
        public double AverageScore { get; private set; }

        /// <summary>
        /// A constructor that allows you to assign 
        /// a value to the corresponding fields of the employee
        /// </summary>
        /// <param name="name">Worker's name</param>
        /// <param name="age">Worker's age</param>
        /// <param name="height">Worker's height</param>
        /// <param name="rusLanScore">Worker's Russian language scores</param>
        /// <param name="historyScore">Worker's history scores</param>
        /// <param name="mathScore">Worker's math scores</param>
        public Worker(string name, int age, double height, int rusLanScore, int historyScore, int mathScore)
        {
            this.Name = name;                   // Save the passed name value
            this.Age = age;                     // Save the passed age value
            this.Height = height;               // Save the passed height value
            this.RusLanScore = rusLanScore;     // Save the passed Russian language scores value
            this.HistoryScore = historyScore;   // Save the passed history scores value
            this.MathScore = mathScore;         // Save the passed math scores value
            this.AverageScore = (this.RusLanScore + this.HistoryScore + this.MathScore) / (double)3; // Calculating the average score
        }
    }
}
