using System;

namespace B_ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static void SwithCase()
        {
            int month = int.Parse(Console.ReadLine());

            string season = string.Empty;

            switch (month)
            {
                case 1:
                case 2:
                case 12:
                    season = "Зима";
                    break;

                case 3:
                case 4:
                case 5:
                    season = "Весна";
                    break;

                case 6:
                case 7:
                case 8:
                    season = "Лето";
                    break;

                case 9:
                case 10:
                case 11:
                    season = "Осень";
                    break;

                default:
                    throw new ArgumentException("Unexpected number of month");
            }

            Console.WriteLine(season);

            Console.ReadLine();

            int weddingYears = int.Parse(Console.ReadLine());

            string name = string.Empty;

            switch (weddingYears)
            {
                case 5:
                    name = "Деревянная свадьба";
                    break;
                case 10:
                    name = "Оловянная свадьба";
                    break;
                case 15:
                    name = "Хрустальная свадьба";
                    break;
                case 20:
                    name = "Фарфоровая свадьба";
                    break;
                case 25:
                    name = "Серебрянная свадьба";
                    break;
                case 30:
                    name = "Жемчужная свадьба";
                    break;
                default:
                    name = "Не знаем такого юбилея";
                    break;
            }
            Console.WriteLine(name);
        }

        static void BreakContinue()
        {
            int[] numbers = { 0, 6, 5, 3, 4, 2, 1, 7, 8, 9 };

            foreach (int n in numbers)
            {
                if (n % 2 != 0)
                    continue;
                Console.WriteLine(n);
            }

            Console.ReadLine();


            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Number={numbers[i]}");

                for (int j = 0; j < letters.Length; j++)
                {
                    if (numbers[i] == j)
                        break;
                    Console.Write($" {letters[j]} ");
                }
                Console.WriteLine();
            }



            Console.ReadLine();

            int[] numbers2 = { 1, -2, 4, -7, 5, 3, 2, -1, -3, 2, 7, -1, -3, 1, 7 };

            int counter = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (counter == 3)
                    break;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int atI = numbers[i];
                    int atJ = numbers[j];

                    if (atI + atJ == 0)
                    {
                        Console.WriteLine($"Pair ({atI};{atJ}). Indexes ({i};{j})");
                        counter++;
                    }
                    if (counter == 3)
                        break;
                }

            }
        }

        static void WhileDoWhile()
        {
            int age = 30;

            while (age < 18)
            {
                Console.WriteLine("First while loop");
                Console.WriteLine("What is your age?");
                age = int.Parse(Console.ReadLine());
            }

            do
            {
                Console.WriteLine("Do\\While");
                Console.WriteLine("What is your age?");
                age = int.Parse(Console.ReadLine());
            }

            while (age < 18);

            int[] numbers = { 1, 2, 3, 4, 5 };
            int i = 0;

            while (i < numbers.Length)
            {
                Console.WriteLine(numbers[i] + " ");
                i++;
            }
            Console.WriteLine("Good!");
        }

        static void NestedFor()
        {
            int[] numbers = { 1, -2, 4, -7, 5, 3, 2, -1, -3, 2, 7, -1, -3, 1, 7 };
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int atI = numbers[i];
                    int atJ = numbers[j];

                    if (atI + atJ == 0)
                    {
                        Console.WriteLine($"Pair ({atI};{atJ}). Indexes ({i};{j})");
                    }
                }
            }

            Console.WriteLine();

            for (int i = 0; i < numbers.Length - 2; i++)
            {
                for (int j = i + 1; j < numbers.Length - 1; j++)
                {
                    for (int k = j + 1; k < numbers.Length; k++)
                    {
                        int atI = numbers[i];
                        int atJ = numbers[j];
                        int atK = numbers[k];

                        if (atI + atJ + atK == 0)
                        {
                            Console.WriteLine($"triplets ({atI};{atJ};{atK}). Indexes ({i};{j};{k})");
                        }
                    }

                }
            }
        }

        static void ForForEach()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();

            for (int j = numbers.Length - 1; j >= 0; j--)
            {
                if (numbers[j] % 2 == 0)
                {
                    Console.Write(numbers[j] + " ");
                }
            }

            Console.WriteLine();

            for (int j = numbers.Length - 1; j >= 0; j--)
            {
                if (numbers[j] % 2 != 0)
                {
                    Console.Write(numbers[j] + " ");
                }
            }


            Console.WriteLine();

            foreach (int val in numbers)
            {
                Console.Write(val + " ");
            }
        }

        static void HomeWorkGetMax()
        {
            Console.WriteLine("Type two integer numbers:");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            string highestNum = num1 > num2 ? "Number 1 is the biggest" : "Number 2 is the biggest";
            Console.WriteLine(highestNum);
        }

        static void If_Else()
        {
            Console.WriteLine("Type your age:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Type your weight in kg:");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Type your height in meters:");
            double height = double.Parse(Console.ReadLine());

            double BMI = weight / (height * height);
            Console.WriteLine($"Your profile: \nAge: {age}\nWeight: {weight}\nHeight: {height}\nBMI: {BMI}");

            bool isTooLow = BMI <= 18.5;
            bool isNormal = BMI > 18.5 && BMI < 25;
            bool isAboveNormal = BMI >= 25 && BMI <= 30;
            bool isTooFat = BMI > 30;

            bool isFat = isAboveNormal || isTooFat;

            if (isFat)
            {
                Console.WriteLine("You'd better lose some weight");
            }
            else
            {
                Console.WriteLine("Oh, you're in a good shape");
            }

            if (!isFat)
            {
                Console.WriteLine("You're definetely not fat!");
            }

            if (isTooLow)
            {
                Console.WriteLine("Not enougn weight");
            }
            else if (isNormal)
            {
                Console.WriteLine("You're OK");
            }
            else if (isAboveNormal)
            {
                Console.WriteLine("Be careful");
            }
            else
            {
                Console.WriteLine("You need to lose some weight");
            }
            if (isFat || isTooFat)
            {
                Console.WriteLine("Anyway it's time to get on diet");
            }
            string description = age > 18 ? "You can drink alcohol and smoke cigarettes" : "You shoul get a bit older";
            Console.WriteLine(description);
        }
    }
}
