using static System.Console;
Clear();

WriteLine("Введите массив через пробел: ");

string[] array = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

string[] result = new string[array.Length];

int count = 0;


for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        result[count] = array[i];
        count += 1;
    }
}


result = result[..^(array.Length - count)];

WriteLine();
WriteLine("Новый массив из строк, длина которых меньше или равна 3 : [{0}]", String.Join(",", result));
