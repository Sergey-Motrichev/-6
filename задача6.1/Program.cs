//41. Пользователь вводит с клавиатуры М чисел.Посчитайте,сколько
// чисел больше 0 ввел пользователь.
// 0,7,8,-2,-2->2
// 1,-7,567,89,223->3

int[] GenerateArray (int length)
{
    var array =new int[length];
        for(var i=0;i<array.Length;i++)
        {
            array [i]=Convert.ToInt32(Console.ReadLine());
        }
    Console.WriteLine($"\nВведите {length} чисел:\n");
    return array;
}
void PrintArrey(int[]array)
{
    for(var i=0;i<array.Length-1;i++) 
    {
        Console.Write($"{array[i]}"+",");
    }
    Console.WriteLine("\nВведины числа\n");
}
int AltNumber(int[]number)
{
    int N=0;
    for(var i=0;i<number.Length;i++)
    {
        if (number[i]>0)
        N++;
    }
    return N;
}
int[]array= GenerateArray(6);
PrintArrey(array);
Console.WriteLine($"\n\nВыведены {AltNumber(array)} положительных числа:\n\n");
