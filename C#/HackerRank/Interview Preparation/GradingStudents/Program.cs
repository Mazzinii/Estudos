class Result
{

    /*
     * Complete the 'gradingStudents' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY grades as parameter.
     */

    public static List<int> gradingStudents(List<int> grades)
    {
        List<int> result = new List<int>();

        foreach (int grade in grades) 
        {
            if (grade >= 38)
            {
                int calc = (int)Math.Ceiling(grade / 5.0) * 5;
                if ((calc - grade) < 3) result.Add(calc);
                else result.Add(grade);
            }
            else result.Add(grade);
        }

        return grades;
    }

    class Solution
    {
        public static void Main(string[] args)
        {
            gradingStudents([4, 73, 67,38,33]);
        }

    }
}


