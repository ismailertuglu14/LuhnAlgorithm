using System;

class Program
{
    const int CardLength = 16;
    const int ValidationNumber = 80;

    static void Main()
    {
        int[] cardNumbers = new int[CardLength] { 4, 1, 3, 7, 8, 9, 4, 7, 1, 1, 7, 5, 5, 9, 0, 4 };
        int totalSum = CalculateCardSum(cardNumbers);

        if (IsValidCardNumber(totalSum))
            Console.WriteLine("Valid Card Number");
        else
            Console.WriteLine("Not Valid Card Number");

        Console.Read();
    }

    static int CalculateCardSum(int[] numbers)
    {
        int total = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            int currentNumber = numbers[i];

            if (i % 2 == 0)
                currentNumber = DoubleAndSumDigitsIfNeeded(currentNumber);

            total += currentNumber;
        }

        return total;
    }

    static int DoubleAndSumDigitsIfNeeded(int number)
    {
        number *= 2;

        if (number >= 10)
            number = SumOfDigits(number);

        return number;
    }

    static int SumOfDigits(int number)
    {
        int sum = 0;

        while (number != 0)
        {
            sum += number % 10;
            number /= 10;
        }

        return sum;
    }

    static bool IsValidCardNumber(int totalSum)
    {
        return totalSum == ValidationNumber;
    }
}
