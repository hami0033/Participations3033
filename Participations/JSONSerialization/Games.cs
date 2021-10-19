using System;
using System.Collections.Generic;
using System.Text;

namespace JSONSerialization
{
    public class Games
    {
        public string name { get; set; }
        public string platform { get; set; }
        public DateTime releaseDate { get; set; }
        public string summary { get; set; }
        public int metaScore { get; set; }
        public double userReview { get; set; }


        public Games()
        {
            name = string.Empty;
            platform = string.Empty;
            releaseDate = DateTime.Now;
            summary = string.Empty;
            metaScore = 0;
            userReview = 0;
        }
    }
}
