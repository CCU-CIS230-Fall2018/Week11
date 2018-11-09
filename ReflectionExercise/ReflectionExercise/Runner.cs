using System;

namespace ReflectionExercise
{
    public class Runner
    {
        public int Mileage { get; set; }
        public string Team { get; set; }

        public Runner(int mileage, string team)
        {
            Mileage = mileage;
            Team = team;
        }

        public double DailyMileage()
        {
            double dailyMileage = this.Mileage / 7;
            return dailyMileage;
        }
    }
}
