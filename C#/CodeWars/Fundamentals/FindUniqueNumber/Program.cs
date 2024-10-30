


static int GetUnique(IEnumerable<int> numbers)
  {
   List<int> result = new();

   foreach(var number in numbers){
    if(!result.Contains(number)){
        result.Add(number);
    }
    else{
        result.Remove(number);
    }
   }
    return result[0];
    /*
    return numbers.GroupBy(x=>x).Single(x=> x.Count() == 1).Key
    */
  }

  System.Console.WriteLine(GetUnique([ 1, 1, 1, 2, 1, 1 ]));
