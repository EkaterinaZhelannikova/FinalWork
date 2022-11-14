Console.Clear();
string[] array = new string[6] {"hello", "cat", "2022", ":-)", "Russia", "13"};
string[] resultArray = FillResultArray(array);
Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", resultArray)}]");

int CountElementsLessThreeChar(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    return count;
}

string[] FillResultArray(string[] array)
{
    string[] resultArray = new string[CountElementsLessThreeChar(array)];
    for(int i = 0, j = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            resultArray[j] = array[i];
            j++;
        }
    }
    return resultArray;
}