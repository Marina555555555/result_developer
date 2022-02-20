int N = 4;
string[] arr = new string[4]
{
    "hello", "2", "world", ":-)"
};
string[] arrRes = new string[4];

int index = 0;
int indexRes = 0;

while (index < N)
{
    if (arr[index].Length <= 3)
    {
        arrRes[indexRes] = arr[index];
        indexRes++;
    }

    index++;
}

Console.WriteLine("Исходный массив");
PrintArray(arr);
Console.WriteLine("Результируюший массив");
PrintArray(arrRes);


// Функция для вывода массива на экран
void PrintArray(string[] col)
{
    int count = col.Length;
    int position = 0;

    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}