using static System.Console;
using static System.Math;

namespace GradingApp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double total = 0;
            int numberOfScores = 5;
            double average;
            int[] scoresArray = { 34, 3, 32, 18, 231 };
            foreach (double val in scoresArray)
                total += val;
            average = Round(total / numberOfScores, 2);
            WriteLine("  Grading App");
            WriteLine("");
            WriteLine("Score #1:  {0}", scoresArray[0]);
            WriteLine("Score #2:  {0}", scoresArray[1]);
            WriteLine("Score #3:  {0}", scoresArray[2]);
            WriteLine("Score #4:  {0}", scoresArray[3]);
            WriteLine("Score #5:  {0}", scoresArray[4]);
            WriteLine("");
            WriteLine("");
            WriteLine("Average:   {0:F}", average);
            }
        }
        }