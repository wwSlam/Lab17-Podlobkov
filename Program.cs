int[] scores = { 60, 80, 40, 80, 90 };

Console.WriteLine(Sum(scores));
Console.WriteLine(Max(scores));
Console.WriteLine(Min(scores));
Console.WriteLine(Count50(scores));
Console.WriteLine(Fint(scores));
Console.WriteLine(CountAtLeast(new int[] { 40, 50, 80 }, 50));
Console.WriteLine(FindIndex(scores, 80));
Console.WriteLine(FindIndex(scores, 60));
Console.WriteLine(FindIndex(scores, 100));

int Sum(int[] scores)
{
    int sum = 0;
    for (int i = 0; i < scores.Length; i++)
    {
        sum += scores[i];
    }
    return sum;
}

int Max(int[] scores)
{
    int max = scores[0];
    for (int f = 0; f < scores.Length; f++)
    {
        if (max < scores[f])
        {
            max = scores[f];
        }
    }
    return max;
}

int Min(int[] scores)
{
    int min = scores[0];
    for (int d = 0; d < scores.Length; d++)
    {
        if (min > scores[d])
        {
            min = scores[d];
        }
    }
    return min;
}

int Count50(int[] scores)
{
    int count50 = 0;
    for (int s = 0; s < scores.Length; s++)
    {
        if (scores[s] >= 50)
        {
            count50++;
        }
    }
    return count50;
}

int Fint(int[] scores)
{
    for (int h = 0; h < scores.Length; h++)
    {
        if (scores[h] == 80)
        {
            return h;
        }
    }
    return -1;
}

int CountAtLeast(int[] numbers, int limit)
{
    int count = 0;

    foreach (int number in numbers)
    {
        if (number >= limit)
        {
            count ++;
        }
    }

    return count;
}

int FindIndex(int[] numbers, int target)
{
    int index = -1;

    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] == target)
        {
            index = i;
        }
    }

    return index;
}