

static List<string> wave(string str)
{
   List<string> result = new List<string>();
   int count = 0;

   foreach(char ch in str){  
    result.Add(str.Remove(count, 1).Insert(count,char.ToUpper(ch).ToString()));
    count++;
   }
   result.RemoveAll(x => x == str);
   return result;
}

wave(" gap ");

