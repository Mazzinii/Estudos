 static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
   {    
       //using Oftype to return only int
       return listOfItems.OfType<int>();
   }
