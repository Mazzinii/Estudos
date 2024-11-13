 static string[] TowerBuilder(int nFloors)
  {
    string[] tower = new string[nFloors];
    int quant = 1;
    int quantSpace = nFloors - 1;
    for(int i = 0; i < nFloors; i++){
        string caracter = new string('*', quant);
        string space = new string(' ', quantSpace);
        tower[i] = space + caracter + space;
        quantSpace--;
        quant += 2;
      }
    return tower;
  }
  TowerBuilder(6);