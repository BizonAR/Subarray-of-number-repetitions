using System;

namespace SubarrayOfNumberRepetitions
{
	internal class SubarrayOfNumberRepetitions
	{
		static void Main(string[] args)
		{
			int arraySize = 30;
			int[] arrayNumbers = new int[arraySize];

			int maxValue = 100;
			Random random = new Random();

			for (int i = 0; i < arraySize; i++)
				arrayNumbers[i] = random.Next(maxValue + 1);

			int numberOccursMostOften = arrayNumbers[0];
			int countOfRepetitions = 1;
			int maxCountOfRepetitions = 1;

			for (int i = 1; i < arrayNumbers.Length; i++)
			{
				if (arrayNumbers[i] == arrayNumbers[i - 1])
				{
					countOfRepetitions++;

					if (countOfRepetitions > maxCountOfRepetitions)
					{
						maxCountOfRepetitions = countOfRepetitions;
						numberOccursMostOften = arrayNumbers[i];
					}
				}
				else
				{
					countOfRepetitions = 1;
				}
			}

			Console.Write("{");

			for (int i = 0; i < arrayNumbers.Length - 1; i++)
				Console.Write(arrayNumbers[i] + ", ");

			Console.Write(arrayNumbers[arrayNumbers.Length - 1] + "} - число " + numberOccursMostOften +
				" повторяется большее количество раз - " + maxCountOfRepetitions);
			Console.WriteLine();
		}
	}
}
