 static string seriesSum (int n) {
    double result = 0;
    double denominador = 1;
    for(int i = 1; i <= n; i++){
      result += 1 / denominador;
      denominador += 3;
    }
    return result.ToString("0.00");
 }
 seriesSum(9);