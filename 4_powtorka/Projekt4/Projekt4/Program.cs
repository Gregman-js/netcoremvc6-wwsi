using System;

class Program
{
    static void Main()
    {
        Rozgrzewka();
        Operatory();
        InstrukcjeIPetle();
        Kolekcje();
    }

    private static void Kolekcje()
    {
        // Zadanie 1
        {
            string[] colors = { "niebieski", "zielony", "czerwony", "żółty" };

            Console.WriteLine("Mój pierwszy kolor to: " + colors[0]);
            Console.WriteLine("Mój ostatni kolor to: " + colors[colors.Length - 1]);
        }
        
        // Zadanie 2
        {
            int[] numbers = { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };

            // Pętla for
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Liczba: " + numbers[i]);
            }

            // Pętla foreach
            foreach (int number in numbers)
            {
                Console.WriteLine("Liczba: " + number);
            }

            // Pętla while
            int j = 0;
            while (j < numbers.Length)
            {
                Console.WriteLine("Liczba: " + numbers[j]);
                j++;
            }
        }
        
        // Zadanie 3
        {
            List<string> fruits = new List<string> { "Pomidor", "Jabłko", "Marchewka" };

            Console.WriteLine(string.Join(", ", fruits));

            fruits.RemoveAt(0);
            fruits.Remove(fruits[fruits.Count - 1]);

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
        }
    }

    private static void InstrukcjeIPetle()
    {
        // Zadanie 1
        {
            int n1 = 10;
            int n2 = 20;

            if (n1 > n2)
            {
                Console.WriteLine("n1 jest większe od n2");
            }
            else if (n1 < n2)
            {
                Console.WriteLine("n2 jest większe od n1");
            }
            else
            {
                Console.WriteLine("n1 jest równe n2");
            }
        }
        
        // Zadanie 2
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("C#");
            }
        }
        
        // Zadanie 3
        {
            int n = 10;

            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " - Parzysta");
                }
                else
                {
                    Console.WriteLine(i + " - Nieparzysta");
                }
            }
        }
        
        // Zadanie 4
        {
            int n = 5;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        
        // Zadanie 5
        {
            int exam = 75;
            string grade;

            switch (exam)
            {
                case int n when (n >= 0 && n <= 39):
                    grade = "Niedostateczna";
                    break;
                case int n when (n >= 40 && n <= 54):
                    grade = "Dopuszczająca";
                    break;
                case int n when (n >= 55 && n <= 69):
                    grade = "Dostateczna";
                    break;
                case int n when (n >= 70 && n <= 84):
                    grade = "Dobra";
                    break;
                case int n when (n >= 85 && n <= 98):
                    grade = "Bardzo Dobra";
                    break;
                case int n when (n >= 99 && n <= 100):
                    grade = "Celująca";
                    break;
                default:
                    grade = "Wartość poza zakresem";
                    break;
            }

            Console.WriteLine("Ocena: " + grade);
        }
    }

    private static void Operatory()
    {
        // Zadanie 1
        {
            int number = 10;
            float money = 20.5f;
            string text = "Hello";
            bool isLogged = true;
            char myChar = 'A';
            decimal price = 99.99m;

            Console.WriteLine("number: " + number);
            Console.WriteLine("money: " + money);
            Console.WriteLine("text: " + text);
            Console.WriteLine("isLogged: " + isLogged);
            Console.WriteLine("myChar: " + myChar);
            Console.WriteLine("price: " + price);
        }
        
        // Zadanie 2
        {
            string myAge = "Age: ";
            int wifeAge = 18;
            string result = myAge + wifeAge;

            Console.WriteLine(result);
        }

        // Zadanie 3
        {
            bool isTrue = true;
            bool isFalse = false;
            bool isReallyTrue = true;

            bool and = isTrue && isFalse;
            bool or = isTrue || isReallyTrue;
            bool negative = !isFalse;

            Console.WriteLine("and: " + and);
            Console.WriteLine("or: " + or);
            Console.WriteLine("negative: " + negative);
        }
        
        // Zadanie 4
        {
            int a = 5;
            int b = 12;

            int add = a + b;
            int sub = a - b;
            int div = a / b;
            int mul = a * b;
            int mod = a % b;

            Console.WriteLine("add: " + add);
            Console.WriteLine("sub: " + sub);
            Console.WriteLine("div: " + div);
            Console.WriteLine("mul: " + mul);
            Console.WriteLine("mod: " + mod);
        }

        // Zadanie 5
        {
            string a = "Ala";
            string b = "ma";
            string c = "kota..";

            string result = a + b + c;

            Console.WriteLine(result);
        }
    }

    static void Rozgrzewka()
    {
        Console.WriteLine("Podaj swoje imię:");
        var name = Console.ReadLine();
        Console.WriteLine("Hello " + name);

        int result = 5 + 9;
    }
}