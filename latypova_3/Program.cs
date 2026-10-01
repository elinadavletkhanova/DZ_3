using latypova_3.Enum;
using System;

namespace latypova_3
{
    internal class Program
    {
        static void Main()
        {
            //Задание 1
            Console.WriteLine("Задание 1"); //Проверить последовательность на упорядоченность
            Console.WriteLine("Введите 10 чисел в столбик: ");
            int[] numbers = new int[10]; //Создаём 10 ячеек под 10 чисел
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i + 1}. ");
                if (!int.TryParse(Console.ReadLine(), out numbers[i]))
                    Console.WriteLine("Введено не число, записывается 0");
            }
            var flag = true; //Создадим флаг, чтобы в случае не нахождения ошибок сохранить true в переменной и объявить, что вся посл-ть упорядочена
            for (int j = 0; j < numbers.Length - 1; j++)
            {
                if (numbers[j + 1] <= numbers[j])
                {
                    flag = false;
                    Console.WriteLine($"Последовательность обрывается на {j + 2} элементе"); //j + 2, т.к. если написать j + 1, то выведет,
                                                                                             //что посл-ть обрывается на правильном элементе
                    break;
                }
            }
            if (flag)
                Console.WriteLine("Последовательность упорядочена");

            //Задание 2
            Console.WriteLine("Задание 2"); //Вывести достоинство карты по её номеру k (от 6 до 14)
            Console.WriteLine("Введите число k (от 6 до 14): ");
            try
            {
                if (!int.TryParse(Console.ReadLine(), out var num)) //Если введенная строка не является числом
                    throw new FormatException();
                if (num < 6 || num > 14)
                    throw new ArgumentOutOfRangeException();
                string[] cards = { "шестёрка", "семёрка", "восьмёрка", "девятка", "десятка", "валет", "дама", "король", "туз" };
                Console.WriteLine($"Номеру {num} соответствует карта - {cards[num - 6]}"); // -6, т.к. индексация в cards с нуля,
                                                                                           // а num вводим с числа 6 и до 14
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введено не число");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Ошибка: введенное число не из заданного диапазона");
            }
            finally
            {
                Console.WriteLine("Программа завершила свою работу");
            }

            //Задание 3
            Console.WriteLine("Задание 3"); //Вывести алкогольный напиток в соответствии с профессией, которая вводится с клавиатуры
            Console.WriteLine("Введите профессию (jabroni, school counselor, bike gang member, programmer, politician, rapper and others): ");
            var profession = Console.ReadLine();
            switch (profession.ToLower()) //Приводим всё к одному регистру
            {
                case "jabroni": Console.WriteLine("Patron Tequila"); break;
                case "school counselor": Console.WriteLine("Anything with Alcohol"); break;
                case "programmer": Console.WriteLine("Hipster Craft Beer"); break;
                case "bike gang member": Console.WriteLine("Moonshine"); break;
                case "politician": Console.WriteLine("Your tax dollars"); break;
                case "rapper": Console.WriteLine("Cristal"); break;
                default: Console.WriteLine("Beer"); break; //anything else
            }

            //Задание 4
            Console.WriteLine("Задание 4"); //С помощью enum выводить по номеру с клавиатуры соответствующий день в неделе
            Console.WriteLine("Введите номер дня в неделе: ");
            try
            {
                if (!byte.TryParse(Console.ReadLine(), out var day))
                    throw new FormatException();
                if (day < 1 || day > 7)
                    throw new ArgumentOutOfRangeException();
                Weekday nameDay = (Weekday)day;
                Console.WriteLine($"{day} день в неделе - это {nameDay}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введено не число");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Ошибка: введенное число не из заданного диапазона");
            }

            //Задание 5
            Console.WriteLine("Задание 5"); //Обойти массив строк и посчитать сколько кукол хранится в нём
            string[] toys = { "LEGO", "Hello Kitty", "toy car", "puzzles", "Barbie doll",
                "Barbie doll", "ball", "Barbie doll", "slime", "Hello Kitty", "squishy", "pop it" };
            var dollsCount = 0;
            foreach (var toy in toys)
            {
                if (toy == "Hello Kitty" || toy == "Barbie doll")
                {
                    dollsCount++;
                }
            }
            Console.WriteLine($"В сумке кукол: {dollsCount}");
        }      
    }
}
