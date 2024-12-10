using System.Security.Cryptography.X509Certificates;

class Solution
{
    static void Main(String[] args)
    {
        List<string> formattedText = new List<string>();

        while (true)
        {
            string userInput = Console.ReadLine();


            if (string.IsNullOrEmpty(userInput)) break;  

            string[] word = userInput.Split(';');
            string firstOperation = word[0];
            string secondOperation = word[1];
            string value = word[2];


            if (firstOperation == "S")
            {
                formattedText.Add(SplitCamelCase(secondOperation, value));
            }
            if (firstOperation == "C")
            {

                formattedText.Add(CombineCamelCase(secondOperation, value));
            }
        }

        printFormatedText(formattedText);

    }

        static string SplitCamelCase(string secondOperation, string value)
        {
            string result = String.Concat(value.Select(c => char.IsUpper(c) ? " " + char.ToLower(c) : c.ToString())).Replace("()", "");
            result = result.TrimStart();

            if (secondOperation == "M" && value.Contains("()")) value.Replace("()", "");

            return result;
        }

        static string CombineCamelCase(string secondOperation,string value) 
        {
            string[] vectwords = value.Split(' ');
            string result = "";
            

            foreach (string s in vectwords)
            { 
                string wordupper = char.ToUpper(s[0]).ToString();
                result += $"{s.Remove(0, 1).Insert(0, wordupper)}"; 
            }

            if (secondOperation == "M")  result = char.ToLowerInvariant(result[0]) + result.Substring(1) + "()"; ;

            if (secondOperation == "V") result = char.ToLowerInvariant(result[0]) + result.Substring(1);

            return result;
        }
        
        static void printFormatedText(List<string> formattedText) 
        {
           foreach(string text in formattedText) 
            {
                Console.WriteLine(text);
            }
        }

}
