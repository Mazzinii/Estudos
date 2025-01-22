 static List<int> closestNumbers( List<int> arr)
{
    List<int> values = arr.ToList();

    values.Sort();

    List<int> result = new List<int>();

    long lowestDiff = 10000000;
    long lower = 1000000000;

    for (int i = 0; i < values.Count - 1; i++)
        {
            lower = Math.Max(values[i],values[i+1]) - Math.Min(values[i], values[i + 1]);
            if (lower < lowestDiff)  lowestDiff = lower; 

        }

    for (int i = 0;  i < values.Count - 1; i++)
    {
        if (Math.Max(values[i], values[i + 1]) - Math.Min(values[i], values[i + 1]) == lowestDiff)
        {
            result.Add(values[i]);
            result.Add(values[i + 1]);
        }

    }
    result.Sort();
    return result;

}

closestNumbers([-5,15,25,71,63]);


