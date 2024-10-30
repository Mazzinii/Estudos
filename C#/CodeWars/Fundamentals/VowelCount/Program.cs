 static int GetVowelCount(string str)
    {
        int vowelCount = 0;
        List<char> vowel = new List<char>(){'a','e','i','o','u'};

        foreach(char ch in str){
           if(vowel.Contains(ch)){
            vowelCount++;
           } 
        }
        return vowelCount;

        /* using Linq
        return str.Count(i => "aeiou".Contains(i));
        */
    }

System.Console.WriteLine(GetVowelCount("abracadabra"));