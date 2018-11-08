using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflections
{
    public class Cat
    {
        public string Breed { get; set; }

        public int Lives { get; set; }


        public int LoseLife(int lives)
        {
            int livesLeft = lives - 1;
            return livesLeft;

        } 
    }
}
