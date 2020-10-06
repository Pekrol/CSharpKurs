using System;
using System.Collections.Generic;
using System.Linq;


namespace StudentDiary
{
    class Diary
    {
        public Diary()
        {
            ratings = new List<float>();
            Count++;
        }
        // Stan (zmienne - pola)
        private List<float> ratings;

        public static long Count = 0;

        // Zachowania
        /// <summary>
        /// Dodawanie nowej oceny
        /// </summary>
        /// <param name="rating">ocena</param>
        public void AddRating(float rating)
        {
            if (rating >= 0 && rating <= 10)
            {
                ratings.Add(rating);
            }
        }
        /// <summary>
        /// Obliczanie statystyk
        /// </summary>
        /// <returns></returns>
        internal DiaryStatistics ComputeStatistics()
        {
            DiaryStatistics stats = new DiaryStatistics();
            float sum = 0f;
            foreach (var rating in ratings)
            {
                sum = sum + rating;  // optional  -- - --  sum+= rating;
            }

            stats.AverageGrade = sum / ratings.Count();
            stats.MaxGrade = ratings.Max();
            stats.MinGrade = ratings.Min();
           
            return stats;
        }

        
    }
}
