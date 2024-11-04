 static double FindAverage(double[] array)
  { 
   return array.Length == 0 ?  0 : (double)array.Average();
  }

  FindAverage([17, 16, 16, 16, 16, 15, 17, 17, 15, 5, 17, 17, 16]);
