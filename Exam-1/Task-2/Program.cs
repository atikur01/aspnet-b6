Console.Write("Enter String: ");

var arr = Console.ReadLine().ToCharArray();


Console.WriteLine();
Console.Write("Enter Count: ");
var count = int.Parse( Console.ReadLine() );

for (int i = 1; i <= count; i++)
{
    for (int j = 0; j < arr.Length-1; j++)
    {
        var temp = arr[j];
        arr[j] = arr[j + 1];
        arr[j + 1] = temp;
    }

}

Console.WriteLine(arr);
