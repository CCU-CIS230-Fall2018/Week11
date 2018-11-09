using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace Week11Excercise
{
    public class Status
    {
        public string RankingStatus { get; set; }
        public string UpwardGrowth { get; set; }

        public void SetRanking()
        {
            this.RankingStatus = "High";
            this.UpwardGrowth = "Impossible";
        }
    }
}
