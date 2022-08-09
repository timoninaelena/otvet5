//  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int [] array = GitArray(4);
Console.Write($"[{String.Join("," , array)}]");
int[] GitArray(int size)

{
    int[] result = new int[size];
    for (int i=0; i< result.Length; i++)
    {
        result[i] = new Random().Next(-100,100);
    }
    return result;
}

int sum = 0;
for (int i = 0; i < array.Length; i+=2)
    {
        sum = sum +array[i];
    }
   
Console.WriteLine ($" Сумма элементов на нечетных позициях = {sum}");