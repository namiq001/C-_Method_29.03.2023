
internal class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine(Compare(10, 20));
        //onsole.WriteLine("6-ya kimi tek ededler cemi: " + SumOdd(6));
        //Console.WriteLine("1000-ya kimi tek ededler cemi: " + SumOdd(1000));
        //PrintStart(15,15);
        //Console.WriteLine("iki ededin cemi " + Sum(10,20));
        //Console.WriteLine("Array vasitesi ile cem: " + Arr_Sum(1,2,3,4,5,6,7,8,9));
        //Console.Write("Verilmis eded: 123"); sade(123);
        //Console.WriteLine("Mertebe sayi: " + say(1234));
        //Console.WriteLine("Hem 3-e hem 7-e bolunen edelerin cemi: " + bolunen(29, 100));
        //Praktikada etdiklerimizin Method vasitesi ile helli
        //Console.WriteLine("Iki eded arasinda kok alti: " + Kvadrar(3,500));
        //Console.WriteLine("Array max-in ekrana ver: " + Arr_Max(1, 2, 3, 4, 5, 6, 7, 8, 9));
        //Console.WriteLine("Array 2-ci max-in ekrana ver: " + Arr_Max2(1, 2, 3, 4, 5, 6, 7, 8, 9));
    }
    static int Compare(int x, int y)
    {
        if (x > y)
        {
            return x;
        }
        else
        {
            return y;
        }
        // return y;
    }
    static int SumOdd(int number)
    {
        int sum = 0;
        for (int i = 0; i < number; i++)
        {
            if (i % 2 != 0)
            {
                sum += i;
            }
        }
        return sum;
    }
    static void PrintStart(int number1, int number2)
    {
        for (int i = 0; i < number1; i++)
        {
            for (int j = 0; j < number2; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    static int Sum(int number1, int number2)
    {
        int result = number1 + number2;
        return result;
    }
    static int Arr_Sum(params int[] numbers)
    {
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }
    static int sade(int number)
    {
        int say = 0;
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                say++;
            }
        }
        if (say == 2)
        {
            Console.WriteLine("eded sadedi:");
        }
        else
        {
            Console.WriteLine("eded murekkebdi");
        }
        return say;
    }
    static int say(int number)
    {

        int sum = 0;
        while (number > 0)
        {
            number /= 10;
            sum++;
        }
        return sum;
    }
    static int bolunen(int number1, int number2)
    {
        int cem = 0;
        for (int i = number1; i <= number2; i++)
        {
            if (i % 3 == 0 && i % 7 == 0)
            {
                cem += i;
            }
        }
        return cem;
    }
    static int Kvadrar (int number1, int number2)
    {
        int hasil = 1;
        for(int i=number1; i*i<number2; i++)
        {
            hasil = i * i;
        }
        return hasil; 
    }
    static int Arr_Max (params int[] numbers)
    {
        int max = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];   
            }
        }
        return max;
    }
    static int Arr_Max2 (params int[] numbers)
    {
        int max = numbers[0];
        int max2 = max;
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max2 = max;
                max = numbers[i];
            }
            else if (numbers[i] > max2)
            {
                max2 = numbers[i];
            }
        }
        return max2;
    }
}