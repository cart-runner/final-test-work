string[] arr1 = new string[5] {"turbo", "mazda", "rx7", "mig", "night"};
string[] arr2 = new string[arr1.Length];
void ArrayThreeChar(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void OutputArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
ArrayThreeChar(arr1, arr2);
OutputArray(arr2);