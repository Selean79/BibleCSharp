using System;

namespace EnumProgramm
{
    class Program
    {
        enum WeekDays
        {
            Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        }
        static void Main(string[] args)
        {

            WeekDays day = WeekDays.Monday;
            Console.WriteLine(day);
            Console.WriteLine(WeekDays);

            Console.WriteLine("Hello World!");
        }
    }
}
