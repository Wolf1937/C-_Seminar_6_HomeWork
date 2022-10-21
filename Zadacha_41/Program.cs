// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.Write("Выберите способ решения 1 или 2: ");
int w = int.Parse(Console.ReadLine()!);
if (w == 1) Way1();
if (w == 2) Way2();
else
    Console.WriteLine("Такого решения не существует!");


void Way1()
{
    Console.Write("Введите колличество чисел: ");
    int n = int.Parse(Console.ReadLine()!);
    int count = 0;
    for (int i = 0; i < n; i++)
    {
        Console.Write($"Введите число {i + 1}: ");
        int x = int.Parse(Console.ReadLine()!);
        if (x > 0)
            count++;
    }
    Console.WriteLine($"Положительных чисел: {count}");
}

void Way2()
{
    Console.Write("Введите числа через точку с запятой: ");
    int[] array = StringToNum(Console.ReadLine()!);
    PrintArray(array);
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sum++;
        }
    }
    
    Console.WriteLine($"Введено {sum} чисел больше 0.");

    int[] StringToNum(string input)
    {
        int count = 1;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == ';')
            {
                count++;
            }
        }

        int[] array = new int[count];
        int index = 0;

        for (int i = 0; i < input.Length; i++)
        {
            string temp = "";

            while (input[i] != ';')
            {
                if (i != input.Length - 1)
                {
                    temp += input[i].ToString();
                    i++;
                }
                else
                {
                    temp += input[i].ToString();
                    break;
                }
            }
            array[index] = Convert.ToInt32(temp);
            index++;
        }
        return array;
    }


    void PrintArray(int[] array)
    {
        Console.WriteLine($"Заданный массив: [{String.Join(", ", array)}]");
    }
}