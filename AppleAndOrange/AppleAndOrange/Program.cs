using System;

var apples = new List<int> { 2, 3, -4 };
var oranges = new List<int> { 3, -2, -4 };

Result.countApplesAndOranges(7, 10, 4, 12, apples, oranges);

class Result
{
    public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
    {
        int contApple = 0;
        int contOrange = 0;

        foreach (int i in apples)
        {
            if (i + a >= s && i + a <= t)
            {
                contApple++;
            }
        }

        foreach (int i in oranges)
        {
            if (i + b >= s && i + b <= t)
            {
                contOrange++;
            }
        }

        Console.WriteLine(contApple);
        Console.WriteLine(contOrange);

    }

}

