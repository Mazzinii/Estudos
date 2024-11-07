

static int find_it(int[] seq) 
      {
      return seq.GroupBy(x => x) //Group numbers that are the same                      
                .Where(g => g.Count() % 2 != 0) //Filter Groups that have odd ocurrance
                .Select(g => g.Key) //Return value of Group
                .FirstOrDefault();  //Return the first or default value                 
      }

find_it([0,1,0,1,0]);