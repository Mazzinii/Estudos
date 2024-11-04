 static IEnumerable<string> FriendOrFoe (string[] names) {
   //using LINQ
   return names.Where(x => x.Length == 4).ToList();
   
   /*
   List<string> nameList = [];
   foreach(var name in names){
        if(name.Length == 4){
            nameList.Add(name);
        }
   }
   return nameList; 
   */
  }
FriendOrFoe(new []{"Ryan", "Kieran", "Jason", "Yous"});