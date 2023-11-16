using System;
using Microsoft.VisualBasic;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using System.Linq;

public class po
{
    /*public static void Main(string[] args)
    {*/
    /*Console.WriteLine("Глава 1, 1 Задание");
    Console.WriteLine("Введите имя пользователя");
    string b = Console.ReadLine();
    Console.WriteLine("Введте фамилию пользователя");
    string a = Console.ReadLine();
    Console.WriteLine(b + " " + a);

    Console.WriteLine("Задание 2");

    Console.WriteLine("Введите имя пользователя");
    string b = Console.ReadLine();
    Console.WriteLine("Введте возраст пользователя");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine(b + " " + a + " " + "Лет");

    Console.WriteLine("Задание 3");
    *
    Console.WriteLine("Введите день недели");
    string a = Console.ReadLine();
    Console.WriteLine("Введите дату и название месяца");
    string b = Console.ReadLine();
    Console.WriteLine(a + " " + b);

    Console.WriteLine("Задание 4");

    Console.WriteLine("Введите название месяца (в предложном падеже)");
    string a = Console.ReadLine();
    Console.WriteLine("Введите коичесвто дней в этом месяце");
    int b = int.Parse(Console.ReadLine());
    Console.WriteLine("В" + " " + a + " " + b + " дней");

    Console.WriteLine("Задание 5");

    Console.WriteLine("Введите год рождения");
    int a = int.Parse(Console.ReadLine());
    if (a > 2005)
    {
        Console.WriteLine("Я подсчитал и понял что тебе: " + (2023 - a) + " лет и ты мелкий чувак");
    }
    else
{
    Console.WriteLine("Я подсчитал и понял что тебе: " + (2023 - a) + " лет и ты здоровый мужчина");
}

Console.WriteLine("Задание 6");
Console.WriteLine("Введите имя пользователя");
string b = Console.ReadLine();
Console.WriteLine("Введите год рождения:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Тебя зовут " + b + " и тебе " + (2023 - a) + " лет");

Console.WriteLine("Задание 7");

Console.WriteLine("Введите сколько вам лет:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Вы родились в " + (2023 - a) + " году");

Console.WriteLine("Задание 8");

Console.WriteLine("Введите первое чилсо:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе чилсо:");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Ответ " + (a + b));

Console.WriteLine("Задание 9");
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Ответ " + (a - 1) + " " + a + " " + (a + 1));

Console.WriteLine("Задание 10");

Console.WriteLine("Введите первое чилсо:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе чилсо:");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Ответ " + (a + b));
Console.WriteLine("Ответ " + (a - b));

Console.WriteLine("Глава 2, 1 Задание");

Console.WriteLine("Введите чилсо:");
int a = int.Parse(Console.ReadLine());
if (a % 3 == 0)
{
    Console.WriteLine("Число " + a + " делится на 3");
}
else
    Console.WriteLine("Введите другое число которе делится 3");

Console.WriteLine("Задание 2");

Console.WriteLine("Введите число которое делится на 5");
int a = int.Parse(Console.ReadLine());
int b = 5; int c = 7;
Console.WriteLine("Ответ с остатком от 5 " + (a / b));
Console.WriteLine("Ответ с остатком от 7 " + (a / c));

Console.WriteLine("Задание 3");
*
Console.WriteLine("Введите число:");
int a = int.Parse(Console.ReadLine());
if (a >= 10)
{
    if (a % 4 == 0)
    {
        Console.WriteLine("Верно подобрал число и это число:" + " " + a);
    }
    else
        Console.WriteLine("Поменяй число потому, что твое число не делится на 4");
}
else
    Console.WriteLine("Твое число меньше 10 (советую его поменять)");

Console.WriteLine("Задание 4");

Console.WriteLine("Введите число:");
int a = int.Parse(Console.ReadLine());
if (a >= 5 && a <= 10)
{
    Console.WriteLine("Число подходит");

}
else
{
    Console.WriteLine("Введите число от 5 до 10");
}

Console.WriteLine("Задание 5");

Console.WriteLine("Введите число,а я вычислю сколько в нем тысяч");
int a = int.Parse(Console.ReadLine());
Console.WriteLine((a / 1000 % 10) + " тысяч");

Console.WriteLine("Задание 6");

Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
int b = (a & 56) >> 3;
Console.WriteLine("Вторая цифра восьмеричного представления числа: " + b);

Console.WriteLine("Задание 7");
*
Console.WriteLine("Введите число:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine((a >> 3) % 2);


Console.WriteLine("Задание 8");

Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
int n = 3;
a |= 1 << n;
Console.WriteLine(a);

Console.WriteLine("Задание 9");

Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
int n = 4;
a &= ~(1 << n);
Console.WriteLine(a);

Console.WriteLine("Задание 10");

Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
int n = 2;
a = a ^ (1 << n);
Console.WriteLine(a);

Console.WriteLine("Глава 3 Задание 1");

Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
if ((a % 3 == 0) && (a % 7 == 0))
{
    Console.WriteLine("Ответ" + " " + a);
}
else
{
    Console.WriteLine("Введите другое число");
}

Console.WriteLine("Задание 2");

Console.WriteLine("Введите первое число:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = int.Parse(Console.ReadLine());
if (a > b)
{
    Console.WriteLine("Первое число больше второго");
}
else if (a == b)
{
    Console.WriteLine("Оба числа равны");
}
else
    Console.WriteLine("Второе число больше первого");

Console.WriteLine("Задание 3");
var sum = 0;
var n = 0;
do
{
    Console.Write("Вводим число:");
    while (!int.TryParse(Console.ReadLine(), out n))
        Console.Write("Ответ: ");
    sum += n;
}
while (n != 0);
Console.WriteLine(sum);

Console.WriteLine("Задание 4");
Console.WriteLine("Введите день недели");
int a = int.Parse(Console.ReadLine());
if (a >= 1 && a <= 7)
{
    switch (a)
    {
        case 1:
            Console.WriteLine("Понедельник");
            break;

        case 2:
            Console.WriteLine("Вторник");
            break;

        case 3:
            Console.WriteLine("Среда");
            break;

        case 4:
            Console.WriteLine("Четверг");
            break;

        case 5:
            Console.WriteLine("Пятница");
            break;

        case 6:
            Console.WriteLine("Суббота");
            break;

        case 7:
            Console.WriteLine("Воскресенье");
            break;
    }
}
else
{
    Console.WriteLine("Введите число от 1 до 7");
}

Console.WriteLine("Задание 5");

Console.WriteLine("Введите день недели");
string a = Console.ReadLine();
if (a == "Понедельник")
{
    Console.WriteLine("1");
}
else if (a == "Вторник")
    Console.WriteLine("2");


else if (a == "Среда")
    Console.WriteLine("3");


else if (a == "Четверг")
    Console.WriteLine("4");


else if (a == "Пятница")
    Console.WriteLine("5");


else if (a == "Суббота")
    Console.WriteLine("6");


else if (a == "Воскресенье")
    Console.WriteLine("7");
else
{
    Console.WriteLine("Введите от Понедельника до Воскресенье");
}

Console.WriteLine("Задание 6");
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
int b = 0;
for (int i = 1; i <= a; i++)
{
    if (i % 2 != 0)
        b += 1;
}
Console.WriteLine("Сумма нечетных чисел " + b);

Console.WriteLine("Задание 7");
Console.WriteLine("Введите целое число");
int a = int.Parse(Console.ReadLine());
int r = 0;
for (int i = 1; i <= a; i++)
    r += Convert.ToInt32(Math.Pow(i, 2));
Console.WriteLine(r);

Console.WriteLine("Задание 8");
Console.WriteLine("Введите числа");
int n = int.Parse(Console.ReadLine());
int a = 1, b = 1;
for (int i = 3; i <= n; i++)
{
    int c = a + b;
    Console.WriteLine($"{c}");
    a = b;
    b = c;
}
Console.WriteLine();

Console.WriteLine("Задание 9");
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число");
int b = int.Parse(Console.ReadLine());
int c = Math.Min(a, b);
int g = Math.Max(a, b);
for (int i = c; i <= g; i++)
{
    Console.Write(i);
}

Console.WriteLine("Задание 10");

Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
int s = 0;
int c = 0;
for (int i = 1; c <= a; i++)
{
    if (i % 5 == 2 || i % 3 == 1)
    {
        Console.WriteLine($"{i}");
        s += i;
        c++;
    }
}
Console.WriteLine(s);*/

    /* Console.WriteLine("Глава 4 Задание 1");

     int b = int.Parse(Console.ReadLine());
     int[] a = new int[b];
     int k = 0;
     for (int i = 2; k < b; i += 5)
     {
         a[k] = i;
         k++;
     }
     Console.WriteLine("masiv");
     foreach (int num in a)
     {
         Console.WriteLine(num + " ");
     }*/
    /*Console.WriteLine("Задание 2");

    Console.Write("Введите размер массива: ");
    int size = int.Parse(Console.ReadLine());
    int[] a = new int[size];
    int powerOfTwo = 1;
    for (int i = 0; i < size; i++)
    {
        a[i] = powerOfTwo;
        powerOfTwo *= 2; // увеличиваем степень двойки с каждой итерацией
    }
    Console.Write("Массив в прямом порядке: ");
    foreach (int num in a)
    {
        Console.Write(num + " ");
    }
    Console.WriteLine();

    // печатаем массив в обратном порядке
    Console.Write("Массив в обратном порядке: ");
    for (int i = size - 1; i >= 0; i--)
    {
        Console.Write(a[i] + " ");
}*/


    /* Console.WriteLine("Задание 3");

     // Задаем размер массива
     int размер = 10;

     // Создаем массив символов
     char[] массив = new char[размер];

     // Заполняем массив буквами "через одну" начиная с 'а'
     char буква = 'a';
     for (int i = 0; i < размер; i++)
     {
         массив[i] = буква;
         буква = (char)(буква + 2); // Увеличиваем букву на 2 для получения следующей буквы
     }

     // Выводим массив в прямом порядке
     Console.WriteLine("Массив в прямом порядке:");
     for (int i = 0; i < размер; i++)
     {
         Console.Write(массив[i] + " ");
     }
     Console.WriteLine();

     // Выводим массив в обратном порядке
     Console.WriteLine("Массив в обратном порядке:");
     for (int i = размер - 1; i >= 0; i--)
     {
         Console.Write(массив[i] + " ");
     }
     Console.WriteLine();
    */

    /*Console.WriteLine("Задание 4");

    char[] a = new char[10]; //пустой массив
    char g = 'B';
    for (int i = 0; i< 10; i++)
    {
        a[i] = g;
        g++;
        if (g == 'E')
        {
            g++;
        }
    if (g == 'I')
    {
        g++;
    }
        }
        for (int i = 0; i < 10; i++)
    {
        Console.Write(a[i] + " ");

    }
    Console.WriteLine();*/


    /*        Console.WriteLine("Задание 5");

            // Создаем генератор случайных чисел
            Random random = new Random();

            // Размер массива
            int ar = 10;

            // Создаем и заполняем массив случайными числами
            int[] a = new int[ar];
            for (int i = 0; i < ar; i++)
            {
                a[i] = random.Next(1, 101); // Здесь генерируются числа от 1 до 100
            }

            // Выводим массив в консоль
            Console.WriteLine("Массив:");
            for (int i = 0; i < ar; i++)
            {
                Console.WriteLine($"array[{i}] = {a[i]}");
            }

            // Находим минимальное значение
            int m = a[0];
            for (int i = 1; i < ar; i++)
            {
                if (a[i] < m)
                {
                    m = a[i];
                }
            }

            // Выводим минимальное значение и его индексы
            Console.WriteLine($"Минимальное значение: {m}");
            Console.Write("Индексы элементов с минимальным значением: ");
            for (int i = 0; i < ar; i++)
            {
                if (a[i] == m)
                {
                    Console.Write($"{i} ");
                }
            }

            Console.WriteLine(); // Переход на новую строку*/

    /* Console.WriteLine("Задание 6");

     int[] a = new int[10];
     Random random = new Random();
     for (int i = 0; i < a.Length; i++)
     {
         a[i] = random.Next(1, 100);
     }
     Array.Sort(a, (x, y) => y.CompareTo(x));
     foreach (int number in a)
     {
         Console.WriteLine(number + " ");
     }*/

    /*Console.WriteLine("Задание 7");

    char[] tArray = { 'P', 'i', 'U' };
    Array.Reverse(tArray);
    Console.WriteLine("Обратный массив");
    foreach (char e in tArray)
        {
        Console.WriteLine(e);
        }*/

    /*Console.WriteLine("Задание 8");

    int v = 3, s = 0;
    try
    {
        for (int i = 0; (v != 0); i++)
        {
            Console.WriteLine("Введите число \nВвод чисел заканчивается вводом 0");
            v = int.Parse(Console.ReadLine());
            if (v % 5 == 3 || v % 3 == 1)
            {
                Console.WriteLine("число = " + v + "+ ");
                s += v;
            }
        }
        Console.WriteLine("=" + s);
    }
    catch
    {
        Console.WriteLine("некорректное число");
    }
    Console.ReadKey();*/

    /*Console.WriteLine("Задание 9");

    int row, colum;
    Random r = new Random();
    Console.WriteLine("Введите число строк массива:");
    row = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число колонок массива:");
    colum = Convert.ToInt32(Console.ReadLine());
    int[,] arr = new int[colum, row];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = r.Next(50) + 1;
        }
    }
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }*/


    /*Console.WriteLine("Задание 10");

    int n = 4; // Задайте размер массива
    int[,] array = FillSpiralArray(n);

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    }

    static int[,] FillSpiralArray(int n)
    {
    int[,] result = new int[n, n];
    int num = 1;
    int left = 0, right = n - 1, top = 0, bottom = n - 1;

    while (left <= right && top <= bottom)
    {
        for (int i = left; i <= right; i++)
        {
            result[top, i] = num++;
        }
        top++;

        for (int i = top; i <= bottom; i++)
        {
            result[i, right] = num++;
        }
        right--;

        for (int i = right; i >= left; i--)
        {
            result[bottom, i] = num++;
        }
        bottom--;

        for (int i = bottom; i >= top; i--)
        {
            result[i, left] = num++;
        }
        left++;
    }

    return result;*/

    /*Console.WriteLine("Глава 5 задание 1"); // На пк номер 8 не работает задание


    Console.WriteLine("Двойной факториал числа.");
    Console.WriteLine(Fact1(6));

    static int Fact2(int n)
    {
        int result = 1;
        for (int i = n % 2 == 0 ? 2 : 1; i <= n; i += 2)
            result *= i;

        return result;
    }

    static int Fact1(int n)
    {
        if (n == 1)
            return 1;
        else
            return n * Fact1(n - 2);
    }*/

    /* Console.WriteLine("Задание 2");

     Console.WriteLine("Введите целое число");
     int a = int.Parse(Console.ReadLine());
     int r = 0;
     for (int i = 1; i <= a; i++)
         r += Convert.ToInt32(Math.Pow(i, 2));
     Console.WriteLine(r);*/

    /*Console.WriteLine("Задание 3");
    class program
    {
        static int[] TakeFirstNElements(int[] inputArray, int n)
        {
            if (n <= 0)
            {
                // Если n <= 0, возвращаем пустой массив
                return new int[0];
            }
            else if (n >= inputArray.Length)
            {
                // Если n >= длины входного массива, создаем копию входного массива
                int[] copyArray = new int[inputArray.Length];
                Array.Copy(inputArray, copyArray, inputArray.Length);
                return copyArray;
            }
            else
            {
                // В противном случае, создаем новый массив, содержащий первые n элементов из входного массива
                int[] r = new int[n];
                Array.Copy(inputArray, r, n);
                return r;
            }
        }
        class proogram
        {
            static void Main(string[] args)
            {
                int[] o = { 1, 2, 3, 4, 5 };
                int n = 3;

                int[] r = TakeFirstNElements(o, n);

                Console.WriteLine("Исходный массив: " + string.Join(", ", o));
                Console.WriteLine("Результат: " + string.Join(", ", r));
            }
        }*/

    /*private static void Main(string[] args)
    {
        Console.WriteLine("Задание 4");
    }
    static int[] ConvertToUnicode(char[] characters) {
    int[] unicodeArray = new int[characters.Length];
    for (int i = 0; i < characters.Length; i++) {
        unicodeArray[i] = characters[i];
    }
    return unicodeArray;
    }

    static void Main() {
    char[] charArray = {'a', 'b', 'c', 'd'};
    int[] unicodeArray = ConvertToUnicode(charArray);
    foreach (int element in unicodeArray) {
        Console.Write(element + " ");*/


    /* }
    }*/

    /*private static void Main(string[] args)
        {
            Console.WriteLine("Задание 5");

            double[] a = { 1, 2, 3, 4, 5, 6 };
            double sum = 0;
            for (int i = 0; i < a.Length; i++)
                sum += a[i];
            Console.WriteLine(sum / a.Length);
        }*/

    /*    private static void Main(string[] args)
        {
            Console.WriteLine("Задание 6");
        }*/

    /* static void showArray(int[,] nums)
     {
         for (int i = 0; i < nums.GetLength(0); i++)
         {
             for (int j = 0; j < nums.GetLength(1); j++)
             {
                 Console.Write(nums[i, j] + "\t");
             }
             Console.WriteLine();
         }
     }
     //Находим максимальный элемент в массиве и его индексы:
     static int Max(int[,] arr)
     {
         int max = 0, maxi = 0, maxj = 0;
         for (int i = 0; i < arr.GetLength(0); i++)
         {
             for (int k = 0; k < arr.GetLength(1); k++)
             {
                 if (max < arr[i, k])
                     max = arr[i, k]; maxi = i + 1; maxj = k + 1;
             }
         }
         return max;
     }

     static void Main()
     {
         int[,] A = { { 4, 5, 3 }, { 4, 2, 6 } };
         Console.WriteLine("Показываем исходный массив:");
         showArray(A);
         Console.WriteLine("Показываем максимальный элемент массива:");
         Console.WriteLine(Max(A));
     }*/

    /*private static void Main(string[] args)
    {
        Console.WriteLine("Задание 7");

        char[] arr = { 'h', 'e', 'l', 'l', 'o', '!' };
        Sort(arr);
        foreach (char ch in arr)
            Console.Write(ch + " ");

        Console.ReadKey();
    }

    static void Sort(char[] arr)
    {
        for (int i = 0; i < arr.Length / 2; i++)
        {
            char temp = arr[i];
            arr[i] = arr[arr.Length - i - 1];
            arr[arr.Length - i - 1] = temp;
        }
    }*/

    /*private static void Main(string[] args)
    {
        Console.WriteLine("Задание 8");

        object[] A = Foo('a', 'z');
        for (int i = 0; i < A.Length; i++)
            Console.WriteLine($" A[{i}]= {A[i]}");
    }
    static object[] Foo(int a, int b)
    {
        object[] nums;
        if (b < a)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }
        if (a != b)
        {
            int length = 0;
            for (int i = a; i <= b; i++)
                length++;
            nums = new object[length];

            int t = a;
            for (int i = 0; i < length; i++)
            {
                nums[i] = t;
                t++;
            }
            return nums;
        }
        else
        {
            nums = new object[2];
            nums[0] = a;
            nums[1] = b;
            return nums;
        }
    }
    static object[] Foo(char a, char b)
    {
        object[] nums;
        if (b < a)
        {
            char tmp = a;
            a = b;
            b = tmp;
        }
        if (a != b)
        {
            int length = 0;
            for (int i = a; i <= b; i++)
                length++;
            nums = new object[length];

            char t = a;
            for (int i = 0; i < length; i++)
            {
                nums[i] = t;
                t++;
            }
            return nums;
        }
        else
        {
            nums = new object[2];
            nums[0] = a;
            nums[1] = b;
            return nums;
        }
    }*/

    /*static void Main(string[] args)
    {
    Console.WriteLine("Задание 8");

        int[] result = FindMinMax(5, 10, 2, -3);
        Console.WriteLine("Максимальное значение: " + result[0]);
        Console.WriteLine("Минимальное значение: " + result[1]);
    }

    static int[] FindMinMax(params int[] numbers)
    {
        int min = int.MaxValue;
        int max = int.MinValue;

        foreach (int num in numbers)
        {
            if (num < min)
                min = num;

            if (num > max)
                max = num;
        }

        return new int[] { max, min };
    }*/

    /*static void Main(string[] args)
    {
        Console.WriteLine("Задание 9");

        int[] numbers = { 10, 5, 15, 20, 3 };
        int[] result = FindMinMax(numbers);

        Console.WriteLine("Наибольшее значение: " + result[0]);
        Console.WriteLine("Наименьшее значение: " + result[1]);
    }

    static int[] FindMinMax(params int[] numbers)
    {
        int min = int.MaxValue;
        int max = int.MinValue;

        foreach (int number in numbers)
        {
            if (number < min)
                min = number;

            if (number > max)
                max = number;
        }

        return new int[] { max, min };
    }*/

    /*static void Main()
    {
        Console.WriteLine("Задание 9");
        string originalText = "Hello";
        char[] characters = { ' ', 'W', 'o', 'r', 'l', 'd', '!' };

        string newText = Append(originalText, characters);

        Console.WriteLine(newText);
    }
    static string Append(string text, params char[] characters)
    {
        foreach (char c in characters)
        {
            text += c;
        }
        return text;
    }*/
}
/*class SymbolClass
{
    private char symbol;

    public void SetSymbol(char value)
    {
        symbol = value;
    }

    public int GetSymbolCode()
    {
        return (int)symbol;
    }

    public void PrintSymbolAndCode()
    {
        Console.WriteLine("Символ: " + symbol);
        Console.WriteLine("Код символа: " + (int)symbol);
    }
}

class Program
{
    static void Main(string[] args)
    {
        SymbolClass symbolObj = new SymbolClass();
        symbolObj.SetSymbol('A');

        int code = symbolObj.GetSymbolCode();
        Console.WriteLine("Код символа: " + code);

        symbolObj.PrintSymbolAndCode();
    }
}*/

/*class Maths
{
    // Метод вычисления факториала
    public static int Fact(int x)
    {
        int res = 1;
        for (int i = x; i >= 2; i--)
        {
            res *= i;
        }
        return res;
    }

    public static double Ch;

    // Метод вычисления косинуса
    public static double Cos(double Ch)
    {
        double Otv = 0;

        for (int i = 1; i <= 6; i++)
        {
            Otv += Math.Pow((-1), i) * Math.Pow(Ch, 2 * i) / Maths.Fact(2 * i);

        }
        Otv = 1 - Otv;
        return Otv;
    }
}*/
