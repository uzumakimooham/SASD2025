using System;

namespace Refactoring101
{
    public class QuestionsAndAnswers
    {
        // 1. Mysterious Name → ตั้งชื่อให้สื่อความหมาย
        public double GetMax(double first, double second)
        {
            return first > second ? first : second;
        }

        // 2. Duplicate Code → Extract Method
        public void Print()
        {
            PrintPerson("Mr. Harry Potter");
            PrintPerson("Ms. Mary Poppin");
            PrintPerson("Mr. Johny Black");
        }

        private void PrintPerson(string name)
        {
            Console.WriteLine("***********************");
            Console.WriteLine($"   {name}");
            Console.WriteLine("***********************");
            Console.WriteLine();
        }

        // 3. Shotgun Surgery → ใช้ Constant กลาง
        private const int StudentCount = 48;

        public class StudentDisplayer
        {
            public void DisplayStudents()
            {
                Console.WriteLine($"Student Count = {StudentCount}");
            }
        }

        public class StudentReporter
        {
            public void PrintTotal()
            {
                Console.WriteLine($"Total Students : {StudentCount}");
            }
        }

        // 4 + 5. Data Clump + Feature Envy → สร้าง Date class
        public void PrintDate(Date date)
        {
            Console.WriteLine(date.Format());
        }
    }


    public class Date
    {
        public int Day { get; }
        public int Month { get; }
        public int Year { get; }

        public Date(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public string Format()
        {
            return $"{Day:00}/{Month:00}/{Year:0000}";
        }
    }
}
