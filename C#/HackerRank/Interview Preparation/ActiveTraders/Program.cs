 static List<string> mostActive(List<string> customers)
    {
        double maxOcurrance = customers.Count * 0.05;
        var names = customers.Distinct();
        List<string> result = [];
        
        foreach(string name in names){
            if(customers.Count(x => x == name) >= maxOcurrance){
                result.Add(name);
            }
        }
        result.Sort();
        return result;

        /*Linq
        var result = customers
            .GroupBy(name => name)
            .Where(group => group.Count() >= maxOcurrance) // Filtra os que atendem ao limite
            .Select(group => group.Key) // Seleciona apenas os nomes
            .OrderBy(name => name) // Ordena em ordem alfabética
            .ToList();

        return result;
        */
        
    }

mostActive(["Bigcorp", "Bigcorp", "Acme", "Bigcorp", "Zork", "Zork",
"Abc", "Bigcorp", "Acme", "Bigcorp", "Bigcorp", "Zork", "Bigcorp",
"Zork", "Zork", "Bigcorp", "Acme", "Bigcorp", "Acme", "Bigcorp",
"Acme", "Littlecorp", "Nadircorp"]);    



