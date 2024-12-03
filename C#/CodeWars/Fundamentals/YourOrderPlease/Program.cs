

static string Order(string words)
  {
    return string.Join(" ", words.Split(" ").OrderBy(word => word.ToList().FirstOrDefault(c => Char.IsDigit(c))));
  }
  Order("is2 Thi1s T4est 3a");