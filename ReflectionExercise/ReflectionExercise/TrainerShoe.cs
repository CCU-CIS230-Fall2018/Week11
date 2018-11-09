using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionExercise
{
    public class TrainerShoe
    {
        public string Model { get; set; }
        public int Mileage { get; set; }
        public bool SpentTicker { get; set; }

        public TrainerShoe(string model, int mileage, bool spentTicker)
        {
            Model = model;
            Mileage = mileage;
            SpentTicker = spentTicker;
        }

        public bool ShoeTrainableCheck()
        {
            if (this.Mileage > 350)
            {
                this.SpentTicker = true;
                return this.SpentTicker;
            }
            else
            {
                this.SpentTicker = false;
                return this.SpentTicker;
            }
        }
    }
}
