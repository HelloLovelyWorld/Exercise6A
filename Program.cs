using System;

namespace DoingArrayExerciseWithDan
{
    class Program
    {
        static int getArraySum (int[] numbers)
        {
            int sum = 0;

            foreach (var x in numbers)
            {
                sum += x;
            }

            return sum;
        }
        static double getArrayAverage(int[] numbers) => (double) getArraySum(numbers) / (double)numbers.Length;

        static void printReverseArray(int[] numbers)
        {
            for (int i = numbers.Length - 1; i > 0; i--)
            {
                Console.Write($"{numbers[i]}, ");
            }
            Console.WriteLine(numbers[0]);
        }
        static int[] reverseArray(int[] numbers)
        {
            int[] backwards = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                backwards[i] = numbers[numbers.Length - 1 - i];
            }
            return backwards;
        }

        static void printArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                Console.Write($"{numbers[i]}, ");
            }
            Console.WriteLine(numbers[numbers.Length - 1]);
        }

        static int[] rotateArray(string direction, int nrSteps, int[] numbers)
        {
            int[] rotated = new int[numbers.Length];

            if (direction.ToLower() == "left")
            {
                nrSteps = -nrSteps;
            }
            return rotateArray(nrSteps, numbers);
        }
     
        static int[] rotateArray(int nrSteps, int[] numbers)
        {
            int[] rotated = new int[numbers.Length];

            if (nrSteps < 1) nrSteps += numbers.Length;
            for (int i = 0; i < numbers.Length; i++)
            {
                rotated[(i+nrSteps) % numbers.Length] = numbers[i];
            }
            return rotated;
        }
        static void testMethodsForEx6A()
        {
            int[][] myNumbers = new int[][] {
            new int[] { 0, 2, 4, 6, 8, 10 },
            new int[] { 1, 3, 5, 7, 9 },
            new int[] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 }
            };
            for (int i = 0; i < myNumbers.Length; i++)
            {
                // 0.
                Console.Write($"Array{i + 1}: ");
                printArray(myNumbers[i]);
                // Part 1:
                Console.WriteLine($"Get Average {i + 1}: {getArrayAverage(myNumbers[i])}");
                // Part 2:
                Console.Write($"Reversed Array{i + 1}: ");
                printReverseArray(myNumbers[i]);
                // Part 2a:
                Console.WriteLine($"Reversed (The Sequel!!!): ");
                printArray(reverseArray(myNumbers[i]));
                //Part 3:
                Console.WriteLine($"Rotated (2>>): ");
                printArray(rotateArray("right",1, myNumbers[i]));
                // seperator between each sample array
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            testMethodsForEx6A();
        }
    }
}
