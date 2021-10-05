using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuckNorrisJokes
{
    public class Categories
    {
    }
    public class Joke
    {
        public string value { get; set; }

        public override string ToString()
        {
            return value;
        }

    }
}
