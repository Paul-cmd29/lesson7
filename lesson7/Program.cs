using System;

class Lesson7
{
    public static void Main()
    {
        compareString(out _);
        AnalyzeString("Paul is student of Beetroot Academy!");
        SortMethod("Paul is student of Beetroot Academy!");

    }

    public static void compareString(out bool result)
    {
        Console.WriteLine("введите первую строку:");
        var one = Console.ReadLine();
        Console.WriteLine("Введите вторую строку:");
        var two = Console.ReadLine();
        if (one == two)
        {
            result = true;

        } 
        
        else
        {
            result = false;

        }
        
            

        Console.WriteLine(result);
        

    }
    public static void AnalyzeString(string str)
    {
        int digit = 0;
        int lower = 0;
        int letter = 0;
        int other = 0;

        for (int i = 0; i < str.Length; i++)
        {
            if (Char.IsDigit(str[i]))
            {
                digit++;
            }
            else if (Char.IsLower(str[i]))
            {
                lower++;
            }
            else if (Char.IsLetter(str[i]))
            {
                letter++;
            }
            else
            {
                other = str.Length - digit - lower - letter;
            }
        }

        Console.WriteLine($"Digit is {digit}");
        Console.WriteLine($"Lower is {lower}");
        Console.WriteLine($"Letter is {letter}");
        Console.WriteLine($"Other char is {other}");


    }
    public static void SortMethod(string str1)
    {
        char[] array = str1.ToCharArray();
        Array.Sort(array);
        Console.WriteLine(String.Join(" ", array)); 
    }
}
