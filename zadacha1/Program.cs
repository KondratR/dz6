// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223->

int[] EnterNumbers()
{
    System.Console.WriteLine("Введите числа : ");
    int[] array = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
    return array;
}

int Positive(int[] array)
{
    int SumPositive = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            SumPositive++;
    }
    return SumPositive;
}
void PrintResultSum(int [] result)
{
    System.Console.WriteLine("Кол-во чисел больше 0 равняется: " + Positive(result));
}
int [] nova= EnterNumbers();
PrintResultSum(nova);