//Write a function that accepts an array of 10 integers (between 0 and 9), that returns a string of those numbers in the form of a phone number

//Example

// Kata.CreatePhoneNumber(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0})
// => returns "(123) 456-7890"


 static string CreatePhoneNumber(int[] numbers)
  {
    string ddd = $"({numbers[0]}{numbers[1]}{numbers[2]})";
    string firstNumber = $"{numbers[3]}{numbers[4]}{numbers[5]}";
    string secondNumber = $"{numbers[6]}{numbers[7]}{numbers[8]}{numbers[9]}";
    return $"{ddd} {firstNumber}-{secondNumber}";
  }

 System.Console.WriteLine(CreatePhoneNumber([1, 2, 3, 4, 5, 6, 7, 8, 9, 0]));
