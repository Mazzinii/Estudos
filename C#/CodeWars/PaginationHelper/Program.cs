using PaginationHelper.Entities;

var helper = new PaginationHelper<char>(['a', 'b', 'c', 'd', 'e', 'f'], 4);
System.Console.WriteLine(helper.PageIndex(6));

int[] numbersArray = [1,2,3,4];
List<int> numbersList = [1,2,3,4];

System.Console.WriteLine(numbersArray[0]);
System.Console.WriteLine(numbersList.Remove(1));
System.Console.WriteLine(numbersList[0]);


