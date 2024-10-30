
static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable) 
  {
    var set = new List<T>();
   
    foreach(var item in iterable){
      //checking if the last item is diferent than current item
      if(item.Equals(set.LastOrDefault())){
        set.Add(item);
      }
        
    }
    return set;   
  }
  System.Console.WriteLine(UniqueInOrder("ABBCcAD"));
    





