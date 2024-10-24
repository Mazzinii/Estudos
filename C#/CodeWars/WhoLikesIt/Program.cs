 static string Likes(string[] name)
  {
    switch (name.Length)
    {
        case 0:
            return $"no one likes this";
        case 1:
             return $"{name[0]} likes this";
        case 2:
            return $"{name[0]} and {name[1]} like this";     
        case 3:
            return $"{name[0]}, {name[1]} and {name[2]} like this";     
        default:
            return $"{name[0]}, {name[1]} and {name.Length -2} others like this";
    }
    /* or expression
        
    return name.Length switch
    {
        0 => $"no one likes this",
        1 => $"{name[0]} likes this",
        2 => $"{name[0]} and {name[1]} like this",
        3 => $"{name[0]}, {name[1]} and {name[2]} like this",
        _ => $"{name[0]}, {name[1]} and {name.Length - 2} others like this",
    };
    */
}

  System.Console.WriteLine(Likes(["Alex", "Jacob", "Mark", "Max"]));
