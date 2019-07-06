using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();
            diary.AddRating(5);
            diary.AddRating(8.5f);
            diary.AddRating(4.7f);

            DiaryStatistics stats = diary.ComputeStatistics();

            Console.WriteLine("Średnia wartośc: " + stats.AverageGrade);
            Console.WriteLine("Max wartośc: " + stats.MaxGrade);
            Console.WriteLine("Min wartośc: " + stats.MinGrade);


            Diary diary2 = new Diary();
            diary2.AddRating(5);
            diary2.AddRating(8.5f);
            diary2.AddRating(4.7f);
            diary2.AddRating(9.7f);

            stats = diary2.ComputeStatistics();

            Console.WriteLine("Średnia wartośc: " + stats.AverageGrade);
            Console.WriteLine("Max wartośc: " + stats.MaxGrade);
            Console.WriteLine("Min wartośc: " + stats.MinGrade);
        }
    }
}
