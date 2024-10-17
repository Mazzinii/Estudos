  static int CountSheeps(bool[] sheeps)
  {
    return sheeps.Where(x => x == true).Count();
  }

System.Console.WriteLine(CountSheeps([true,  true,  true,  false,
  true,  true,  true,  true ,
  true,  false, true,  false,
  true,  false, false, true ,
  true,  true,  true,  true ,
  false, false, true,  true]));

  // output : 17