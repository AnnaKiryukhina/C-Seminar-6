// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}


void CountPositivNumbers(int[] array, out int countPos)
{
    countPos = 0;
   
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >0) 
        {
            countPos = countPos +1; 
        }
        
    }
}

int[] NumberArray(string text)
{
    System.Console.WriteLine(text);
    return  Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
}


int[] myarray = NumberArray("Введите несколько положительных и отрицательных чисел");
PrintArray(myarray);
CountPositivNumbers(myarray, out int countPos);
System.Console.WriteLine($"Количество положительных чисел: {countPos}");





// int Size(string text)
// {
//     System.Console.WriteLine(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int n = Size("Введите число: ");

// int[] GenerateArray( int n)
// {
//     var rand = new Random();
//     var array = new int[n];

//     for (int i = 0; i < n; i++)
//     {
//         array[i] = rand.Next(-100, 100 + 1);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     System.Console.WriteLine("[" + string.Join(", ", array) + "]");
// }


// var myArray = GenerateArray(n);
// PrintArray(myArray);