using System;
using System.Collections.Generic;
using System.Text;

namespace educational_app
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
        }

        static void HomeWork3()
        {
            Console.WriteLine("Type your surname:");
            string surname = Console.ReadLine();

            Console.WriteLine("Type your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Type your age:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Type your weight in kg:");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Type your height in meters:");
            double height = double.Parse(Console.ReadLine());

            double BMI = weight / (height * height);
            Console.WriteLine($"Your profile: \nFull name: {surname}{name}\nAge: {age}\nWeight: {weight}\nHeight: {height}\nBMI: {BMI}");
        }

        static void HomeWork2()
        {
            Console.WriteLine("Type first line of triangle:");
            double line1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Type first line of triangle:");
            double line2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Type first line of triangle:");
            double line3 = double.Parse(Console.ReadLine());

            double per = (line1 + line2 + line3) / 2;

            double geron = Math.Sqrt(per * (per - line1) * (per - line2) * (per - line3));
            Console.WriteLine($"The square of triangle is {geron}");
        }

        static void HomeWork1()
        {
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");

            Console.WriteLine();

            Console.WriteLine("Type first integer number:");
            string num1 = Console.ReadLine();
            int x = int.Parse(num1);

            Console.WriteLine("Type second integer number:");
            string num2 = Console.ReadLine();
            int y = int.Parse(num2);

            y = int.Parse(num1);
            x = int.Parse(num2);
            Console.WriteLine($"Now first number is {x} and second is {y}");

            Console.WriteLine("Write any integer number");
            string number = Console.ReadLine();
            int length = number.Length;
            Console.WriteLine($"Quantity of your \"number\" is {length}");
        }

        static void ItroToDateTime()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now);

            Console.WriteLine($"It's {now.Date}, {now.Hour}:{now.Minute}");

            DateTime dt = new DateTime(2016, 2, 28);
            DateTime dtNew = dt.AddDays(1);
            Console.WriteLine(dtNew);

            TimeSpan ts = now - dt;
            //ts = now.Subtract(dt);
            Console.WriteLine(ts.Days);
        }

        static void IntroToArrays()
        {
            int[] a1;
            a1 = new int[10];

            int[] a2 = new int[5];

            int[] a3 = new int[5] { 1, 3, -2, 5, 10 };

            int[] a4 = { 1, 3, 2, 4, 5 };

            Console.WriteLine(a4[0]);

            int number = a4[4];
            Console.WriteLine(number);

            a4[4] = 6;
            Console.WriteLine(a4[4]);

            Console.WriteLine(a4.Length);
            Console.WriteLine(a4[a4.Length - 1]);

            string str = "abcdefgh";
            char first = str[0];
            char last = str[str.Length - 1];

            Console.WriteLine($"First \"{first}\". Last \"{last}\".");
        }

        static void MathDemo()
        {
            Console.WriteLine(Math.Pow(2, 3));
            Console.WriteLine(Math.Sqrt(9));
            Console.WriteLine(Math.Sqrt(8));

            Console.WriteLine(Math.Round(1.7));
            Console.WriteLine(Math.Round(1.4));
            Console.WriteLine(Math.Round(1.5));
        }

        static void CastingAndParsing()
        {
            byte b = 3; //0000 0011
            int i = b; //0000 0000 0000 0000 0000 0000 0000 0011
            long l = i; //0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0011

            float f = i;
            Console.WriteLine(f);

            b = (byte)i;
            Console.WriteLine(b);

            i = (int)f;
            Console.WriteLine(i);

            f = 3.1f;
            i = (int)f;
            Console.WriteLine(i);

            string str = "1";
            i = int.Parse(str);
            Console.WriteLine($"Parsed i={i}");

            int x = 5;
            int result = x / 2;
            Console.WriteLine(result);

            double result2 = (double)x / 2;
            Console.WriteLine(result2);
        }

        static void ConsoleBasics()
        {
            Console.WriteLine("Hi, please tell me your name");
            string name = Console.ReadLine();
            string sentence = $"Your name is {name}";
            Console.WriteLine(sentence);

            Console.WriteLine("Please, tell me yor age");
            string input = Console.ReadLine();
            int age = int.Parse(input);

            sentence = $"Yor name is {name} and you {age} years old";
            Console.WriteLine(sentence);

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write("New Style ");
            Console.Write("New style\n");
        }

        static void ComparingStrings()
        {
            //string str1 = "abcde";
            //string str2 = "abcde";
            //bool areEqual = str1 == str2;
            //Console.WriteLine(areEqual);

            //areEqual = string.Equals(str1, str2, StringComparison.Ordinal);
            //Console.WriteLine(areEqual);

            string str1 = "Strasse";
            string str2 = "Straße";

            bool areEqual = string.Equals(str1, str2, StringComparison.Ordinal);
            Console.WriteLine(areEqual);

            areEqual = string.Equals(str1, str2, StringComparison.InvariantCulture);
            Console.WriteLine(areEqual);

            areEqual = string.Equals(str1, str2, StringComparison.CurrentCulture);
            Console.WriteLine(areEqual);
        }

        static void StringFormat()
        {
            string name = "John";
            int age = 30;
            string str1 = string.Format("My name is {0} and I'm {1}", name, age);
            string str2 = $"My name is {name} and I'm {age}";
            string str3 = "My name is \n John";
            string str4 = "I'm \t30";
            string str5 = $"My name is {Environment.NewLine} John";
            string str6 = "I'm John and I'm a \"good\" programmer";
            string str7 = "C:\\programm files\\file.txt";
            string str8 = @"C:\\programm files\\file.txt";

            int answer = 42;
            string result = string.Format("{0:d}", answer);
            string result2 = string.Format("{0:d4}", answer);


            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(str3);
            Console.WriteLine(str4);
            Console.WriteLine(str5);
            Console.WriteLine(str6);
            Console.WriteLine(str7);
            Console.WriteLine(str8);

            Console.WriteLine(result);
            Console.WriteLine(result2);

            result = string.Format("{0:f}", answer);
            result2 = string.Format("{0:f4}", answer);

            Console.WriteLine(result);
            Console.WriteLine(result2);

            double answ = 36.66;

            result = string.Format("{0:f}", answ);
            result2 = string.Format("{0:f4}", answ);

            Console.WriteLine(result);
            Console.WriteLine(result2);

            Console.OutputEncoding = Encoding.UTF8;

            double money = 11.8;
            result = string.Format("{0:C}", money);
            result2 = string.Format("{0:C2}", money);
            Console.WriteLine(money.ToString("C2"));
            Console.WriteLine(result2);

            result = $"{money:C2}";
        }

        static void StringBuilderDemo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("My ");
            sb.Append("name ");
            sb.Append("is ");
            sb.Append("John");
            sb.AppendLine("!");
            sb.AppendLine("Hello!");

            string str = sb.ToString();
            Console.WriteLine(str);
        }

        static void StringModification()
        {
            string nameConcat = string.Concat("My ", "name ", "is ", "John ");
            Console.WriteLine(nameConcat);

            nameConcat = string.Join(" ", "My", "name", "is", "John");
            Console.WriteLine(nameConcat);

            nameConcat = "My " + "name " + "is " + "John ";

            //string newName = 
            nameConcat = nameConcat.Insert(0, "By the way, ");
            Console.WriteLine(nameConcat);

            nameConcat = nameConcat.Remove(0, 1);
            Console.WriteLine(nameConcat);

            string replaced = nameConcat.Replace('n', 'z');
            Console.WriteLine(replaced);

            string data = "12;28;36;64;";
            string[] splitData = data.Split(';');
            string first = splitData[0];
            Console.WriteLine(first);

            char[] chars = nameConcat.ToCharArray();
            Console.WriteLine(chars[0]);
            Console.WriteLine(nameConcat[0]);

            string lower = nameConcat.ToLower();
            Console.WriteLine(lower);

            string upper = nameConcat.ToUpper();
            Console.WriteLine(upper);

            string john = " My name is John ";
            Console.WriteLine(john.Trim());
        }

        static void StringEmptiness ()
        {
            string str = string.Empty;

            string empty = "";
            string whiteSpaced = " ";
            string notEmpty = " b";
            string nullString = null;

            Console.WriteLine("IsNullOrEmpty");
            bool isNullOrEmpty = string.IsNullOrEmpty(nullString);
            Console.WriteLine(isNullOrEmpty);

            isNullOrEmpty = string.IsNullOrEmpty(whiteSpaced);
            Console.WriteLine(isNullOrEmpty);

            isNullOrEmpty = string.IsNullOrEmpty(notEmpty);
            Console.WriteLine(isNullOrEmpty);

            isNullOrEmpty = string.IsNullOrEmpty(empty);
            Console.WriteLine(isNullOrEmpty);

            Console.WriteLine();
            Console.WriteLine("IsNullOrWhiteSpace");

            bool isNotOrWhiteSpace = string.IsNullOrWhiteSpace(nullString);
            Console.WriteLine(isNotOrWhiteSpace);

            isNotOrWhiteSpace = string.IsNullOrWhiteSpace(whiteSpaced);
            Console.WriteLine(isNotOrWhiteSpace);

            isNotOrWhiteSpace = string.IsNullOrWhiteSpace(notEmpty);
            Console.WriteLine(isNotOrWhiteSpace);

            isNotOrWhiteSpace = string.IsNullOrWhiteSpace(empty);
            Console.WriteLine(isNotOrWhiteSpace);
        }

        static void QueryingStrings()
        {
            string name = "abracadabra";
            bool containsA = name.Contains('a');
            bool containsE = name.Contains('E');

            Console.WriteLine(containsA);
            Console.WriteLine(containsE);

            bool endsWithAbra = name.EndsWith("abra");
            Console.WriteLine(endsWithAbra);

            bool startsWithAbra = name.StartsWith("abra");
            Console.WriteLine(startsWithAbra);

            int indexOfA = name.IndexOf('a', 1);
            Console.WriteLine(indexOfA);

            int lastIndexOfR = name.LastIndexOf('r');
            Console.WriteLine(lastIndexOfR);

            Console.WriteLine(name.Length);

            string substrFrom5 = name.Substring(5);
            string substrFromTo = name.Substring(0, 3);

            Console.WriteLine(substrFrom5);
            Console.WriteLine(substrFromTo);
        }

        static void StaticAndInstaticMembers()
        {
            string name = "abracadabra";
            bool containsA = name.Contains('a');
            bool containsE = name.Contains('e');

            Console.WriteLine(containsA);
            Console.WriteLine(containsE);

            string abc = string.Concat("a", "b", "c");
            Console.WriteLine(abc);

            int x = 1;
            string xStr = x.ToString();
            Console.WriteLine(xStr);
            Console.WriteLine(x);
        }

        static void Compare_Methods()
        {
            int x = 1;
            int y = 2;

            bool areEqual = x == y;
            Console.WriteLine(areEqual);

            bool result = x > y;
            Console.WriteLine(result);

            result = x >= y;
            Console.WriteLine(result);

            result = x < y;
            Console.WriteLine(result);

            result = x <= y;
            Console.WriteLine(result);

            result = x != y;
            Console.WriteLine(result);
        }

        static void SimpleMathOperations ()
        {
            int x = 1;
            int y = 2;

            int z = x + y;
            int k = x - y;

            int a = z + k - y;

            Console.WriteLine(z);
            Console.WriteLine(k);
            Console.WriteLine(a);

            int b = z * 2;
            int c = k / 2;

            Console.WriteLine(b);
            Console.WriteLine(c);

            a = 4 % 2;
            b = 5 % 2;

            Console.WriteLine(a);
            Console.WriteLine(b);

            a = 3;
            a = a * a;
            //a = a * a * a;
            Console.WriteLine(a);

            a = 2 + 2 * 2;
            Console.WriteLine(a);

            a *= 2;
            Console.WriteLine(a);

            a /= 2;
            Console.WriteLine(a);

        }

        static void IncrDecrDemo()
        {
            int x = 1;
            x = x + 1;

            Console.WriteLine(x);

            x++;
            Console.WriteLine(x);

            ++x;
            Console.WriteLine(x);

            x = x - 1;
            x--;
            --x;
            Console.WriteLine(x);

            Console.WriteLine("Learn about increments");
            Console.WriteLine($"Last x state is {x}");

            int j = x++;
            Console.WriteLine(j);
            Console.WriteLine(x);

            j = ++x;
            Console.WriteLine(j);
            Console.WriteLine(x);

            x += 2;
            //equals x = x + 2;
            Console.WriteLine(x);

            j -= 2;
            //equals j = j - 2;
            Console.WriteLine(j);
        }

        static void Overflow()
        {
            checked
            {
                uint x = uint.MaxValue;

                Console.WriteLine(x);

                x = x + 1;

                Console.WriteLine(x);

                x = x - 1;

                Console.WriteLine(x);
            }
        }

        static void VariablesScope()
        {

            var a = 1;
            {
                var b = 1;
                {
                    var c = 1;
                    Console.WriteLine(a);
                    Console.WriteLine(b);
                    Console.WriteLine(c);
                }

                //Console.WriteLine(c); переменная "c" не видна в области переменной "b"
            }
        }

        static void Literals()
        {
            int x = 0b11;
            int y = 0b1001;
            int k = 0b10001001;
            int m = 0b1000_1001;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(k);
            Console.WriteLine(m);

            x = 0x1F;
            y = 0xFF0d;
            k = 0x1FAB30EF;
            m = 0x1FAB_30EF;

            Console.WriteLine();

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(k);
            Console.WriteLine(m);

            Console.WriteLine();

            Console.WriteLine(4.5e2);
            Console.WriteLine(3.1E-1);

            Console.WriteLine();

            Console.WriteLine('\x78'); //вывод символо в консоли через 
            Console.WriteLine('\x5A');

            Console.WriteLine('\u0420'); //вывод символов в консоли через юникод
            Console.WriteLine('\u0421');
        }

        static void Variables()
        {
            int x = -1;

            int y;
            y = 2;

            //Int32 x1 = -1;

            //uint z = -1;

            float f = 1.1f;

            double d = 2.3;

            int x2 = 0;
            int x3 = new int();

            var a = 1;
            var b = 1.2;

            //Dictionary<int, string> dict = new Dictionary<int, string > ();
            //var dict = new Dictionary<int, string>();

            //var v;

            decimal money = 3.0m;

            char @char = 'A';
            string name = "Daniil";

            bool canDrive = true;
            bool canDraw = false;

            object obj1 = 1;
            object obj2 = "obj2";

            Console.WriteLine(a);
            Console.WriteLine(name);
        }
    }
}
