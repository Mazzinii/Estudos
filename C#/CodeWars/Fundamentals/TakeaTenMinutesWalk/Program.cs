
static bool IsValidWalk(string[] walk)
  {
    if(walk.Length != 10) return false;
    int x = 0;
    int y = 0;

    foreach(string str in walk){
      switch(str){
        case "n":
          y += 1;
          break;
        case "s":
          y -= 1;
          break; 
        case "e":
          x += 1;
          break;
        case "w":
          x -= 1;
          break; 
      }
    }
      return  x == 0 && y == 0;  
  }

IsValidWalk(["n","n","n","s","n","s","n","s","n","s"]);