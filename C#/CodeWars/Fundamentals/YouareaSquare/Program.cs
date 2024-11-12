static bool IsSquare(int n)
  {
    double square = Math.Sqrt(n);
    return Math.Floor(square) != square || n < 0 ? false : true;

    /*OR(verifica se o numero tem ou nao parte decimal caso haja o valor será diferente de 0)
    return Math.Floor(n) % 1 == 0;
    */
  }
  IsSquare(4);