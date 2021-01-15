using System;

namespace Csharp_array
{
    class Program
    {

        static int GetHighestScore(int[] scores)
        {
            int highestScore = 0;
            foreach (int score in scores)
            {
                if (score > highestScore)
                {
                    highestScore = score;
                }
            }
            return highestScore;
        }
        static int GetAverageScore(int[] scores)
        {
            int avg = 0;
            foreach (int score in scores)
            {
                avg += score;
            }

            avg /= scores.Length;
            return avg;
        }
        static int GetIndexOf(int[] scores, int value)
        {
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }
        static void Sort(int[] scores)
        {

        }
        static void Main(string[] args)
        {
            int[] scores = new int[5] { 10, 30, 40, 50, 20 };

            int highestScore = GetHighestScore(scores);
            Console.WriteLine(highestScore);

            int averageScore = GetAverageScore(scores);
            Console.WriteLine(averageScore);

            int indexOfValue = GetIndexOf(scores, 20);
            Console.WriteLine(indexOfValue);

            Sort(scores);
        }
    }
}
