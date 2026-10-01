using System;

namespace tumakov_3
{
    internal class Program
    {
        static void Main()
        {
            //Упражнение 4.1
            Console.WriteLine("Упражнение 4.1");
            string[] Months = {"января", "февраля", "марта", "апреля", "мая", "июня",
                "июля", "августа", "сентября", "октября", "ноября", "декабря"};
            int[] Days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 }; //Сколько дней в каждом месяце (невисокосный год)
            Console.WriteLine("Введите число (номер дня в году): ");
            var IsNum = int.TryParse(Console.ReadLine(), out var Day);
            if (IsNum)
            {
                var MonthNow = 0;
                var DayOfYear = Day;
                while (DayOfYear > Days[MonthNow]) //Будем вычитать дни, пока введенное число больше чем количество дней в следующем месяце
                {
                    DayOfYear -= Days[MonthNow];
                    MonthNow++;
                }
                Console.WriteLine($"Числу {Day} соответствует дата: {DayOfYear} {Months[MonthNow]}");
            }
            else
                Console.WriteLine("Введено не числовое значение!");

            //Упражнение 4.2
            Console.WriteLine("Упражнение 4.2");
            string[] months = {"января", "февраля", "марта", "апреля", "мая", "июня",
                "июля", "августа", "сентября", "октября", "ноября", "декабря"};
            int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            Console.WriteLine("Введите число (номер дня в году): ");
            var isNum = int.TryParse(Console.ReadLine(), out var day);
            try
            {
                if (!isNum)
                {
                    throw new FormatException(); //Выброс исключения, если isNum - False, т.е. там находится не число

                }
                if (day < 1 || day > 365)
                {
                    throw new ArgumentOutOfRangeException(); //Выброс исключения, если введенное пользователем число находится за пределом диапазона (1 - 365)
                }
                var monthNow = 0;
                var dayOfYear = day;
                while (dayOfYear > days[monthNow])
                {
                    dayOfYear -= days[monthNow];
                    monthNow++;
                }
                Console.WriteLine($"Числу {day} соответствует дата: {dayOfYear} {months[monthNow]}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введено не число");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Ошибка: введенное число не из заданного диапазона");
            }
                
            //Домашнее задание 4.1
            Console.WriteLine("Домашнее задание 4.1");
            string[] monthsNew = {"января", "февраля", "марта", "апреля", "мая", "июня",
                "июля", "августа", "сентября", "октября", "ноября", "декабря"};
            Console.WriteLine("Введите число (номер дня в году): ");
            var isNumNew = int.TryParse(Console.ReadLine(), out var dayNew);
            Console.WriteLine("Введите текущий год: ");
            var isYear = int.TryParse(Console.ReadLine(), out var year);
            try
            {
                if (!isNumNew || !isYear)
                {
                    throw new FormatException();
                }
                if ((dayNew > 0 && dayNew < 367) && (year % 400 == 0 || (year % 100 != 0 && year % 4 == 0))) //Проверка на високосный год
                {
                    int[] daysNew = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                    var monthNew = 0;
                    var dayOnYear = dayNew;
                    while (dayOnYear > daysNew[monthNew])
                    {
                        dayOnYear -= daysNew[monthNew];
                        monthNew++;
                    }
                    Console.WriteLine($"Числу {dayNew} соответствует дата: {dayOnYear} {monthsNew[monthNew]} {year} года");
                }
                else if (dayNew > 0 && dayNew < 366)
                {
                    int[] daysNew = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                    var monthNew = 0;
                    var dayOnYear = dayNew;
                    while (dayOnYear > daysNew[monthNew])
                    {
                        dayOnYear -= daysNew[monthNew];
                        monthNew++;
                    }
                    Console.WriteLine($"Числу {dayNew} соответствует дата: {dayOnYear} {monthsNew[monthNew]} {year} года");
                }
                else
                    throw new ArgumentOutOfRangeException();
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введено не число");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Ошибка: введенное число не из заданного диапазона");
            }
        }
    }
}
