int size = 0;

string[] CreateArray(int size)
{
string[] newArray = new string[size];

for(int i=0; i < size; i++)
{
    Console.WriteLine("Введите строку ");
    newArray[i] = Console.ReadLine();
}
return newArray;
}

void ShowArray(string[] array)
{
    Console.Write("[ ");
    for(int i=0; i < array.Length; i++)
    {
        Console.Write(array[i]+" ");
    }
    Console.Write("]");
}

string[] CutArray(string[] array)
{

int count = 0;

for(int i = 0; i<size;i++)
{
    int lenStr=array[i].Length;

    if(lenStr <= 3)
        {
            count++;
        }
}

string[] newArray = new string[count];

int tmp = 0;

for(int i = 0; i<size;i++)
{
    int lenStr=array[i].Length;

    if(lenStr <= 3)
        {
            newArray[tmp]=array[i];
            tmp++;
        }
}
Console.WriteLine();
return newArray;
}

Console.WriteLine( "Задайте размер массива " );
size = Convert.ToInt32(Console.ReadLine());
string[] array = CreateArray(size);
Console.WriteLine( "Введеный массив " );
ShowArray(array);
string[] cutArray = CutArray(array);
Console.WriteLine( "Результирующий массив ");
ShowArray(cutArray);