

static int binaryArrayToNumber(int[] BinaryArray)
{   
    string binaryNumber = "";
    foreach(int binary in BinaryArray) binaryNumber += binary;
    return Convert.ToInt32(binaryNumber,2);
}
System.Console.WriteLine(binaryArrayToNumber([1, 1, 1, 1]));
