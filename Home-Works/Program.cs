using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Home_Works
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1
            /*int n = int.Parse(Console.ReadLine());
            int s = 0;
            for (int i = 0; i <= n; i++)
            {
                s += i;
            }
            Console.WriteLine($"Summa: {s}");*/

            // 2
            /*Console.Write("Рақами n-ро ворид кунед: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
                Console.WriteLine("");
            }*/

            // 3
            /*Console.Write("Рақами n-ро ворид кунед: ");
            int n = int.Parse(Console.ReadLine());
            int factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            Console.WriteLine($"Факториали {n}! = {factorial}");*/

            // 4
            /*Console.Write("Адади n-ро ворид кунед: ");
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0) count++;
            }
            if (count <= 2)
            {
                Console.WriteLine($"{n} адади содда аст.");
            }
            else
            {
                Console.WriteLine($"{n} адади мураккаб аст.");
            }*/

            // 5
            /*Console.Write("Адади n-ро ворид кунед: ");
            int n = int.Parse(Console.ReadLine());
            int reverse;
            while (n != 0)
            {
                reverse = n % 10;
                Console.Write(reverse);
                n /= 10;
            }*/

            // 6
            /*Console.Write("Адади n-ро ворид кунед: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int square = 1;
            for (int i = 1; i <= n; i++)
            {
                square *= i;
                sum += square;
            }
            Console.WriteLine($"Суммаи квадратҳо баробар аст ба: {sum}");*/

            // 7
            /*Console.Write("Адади n-ро ворид кунед: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    Console.WriteLine(i);
            }*/

            // 8
            /*Console.Write("Адади n-ро ворид кунед: ");
            int n = int.Parse(Console.ReadLine());
            Random random = new Random();
            int r = random.Next(1, 50);
            int count = 0;
            while (n >= 1 && n <= 50)
            {
                count++;
                Console.Write("Адади n-ро ворид кунед: ");
                n = int.Parse(Console.ReadLine());
                if (n == r)
                {
                    Console.WriteLine("Шумо бурдед!");
                    break;
                }
            }
            Console.WriteLine($"Шумо {count} бор кӯшиш кардед, то рақами дурустро ёбед.");*/

            // 9
            /*for (int i = 1; i <= 500; i++)
            {
                int sum = 0;
                int num = i;
                while (num > 0)
                {
                    sum += num % 10;
                    num /= 10;
                }
                if (sum == 10)
                {
                    Console.WriteLine(i);
                }
            }*/

            // 10
            /*Console.Write("Адади n-ро ворид кунед: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int sign = -1;
            for (int i = 1; i <= n; i++)
            {
                sign *= -1;
                sum += sign * i;
            }
            Console.WriteLine($"Сумма ряда: {sum}");*/

            // 11
            /*Console.Write("Адади n-ро ворид кунед: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);*/

            // 12
            /*int i = 0;
            int count = 0;
            do
            {
                i++;
                if (i % 9 == 0)
                {
                    count++;
                    Console.WriteLine(i);
                }
            }
            while (i <= 100);*/

            // 13
            /*Console.Write("Адади n-ро ворид кунед: ");
            int num = int.Parse(Console.ReadLine());
            int original = num;
            int reversed = 0;

            if (num < 0)
            {
                Console.WriteLine("Рақам палиндромом нест.");
                return;
            }

            while (num > 0)
            {
                int digit = num % 10;
                reversed = reversed * 10 + digit;
                num /= 10;
            }

            if (original == reversed)
                Console.WriteLine("Рақам палиндромом аст.");
            else
                Console.WriteLine("Рақам палиндромом нест.");*/

            // 17
            /*Console.Write("Адади n-ро ворид кунед: ");
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            while (n != 0)
            {
                n /= 10;
                count++;
            }
            Console.WriteLine(count);*/

            // 18
            /*Console.Write("Адади n-ро ворид кунед: ");
            int n = int.Parse(Console.ReadLine());
            int factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            Console.WriteLine("Факториал: " + factorial);*/

            // 19
            /*Console.Write("Адади n-ро ворид кунед: ");
            int n = int.Parse(Console.ReadLine());
            int digit = 0;
            int digitSum = 0;
            while (n != 0)
            {
                digit = n % 10;
                digitSum += digit;
                n /= 10;
            }
            Console.WriteLine("Суммаи рақамҳо: " + digitSum);*/

            // 20
            /*Console.Write("Адади n-ро ворид кунед: ");
            int n = int.Parse(Console.ReadLine());
            int original = n;
            int reserve = 0;
            while (n > 0)
            {
                int digit = n % 10;
                reserve = reserve * 10 + digit;
                n /= 10;
            }
            Console.WriteLine(original * original + reserve * reserve);*/

            // 22
            /*Console.Write("Адади n-ро ворид кунед: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 2; i <= n; i++)
            {
                bool isPrime = true;
                for (int j = 2; j * j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);*/

            // 24
            /*Console.Write("Адади n-ро ворид кунед: ");
            int n = int.Parse(Console.ReadLine());
            int sign = -1;
            for (int i = 1; i <= n; i++)
            {
                sign *= -1;
                Console.WriteLine(i * sign);
            }*/

            // 25
            /*Console.Write("Адади n-ро ворид кунед: ");
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);*/

            /*int[,] kara = new int[9, 9];
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    kara[i, j] = i * j;
                    Console.Write(kara[i, j] + " ");
                }
                Console.WriteLine();
            }*/

            /*int[,] chess = new int[9, 9];
            Console.Write("X: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Y: ");
            int y = int.Parse(Console.ReadLine());
            int horse = chess[x, y];

            for (int i = 1; i <= 8; i++)
            {
                for (int j = 1; j <= 8; j++)
                {
                    if ((i == x + 2 && j == y + 1) || (i == x + 2 && j == y - 1) ||
                        (i == x - 2 && j == y + 1) || (i == x - 2 && j == y - 1) ||
                        (i == x + 1 && j == y + 2) || (i == x + 1 && j == y - 2) ||
                        (i == x - 1 && j == y + 2) || (i == x - 1 && j == y - 2))
                    {
                        Console.WriteLine($"Рафта метавонад ба: ({i}, {j})");
                    }
                }
            }*/

            Console.Write("Column: ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Row: ");
            int r = int.Parse(Console.ReadLine());

            int[,] arr = new int[c, r];

            Random random = new Random();

            for (int i = 0; i < c; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    arr[i, j] = random.Next(1, 10);
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("----------");

            bool isEven = false;

            for (int i = 0; i < c; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    if (arr[i, j] % 2 == 0)
                    {
                        isEven = true;
                        break;
                    }
                }
                if (isEven == false) Console.WriteLine("Хамаи элементхои сатри " + i + " ток аст");
            }
        }
    }
}